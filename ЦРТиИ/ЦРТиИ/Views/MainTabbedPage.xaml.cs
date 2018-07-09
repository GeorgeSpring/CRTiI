using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ЦРТиИ.Models;

namespace ЦРТиИ.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage ()
        {
            InitializeComponent();
            ToolbarItem tl = new ToolbarItem { Text = "Баланс: 100", Order = ToolbarItemOrder.Primary, Priority = 0, Parent = this };
            ToolbarItems.Add(tl);
            List<Competition> competitions = new List<Competition>
            {
                new Competition()
                {
                    Name = "Всероссийский конкурс творческих работ «Осеннее вдохновение»".ToUpper(),
                    AgeСategories = new List<string>(){"5-7","8-11","12-15","16-18","18+" },
                    DescriptionShort = "День государственного флага РФ – праздник, объединяющий всех россиян в поддержку свободы и независимости.",
                    StartDate = DateTime.Now,
                    Category = "Детям",
                    DescriptionFull = "Листая страницы истории, каждый россиянин останавливает свой взор на главном празднике страны. Это День России. Совсем еще молодой праздник, но такой важный и всеми любимый. Предлагаем поделиться своими эмоциями и впечатлениями об этом дне и нашей могучей державе во всероссийском конкурсе «Россия – Родина моя», посвященному Дню России (12 июня). К участию в конкурсе приглашаются участники от 5 лет, количество работ от одного автора не ограничено. По итогам конкурса, жюри определит победителей по возрастным категориям и номинациям. Победители будут награждены дипломами I, II и III степени А каждый конкурсант получит Диплом участника, руководители – Благодарственные письма! Конкурс проводится с целью приобщения учащихся к художественному творчеству; выявления и раскрытия творчески одаренных учащихся школ города и области; пропаганда народных традиций; способствовать воспитанию у детей и взрослых патриотических чувств, уважения и любви к Родине.",
                    Nominations = new List<Nomination>(){
                        new Nomination() {
                        Name = "Россия – наша общая Родина",Category= "Рисунок, Презентация, Фото",FileType="doc, docx"
                        },
                         new Nomination() {
                        Name = "Моя малая Родина",Category= "Рисунок, Презентация, Фото, Поделка",FileType="pdf"
                        }, new Nomination() {
                        Name = "Россия – наша общая Родина",Category= "Рисунок, Презентация, Фото",FileType="doc, docx"
                        } },
                    AttachedFiles = new File(){Name = "Положение о конкурсе", Uri = @"https://dpo.imef.ru/upload/contest/3a32adff-4ebb-4d4e-a1d2-99c14b88a86e.pdf"}
                },
                new Competition()
                {
                    Name = "Народные традиции и промыслы",
                    AgeСategories = new List<string>(){"5-7","8-11","12-15","16-18","18+" },
                    DescriptionShort = "Конкурс интересный, объемный, поучавствуйте, не пожалеете!Конкурс интересный, объемный, поучавствуйте, не пожалеете!",
                    StartDate = DateTime.Now,
                    Category = "Воспитателям",
                    DescriptionFull = "Листая страницы истории, каждый россиянин останавливает свой взор на главном празднике страны. Это День России. Совсем еще молодой праздник, но такой важный и всеми любимый. Предлагаем поделиться своими эмоциями и впечатлениями об этом дне и нашей могучей державе во всероссийском конкурсе «Россия – Родина моя», посвященному Дню России (12 июня). К участию в конкурсе приглашаются участники от 5 лет, количество работ от одного автора не ограничено. По итогам конкурса, жюри определит победителей по возрастным категориям и номинациям. Победители будут награждены дипломами I, II и III степени А каждый конкурсант получит Диплом участника, руководители – Благодарственные письма! Конкурс проводится с целью приобщения учащихся к художественному творчеству; выявления и раскрытия творчески одаренных учащихся школ города и области; пропаганда народных традиций; способствовать воспитанию у детей и взрослых патриотических чувств, уважения и любви к Родине.",
                    Nominations = new List<Nomination>(){
                        new Nomination() {
                        Name = "Россия – наша общая Родина",Category= "Рисунок, Презентация, Фото",FileType="doc, docx"
                        },
                         new Nomination() {
                        Name = "Моя малая Родина",Category= "Рисунок, Презентация, Фото, Поделка",FileType="pdf"
                        }, new Nomination() {
                        Name = "Россия – наша общая Родина",Category= "Рисунок, Презентация, Фото",FileType="doc, docx"
                        } },
                    AttachedFiles = new File(){Name = "Положение о конкурсе", Uri = @"https://dpo.imef.ru/upload/contest/3a32adff-4ebb-4d4e-a1d2-99c14b88a86e.pdf"}
                },
                new Competition()
                {
                    Name = "Международный конкурс творческих работ \"Моя малая Родина\"",
                    AgeСategories = new List<string>(){"5-7","8-11","12-15","16-18","18+" },
                    DescriptionShort = "Малая родина – вечный спутник нашей жизни, опора наших трудов, вершитель наших судеб.",
                    StartDate = DateTime.Now,
                    Category = "Учителям",
                    DescriptionFull = "Листая страницы истории, каждый россиянин останавливает свой взор на главном празднике страны. Это День России. Совсем еще молодой праздник, но такой важный и всеми любимый. Предлагаем поделиться своими эмоциями и впечатлениями об этом дне и нашей могучей державе во всероссийском конкурсе «Россия – Родина моя», посвященному Дню России (12 июня). К участию в конкурсе приглашаются участники от 5 лет, количество работ от одного автора не ограничено. По итогам конкурса, жюри определит победителей по возрастным категориям и номинациям. Победители будут награждены дипломами I, II и III степени А каждый конкурсант получит Диплом участника, руководители – Благодарственные письма! Конкурс проводится с целью приобщения учащихся к художественному творчеству; выявления и раскрытия творчески одаренных учащихся школ города и области; пропаганда народных традиций; способствовать воспитанию у детей и взрослых патриотических чувств, уважения и любви к Родине.",
                    Nominations = new List<Nomination>(){
                        new Nomination() {
                        Name = "Россия – наша общая Родина",Category= "Рисунок, Презентация, Фото",FileType="doc, docx"
                        },
                         new Nomination() {
                        Name = "Моя малая Родина",Category= "Рисунок, Презентация, Фото, Поделка",FileType="pdf"
                        }, new Nomination() {
                        Name = "Россия – наша общая Родина",Category= "Рисунок, Презентация, Фото",FileType="doc, docx"
                        } },
                    AttachedFiles = new File(){Name = "Положение о конкурсе", Uri = @"https://dpo.imef.ru/upload/contest/3a32adff-4ebb-4d4e-a1d2-99c14b88a86e.pdf"}
                },
                new Competition()
                {
                    Name = "Всероссийский конкурс творческих работ «Боль и скорбь всей планеты»",
                    DescriptionShort = "Великий грех творить погибель детям Из самых страшных преступлений у людей Отдавшим душу злу, порочным сетям,",
                    StartDate = DateTime.Now,
                    AgeСategories = new List<string>(){"5-7","8-11","12-15","16-18","18+" },
                    Category = "Детям",
                    DescriptionFull = "Листая страницы истории, каждый россиянин останавливает свой взор на главном празднике страны. Это День России. Совсем еще молодой праздник, но такой важный и всеми любимый. Предлагаем поделиться своими эмоциями и впечатлениями об этом дне и нашей могучей державе во всероссийском конкурсе «Россия – Родина моя», посвященному Дню России (12 июня). К участию в конкурсе приглашаются участники от 5 лет, количество работ от одного автора не ограничено. По итогам конкурса, жюри определит победителей по возрастным категориям и номинациям. Победители будут награждены дипломами I, II и III степени А каждый конкурсант получит Диплом участника, руководители – Благодарственные письма! Конкурс проводится с целью приобщения учащихся к художественному творчеству; выявления и раскрытия творчески одаренных учащихся школ города и области; пропаганда народных традиций; способствовать воспитанию у детей и взрослых патриотических чувств, уважения и любви к Родине.",
                    Nominations = new List<Nomination>(){
                        new Nomination() {
                        Name = "Россия – наша общая Родина",Category= "Рисунок, Презентация, Фото",FileType="doc, docx"
                        },
                         new Nomination() {
                        Name = "Моя малая Родина",Category= "Рисунок, Презентация, Фото, Поделка",FileType="pdf"
                        }, new Nomination() {
                        Name = "Россия – наша общая Родина",Category= "Рисунок, Презентация, Фото",FileType="doc, docx"
                        } },
                    AttachedFiles = new File(){Name = "Положение о конкурсе", Uri = @"https://dpo.imef.ru/upload/contest/3a32adff-4ebb-4d4e-a1d2-99c14b88a86e.pdf"}
                },
                new Competition()
                {
                    Name = "Международный конкурс \"Мир сказок\"",
                    DescriptionShort = "Каждая сказка – мир, полный путешествий, приключений и волшебных загадок.",
                    StartDate = DateTime.Now,
                    AgeСategories = new List<string>(){"5-7","8-11","12-15","16-18","18+" },
                    Category = "Воспитателям",
                    DescriptionFull = "Листая страницы истории, каждый россиянин останавливает свой взор на главном празднике страны. Это День России. Совсем еще молодой праздник, но такой важный и всеми любимый. Предлагаем поделиться своими эмоциями и впечатлениями об этом дне и нашей могучей державе во всероссийском конкурсе «Россия – Родина моя», посвященному Дню России (12 июня). К участию в конкурсе приглашаются участники от 5 лет, количество работ от одного автора не ограничено. По итогам конкурса, жюри определит победителей по возрастным категориям и номинациям. Победители будут награждены дипломами I, II и III степени А каждый конкурсант получит Диплом участника, руководители – Благодарственные письма! Конкурс проводится с целью приобщения учащихся к художественному творчеству; выявления и раскрытия творчески одаренных учащихся школ города и области; пропаганда народных традиций; способствовать воспитанию у детей и взрослых патриотических чувств, уважения и любви к Родине.",
                    Nominations = new List<Nomination>(){
                        new Nomination() {
                        Name = "Россия – наша общая Родина",Category= "Рисунок, Презентация, Фото",FileType="doc, docx"
                        },
                         new Nomination() {
                        Name = "Моя малая Родина",Category= "Рисунок, Презентация, Фото, Поделка",FileType="pdf"
                        }, new Nomination() {
                        Name = "Россия – наша общая Родина",Category= "Рисунок, Презентация, Фото",FileType="doc, docx"
                        }
                    },
                    AttachedFiles = new File(){Name = "Положение о конкурсе", Uri = @"https://dpo.imef.ru/upload/contest/3a32adff-4ebb-4d4e-a1d2-99c14b88a86e.pdf"}
                }
            };
#if __IOS__
            var tabbedPage = new TabbedPage(){Title = "Конкурсы"};
#endif
#if __ANDROID__
            var tabbedPage = new ЦРТиИ.Droid.ScrollableTabbedPage() {Title = "Конкурсы" };
#endif
            tabbedPage.Children.Add(new ComptetetionListView(competitions) { Title = "Все конкурсы" });
            tabbedPage.Children.Add(new ComptetetionListView((from Competition in competitions where Competition.Category.ToLower() == "детям" select Competition).ToList()) { Title = "Детям" });
            tabbedPage.Children.Add(new ComptetetionListView((from Competition in competitions where Competition.Category.ToLower() == "воспитателям" select Competition).ToList()) { Title = "Воспитателям" });
            tabbedPage.Children.Add(new ComptetetionListView((from Competition in competitions where Competition.Category.ToLower() == "учителям" select Competition).ToList()) { Title = "Учителям" });
            tabbedPage.Children.Add(new ComptetetionListView(competitions) { Title = "Все конкурсы" });
            tabbedPage.Children.Add(new ComptetetionListView((from Competition in competitions where Competition.Category.ToLower() == "детям" select Competition).ToList()) { Title = "Детям" });
            tabbedPage.Children.Add(new ComptetetionListView((from Competition in competitions where Competition.Category.ToLower() == "воспитателям" select Competition).ToList()) { Title = "Воспитателям" });
            tabbedPage.Children.Add(new ComptetetionListView((from Competition in competitions where Competition.Category.ToLower() == "учителям" select Competition).ToList()) { Title = "Учителям" });
            Children.Add(tabbedPage);
        }
    }
}