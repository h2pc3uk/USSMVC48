namespace USSMVC48.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using USSMVC48.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<USSMVC48.Data.USSMVC48Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(USSMVC48.Data.USSMVC48Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var form = new Form
            {
                Title = "全國農業金庫112年度顧客滿意度問卷調查表",
                CreatedDate = DateTime.Now
            };

            context.Forms.Add(form);
            context.SaveChanges();

            var question1 = new Question
            {
                FormID = form.FormID,
                Text = "請問您是否曾於本公司開戶？",
                IsSkippable = false,
                IsRequired = true,
                IsMultipleChoice = false
            };

            var question2 = new Question
            {
                FormID = form.FormID,
                Text = "請問您開戶的原因？",
                IsSkippable = true,
                IsRequired = true,
                IsMultipleChoice = false
            };

            var question3 = new Question
            {
                FormID = form.FormID,
                Text = "請問您最常與本公司往來的營業單位？",
                IsSkippable = false,
                IsRequired = true,
                IsMultipleChoice = false
            };

            var question4 = new Question
            {
                FormID = form.FormID,
                Text = "請問您與本公司往來的主要辦理項目？ (可複選)",
                IsSkippable = false,
                IsRequired = true,
                IsMultipleChoice = true
            };

            var question5 = new Question
            {
                FormID = form.FormID,
                Text = "請問您對本公司行員服務態度是否感到滿意？",
                IsSkippable = false,
                IsRequired = true,
                IsMultipleChoice = false
            };

            var question6 = new Question
            {
                FormID = form.FormID,
                Text = "請問您對本公司行員專業能力是否感到滿意？",
                IsSkippable = false,
                IsRequired = true,
                IsMultipleChoice = false
            };

            var question7 = new Question
            {
                FormID = form.FormID,
                Text = "請問您對本公司作業效率是否感到滿意？",
                IsSkippable = false,
                IsRequired = true,
                IsMultipleChoice = false
            };

            var question8 = new Question
            {
                FormID = form.FormID,
                Text = "請問您對本公司之整體滿意度？",
                IsSkippable = false,
                IsRequired = true,
                IsMultipleChoice = false
            };

            var question9 = new Question
            {
                FormID = form.FormID,
                Text = "請問您對本公司營業廳環境是否感覺整潔舒適？",
                IsSkippable = false,
                IsRequired = true,
                IsMultipleChoice = false
            };

            var question10 = new Question
            {
                FormID = form.FormID,
                Text = "在您與其他金融機構往來的經驗中，您認為本公司還有哪些需要改進的地方？(可複選)",
                IsSkippable = false,
                IsRequired = true,
                IsMultipleChoice = true
            };

            var question11 = new Question
            {
                FormID = form.FormID,
                Text = "請問您是否使用過本公司的網路銀行？",
                IsSkippable = false,
                IsRequired = true,
                IsMultipleChoice = false
            };

            var question12 = new Question
            {
                FormID = form.FormID,
                Text = "請問您使用本公司網路銀行之頻率？",
                IsSkippable = true,
                IsRequired = true,
                IsMultipleChoice = false
            };

            var question13 = new Question
            {
                FormID = form.FormID,
                Text = "請問您使用本公司網路銀行之主要功能為何？ (可複選)",
                IsSkippable = true,
                IsRequired = true,
                IsMultipleChoice = true
            };

            var question14 = new Question
            {
                FormID = form.FormID,
                Text = "針對您選擇之項次，請問哪些功能您覺得最滿意？ (可複選)",
                IsSkippable = true,
                IsRequired = true,
                IsMultipleChoice = true
            };

            var question15 = new Question
            {
                FormID = form.FormID,
                Text = "針對您選擇之項次，請問哪些功能您覺得不滿意？ (可複選)",
                IsSkippable = true,
                IsRequired = true,
                IsMultipleChoice = true
            };

            var question16 = new Question
            {
                FormID = form.FormID,
                Text = "請問您認為本公司網路銀行還有哪些需要改進的地方？ (可複選)",
                IsSkippable = true,
                IsRequired = true,
                IsMultipleChoice = true
            };

            var question17 = new Question
            {
                FormID = form.FormID,
                Text = "用其他金融機構網路銀行之主要類別及功能為何？",
                IsSkippable = false,
                IsRequired = true,
                IsMultipleChoice = false
            };

            var question18 = new Question
            {
                FormID = form.FormID,
                Text = "您的使用經驗，請問您覺得哪一家金融機構的網路銀行最好用？",
                IsSkippable = false,
                IsRequired = true,
                IsMultipleChoice = false
            };

            var question19 = new Question
            {
                FormID = form.FormID,
                Text = "優點或特色為何？",
                IsSkippable = false,
                IsRequired = true,
                IsMultipleChoice = false
            };

            var question20 = new Question
            {
                FormID = form.FormID,
                Text = "其他意見(此欄位請您提供寶貴建議，以作為日後改進之參考。)",
                IsSkippable = false,
                IsRequired = true,
                IsMultipleChoice = false
            };

            var question21 = new Question
            {
                FormID = form.FormID,
                Text = "年齡",
                IsSkippable = false,
                IsRequired = true,
                IsMultipleChoice = false
            };

            var question22 = new Question
            {
                FormID = form.FormID,
                Text = "性別",
                IsSkippable = false,
                IsRequired = true,
                IsMultipleChoice = false
            };

            var question23 = new Question
            {
                FormID = form.FormID,
                Text = "縣市",
                IsSkippable = false,
                IsRequired = true,
                IsMultipleChoice = false
            };

            var question24 = new Question
            {
                FormID = form.FormID,
                Text = "行業",
                IsSkippable = false,
                IsRequired = true,
                IsMultipleChoice = false
            };

            context.Questions.Add(question1);
            context.Questions.Add(question2);
            context.Questions.Add(question3);
            context.Questions.Add(question4);
            context.Questions.Add(question5);
            context.Questions.Add(question6);
            context.Questions.Add(question7);
            context.Questions.Add(question8);
            context.Questions.Add(question9);
            context.Questions.Add(question10);
            context.Questions.Add(question11);
            context.Questions.Add(question12);
            context.Questions.Add(question13);
            context.Questions.Add(question14);
            context.Questions.Add(question15);
            context.Questions.Add(question16);
            context.Questions.Add(question17);
            context.Questions.Add(question18);
            context.Questions.Add(question19);
            context.Questions.Add(question20);
            context.Questions.Add(question21);
            context.Questions.Add(question22);
            context.Questions.Add(question23);
            context.Questions.Add(question24);
            context.SaveChanges();

            var optionForQuestion1 = new List<Option>
            {
                new Option
                {
                    QuestionID = question1.QuestionID,
                    Text = "是",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question1.QuestionID,
                    Text = "否(請跳到題號3作答)",
                    Type = "radio",
                    // SkipToQuestionID = question3.QuestionID
                }
            };

            var optionForQuestion2 = new List<Option>
            {
                new Option
                {
                    QuestionID = question2.QuestionID,
                    Text = "臺外幣存匯(薪轉、辦理自動轉帳、申辦數位存款帳戶)",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question2.QuestionID,
                    Text = "貸款(專案農貸、紓困貸款、房貸等)",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question2.QuestionID,
                    Text = "信託",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question2.QuestionID,
                    Text = "投資理財(黃金存摺、保險)",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question2.QuestionID,
                    Text = "其他",
                    Type = "text"
                }
            };

            var optionForQuestion3 = new List<Option>
            {
                new Option
                {
                    QuestionID = question3.QuestionID,
                    Text = "營業部",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question3.QuestionID,
                    Text = "桃園分行",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question3.QuestionID,
                    Text = "新竹分行",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question3.QuestionID,
                    Text = "臺中分行",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question3.QuestionID,
                    Text = "嘉義分行",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question3.QuestionID,
                    Text = "臺南分行",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question3.QuestionID,
                    Text = "高雄分行",
                    Type = "radio"
                }
            };

            var optionForQuestion4 = new List<Option>
            {
                new Option
                {
                    QuestionID = question4.QuestionID,
                    Text = "開戶(含申辦數位存款帳戶)",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question4.QuestionID,
                    Text = "臺外幣存匯(轉帳)",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question4.QuestionID,
                    Text = "貸款(專案農貸、紓困貸款、房貸等)",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question4.QuestionID,
                    Text = "信託",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question4.QuestionID,
                    Text = "繳費",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question4.QuestionID,
                    Text = "投資理財(黃金存摺、保險)",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question4.QuestionID,
                    Text = "農金聯名卡",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question4.QuestionID,
                    Text = "其他",
                    Type = "text"
                }
            };

            var optionForQuestion5 = new List<Option>
            {
                new Option
                {
                    QuestionID = question5.QuestionID,
                    Text = "非常滿意",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question5.QuestionID,
                    Text = "滿意",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question5.QuestionID,
                    Text = "普通",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID= question5.QuestionID,
                    Text = "不滿意",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question5.QuestionID,
                    Text = "非常不滿意",
                    Type = "radio"
                }
            };

            var optionForQuestion6 = new List<Option>
            {
                new Option
                {
                    QuestionID = question6.QuestionID,
                    Text = "非常滿意",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question6.QuestionID,
                    Text = "滿意",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question6.QuestionID,
                    Text = "普通",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID= question6.QuestionID,
                    Text = "不滿意",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question6.QuestionID,
                    Text = "非常不滿意",
                    Type = "radio"
                }
            };

            var optionForQuestion7 = new List<Option>
            {
                new Option
                {
                    QuestionID = question7.QuestionID,
                    Text = "非常滿意",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question7.QuestionID,
                    Text = "滿意",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question7.QuestionID,
                    Text = "普通",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID= question7.QuestionID,
                    Text = "不滿意",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question7.QuestionID,
                    Text = "非常不滿意",
                    Type = "radio"
                }
            };

            var optionForQuestion8 = new List<Option>
            {
                new Option
                {
                    QuestionID = question8.QuestionID,
                    Text = "非常滿意",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question8.QuestionID,
                    Text = "滿意",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question8.QuestionID,
                    Text = "普通",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID= question8.QuestionID,
                    Text = "不滿意",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question8.QuestionID,
                    Text = "非常不滿意",
                    Type = "radio"
                }
            };

            var optionForQuestion9 = new List<Option>
            {
                new Option
                {
                    QuestionID = question9.QuestionID,
                    Text = "非常滿意",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question9.QuestionID,
                    Text = "滿意",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question9.QuestionID,
                    Text = "普通",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID= question9.QuestionID,
                    Text = "不滿意",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question9.QuestionID,
                    Text = "非常不滿意",
                    Type = "radio"
                }
            };

            var optionForQuestion10 = new List<Option>
            {
                new Option
                {
                    QuestionID = question10.QuestionID,
                    Text = "親和力",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question10.QuestionID,
                    Text = "作業效率",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question10.QuestionID,
                    Text = "專業知識",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID= question10.QuestionID,
                    Text = "主動性與積極性",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question10.QuestionID,
                    Text = "處理問題的彈性及效率",
                    Type = "radio"
                }
            };

            var optionForQuestion11 = new List<Option>
            {
                new Option
                {
                    QuestionID = question11.QuestionID,
                    Text = "是",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question11.QuestionID,
                    Text = "否",
                    Type = "radio",
                    // SkipToQuestionID = question17.QuestionID
                },
            };

            var optionForQuestion12 = new List<Option>
            {
                new Option
                {
                    QuestionID = question12.QuestionID,
                    Text = "一周至少一次",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question12.QuestionID,
                    Text = "一個月至少一次",
                    Type = "radio",
                    SkipToQuestionID = question17.QuestionID
                },
                new Option
                {
                    QuestionID = question12.QuestionID,
                    Text = "三個月至少一次",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question12.QuestionID,
                    Text = "超過三個月才使用一次",
                    Type = "radio"
                },
            };

            var optionForQuestion13 = new List<Option>
            {
                new Option
                {
                    QuestionID = question13.QuestionID,
                    Text = "轉帳",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question13.QuestionID,
                    Text = "繳放款本息",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question13.QuestionID,
                    Text = "查詢臺幣活存帳戶餘額/明細",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question13.QuestionID,
                    Text = "查詢臺幣存放款利率",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question13.QuestionID,
                    Text = "申辦貸款(專案農貸、紓困貸款、房貸)",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question13.QuestionID,
                    Text = "申辦數位存款帳戶",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question13.QuestionID,
                    Text = "理財試算(存本取息、零存整付、整存整付、貸款期付金)",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question13.QuestionID,
                    Text = "其他",
                    Type = "text"
                }
            };

            var optionForQuestion14 = new List<Option>
            {
                new Option
                {
                    QuestionID = question14.QuestionID,
                    Text = "轉帳",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question14.QuestionID,
                    Text = "繳放款本息",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question14.QuestionID,
                    Text = "查詢臺幣活存帳戶餘額/明細",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question14.QuestionID,
                    Text = "查詢臺幣存放款利率",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question14.QuestionID,
                    Text = "申辦貸款(專案農貸、紓困貸款、房貸)",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question14.QuestionID,
                    Text = "申辦數位存款帳戶",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question14.QuestionID,
                    Text = "理財試算(存本取息、零存整付、整存整付、貸款期付金)",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question14.QuestionID,
                    Text = "其他",
                    Type = "text"
                }
            };

            var optionForQuestion15 = new List<Option>
            {
                new Option
                {
                    QuestionID = question15.QuestionID,
                    Text = "轉帳",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question15.QuestionID,
                    Text = "繳放款本息",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question15.QuestionID,
                    Text = "查詢臺幣活存帳戶餘額/明細",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question15.QuestionID,
                    Text = "查詢臺幣存放款利率",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question15.QuestionID,
                    Text = "申辦貸款(專案農貸、紓困貸款、房貸)",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question15.QuestionID,
                    Text = "申辦數位存款帳戶",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question15.QuestionID,
                    Text = "理財試算(存本取息、零存整付、整存整付、貸款期付金)",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question15.QuestionID,
                    Text = "其他",
                    Type = "text"
                }
            };

            var optionForQuestion16 = new List<Option>
            {
                new Option
                {
                    QuestionID = question16.QuestionID,
                    Text = "操作便利性",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question16.QuestionID,
                    Text = "系統穩定度",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question16.QuestionID,
                    Text = "介面美觀度",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question16.QuestionID,
                    Text = "其他",
                    Type = "text"
                }
            };

            var optionForQuestion17 = new List<Option>
            {
                new Option
                {
                    QuestionID = question17.QuestionID,
                    Text = "臺幣存匯(帳戶明細/餘額查詢、轉帳、轉定存/定存解約與變更)",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question17.QuestionID,
                    Text = "外幣存匯(買賣外幣、帳戶明細/餘額查詢、轉定存/定存解約與變更)",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question17.QuestionID,
                    Text = "支付/繳費",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question17.QuestionID,
                    Text = "臺外幣利率/匯率查詢",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question17.QuestionID,
                    Text = "貸款(信貸、房貸、貸款試算)",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question17.QuestionID,
                    Text = "信用卡(帳單資訊、繳卡費、查詢繳款紀錄/紅利點數、各項服務申請、線上辦卡/開卡/掛失)",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question17.QuestionID,
                    Text = "投資理財(基金、ETF、黃金存摺)",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question17.QuestionID,
                    Text = "其他(例如:薪資明細查詢、電子對帳單、進度查詢及補件)",
                    Type = "text"
                },
            };

            var optionForQuestion18 = new List<Option>
            {
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "台灣銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "臺灣土地銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "合作金庫商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "第一商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "華南商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "彰化商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "上海商業儲蓄銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "台北富邦商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "國泰世華商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "中國輸出入銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "高雄銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "兆豐國際商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "全國農業金庫",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "花旗(台灣)商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "中華開發工業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "王道商銀",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "臺灣中小企業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "渣打國際商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "台中商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "京城商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "匯豐(台灣)商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "瑞興商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "華泰商業銀行",
                    Type = "select"
                },new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "臺灣新光商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "陽信商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "板信商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "三信商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "聯邦商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "遠東國際商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "元大商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "永豐商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "玉山商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "凱基商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "星展(臺灣)商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "台新國際商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "日盛國際商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "安泰商業銀行",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question18.QuestionID,
                    Text = "中國信託商業銀行",
                    Type = "select"
                },

            };

            var optionForQuestion19 = new List<Option>
            {
                new Option
                {
                    QuestionID = question19.QuestionID,
                    Text = "操作便利性",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question19.QuestionID,
                    Text = "系統穩定度",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question19.QuestionID,
                    Text = "其他",
                    Type = "text"
                },
            };

            var optionForQuestion20 = new List<Option>
            {
                new Option
                {
                    QuestionID = question20.QuestionID,
                    Text = "期待農業金庫未來提供新業務",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question20.QuestionID,
                    Text = "期待農業金庫未來提供新商品",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question20.QuestionID,
                    Text = "無",
                    Type = "radio"
                },
            };

            var optionForQuestion21 = new List<Option>
            {
                new Option
                {
                    QuestionID = question21.QuestionID,
                    Text = "30歲以下",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question21.QuestionID,
                    Text = "31-40歲",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question21.QuestionID,
                    Text = "41-50歲",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question21.QuestionID,
                    Text = "51-64歲",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question21.QuestionID,
                    Text = "65歲(含)以上",
                    Type = "radio"
                },
            };

            var optionForQuestion22 = new List<Option>
            {
                new Option
                {
                    QuestionID = question22.QuestionID,
                    Text = "男",
                    Type = "radio"
                },
                new Option
                {
                    QuestionID = question22.QuestionID,
                    Text = "女",
                    Type = "radio"
                },
            };

            var optionForQuestion24 = new List<Option>
            {
                new Option
                {
                    QuestionID = question24.QuestionID,
                    Text = "農、林、漁、牧業",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question24.QuestionID,
                    Text = "礦業及土石採取業",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question24.QuestionID,
                    Text = "製造業",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question24.QuestionID,
                    Text = "電力及燃氣供應業",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question24.QuestionID,
                    Text = "用水供應及污染整治業",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question24.QuestionID,
                    Text = "營造業",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question24.QuestionID,
                    Text = "批發及零售業",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question24.QuestionID,
                    Text = "運輸及倉儲業",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question24.QuestionID,
                    Text = "住宿及餐飲業",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question24.QuestionID,
                    Text = "資訊及通訊傳播業",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question24.QuestionID,
                    Text = "金融及保險業",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question24.QuestionID,
                    Text = "不動產業",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question24.QuestionID,
                    Text = "專業、科學及技術服務業",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question24.QuestionID,
                    Text = "支援服務業",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question24.QuestionID,
                    Text = "公共行政及國防；強制性社會安全",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question24.QuestionID,
                    Text = "教育服務業",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question24.QuestionID,
                    Text = "醫療保健及社會工作服務業",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question24.QuestionID,
                    Text = "藝術、娛樂及休閒服務業",
                    Type = "select"
                },
                new Option
                {
                    QuestionID = question24.QuestionID,
                    Text = "其他服務業",
                    Type = "select"
                },
            };

            context.Options.AddRange(optionForQuestion1);
            context.Options.AddRange(optionForQuestion2);
            context.Options.AddRange(optionForQuestion3);
            context.Options.AddRange(optionForQuestion4);
            context.Options.AddRange(optionForQuestion5);
            context.Options.AddRange(optionForQuestion6);
            context.Options.AddRange(optionForQuestion7);
            context.Options.AddRange(optionForQuestion8);
            context.Options.AddRange(optionForQuestion9);
            context.Options.AddRange(optionForQuestion10);
            context.Options.AddRange(optionForQuestion11);
            context.Options.AddRange(optionForQuestion12);
            context.Options.AddRange(optionForQuestion13);
            context.Options.AddRange(optionForQuestion14);
            context.Options.AddRange(optionForQuestion15);
            context.Options.AddRange(optionForQuestion16);
            context.Options.AddRange(optionForQuestion17);
            context.Options.AddRange(optionForQuestion18);
            context.Options.AddRange(optionForQuestion19);
            context.Options.AddRange(optionForQuestion20);
            context.Options.AddRange(optionForQuestion21);
            context.Options.AddRange(optionForQuestion22);
            context.Options.AddRange(optionForQuestion24);
        }
    }
}