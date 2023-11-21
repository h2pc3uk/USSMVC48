namespace USSMVC48.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Forms",
                c => new
                    {
                        FormID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FormID);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionID = c.Int(nullable: false, identity: true),
                        FormID = c.Int(nullable: false),
                        Text = c.String(),
                        IsSkippable = c.Boolean(nullable: false),
                        IsRequired = c.Boolean(nullable: false),
                        IsMultipleChoice = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.QuestionID)
                .ForeignKey("dbo.Forms", t => t.FormID, cascadeDelete: true)
                .Index(t => t.FormID);
            
            CreateTable(
                "dbo.Options",
                c => new
                    {
                        OptionID = c.Int(nullable: false, identity: true),
                        QuestionID = c.Int(nullable: false),
                        Text = c.String(),
                        Type = c.String(),
                        SkipToQuestionID = c.Int(),
                        Question_QuestionID = c.Int(),
                    })
                .PrimaryKey(t => t.OptionID)
                .ForeignKey("dbo.Questions", t => t.Question_QuestionID)
                .ForeignKey("dbo.Questions", t => t.SkipToQuestionID)
                .ForeignKey("dbo.Questions", t => t.QuestionID, cascadeDelete: true)
                .Index(t => t.QuestionID)
                .Index(t => t.SkipToQuestionID)
                .Index(t => t.Question_QuestionID);
            
            CreateTable(
                "dbo.Responses",
                c => new
                    {
                        ResponseID = c.Int(nullable: false, identity: true),
                        SurveySessionID = c.Guid(nullable: false),
                        QuestionID = c.Int(nullable: false),
                        OptionID = c.Int(),
                        AdditionalText = c.String(),
                    })
                .PrimaryKey(t => t.ResponseID)
                .ForeignKey("dbo.Options", t => t.OptionID)
                .ForeignKey("dbo.Questions", t => t.QuestionID, cascadeDelete: true)
                .Index(t => t.QuestionID)
                .Index(t => t.OptionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Responses", "QuestionID", "dbo.Questions");
            DropForeignKey("dbo.Responses", "OptionID", "dbo.Options");
            DropForeignKey("dbo.Questions", "FormID", "dbo.Forms");
            DropForeignKey("dbo.Options", "QuestionID", "dbo.Questions");
            DropForeignKey("dbo.Options", "SkipToQuestionID", "dbo.Questions");
            DropForeignKey("dbo.Options", "Question_QuestionID", "dbo.Questions");
            DropIndex("dbo.Responses", new[] { "OptionID" });
            DropIndex("dbo.Responses", new[] { "QuestionID" });
            DropIndex("dbo.Options", new[] { "Question_QuestionID" });
            DropIndex("dbo.Options", new[] { "SkipToQuestionID" });
            DropIndex("dbo.Options", new[] { "QuestionID" });
            DropIndex("dbo.Questions", new[] { "FormID" });
            DropTable("dbo.Responses");
            DropTable("dbo.Options");
            DropTable("dbo.Questions");
            DropTable("dbo.Forms");
        }
    }
}
