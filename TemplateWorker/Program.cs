using System;
using System.Linq;
using TemplateWorker.Models;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace TemplateWorker
{
    class Program
    {
        static void ChangeText(List<EhealthTemplate> templates, Regex regexOldText, string stringRegexOldText, string newText)
        {
            foreach (var el in templates)
            {
                var matches = regexOldText.Matches(el.TextData);

                foreach (var match in matches)
                {
                    el.TextData = Regex.Replace(el.TextData, stringRegexOldText, newText);
                }
            }
        }

        static void Main(string[] args)
        {
            using (var context = new MedPrimeCost_MISDEC_DEMOContext())
            {

                var templates = context.EhealthTemplates.ToList();

                var regexOldOrder2 = new Regex(@"\bприказу 6Ц и 6Ц п.1.1.1\w*\b");

                string stringRegexOldOrder2 = @"\bприказу 6Ц и 6Ц п.1.1.1\w*\b";

                string newOrder2 = "приказу №428";

                ChangeText(templates, regexOldOrder2, stringRegexOldOrder2, newOrder2);



                var regexOldOrder3 = new Regex(@"\bПриказ 6Ц\(796\)\w*");

                string stringRegexOldOrder3 = @"\bПриказ 6Ц\(796\)\w*";

                string newOrder3 = "Приказ №428";

                ChangeText(templates, regexOldOrder3, stringRegexOldOrder3, newOrder3);


                var regexOldOrder4 = new Regex(@"\bприказу 6Ц\s\(796\)\w*");

                string stringRegexOldOrder4 = @"\bприказу 6Ц\s\(796\)\w*";

                string newOrder4 = "приказу №428";

                ChangeText(templates, regexOldOrder4, stringRegexOldOrder4, newOrder4);


                var regexOldOrder5 = new Regex(@"\bприказу 6Ц\(796\)\w*");

                string stringRegexOldOrder5 = @"\bприказу 6Ц\(796\)\w*";

                string newOrder5 = "приказу №428";

                ChangeText(templates, regexOldOrder5, stringRegexOldOrder5, newOrder5);


                var regexOldOrder6 = new Regex(@"\b[Пп]риказу 6Ц\b");

                string stringRegexOldOrder6 = @"\b[Пп]риказу 6Ц\b";

                string newOrder6 = "приказу №428";

                ChangeText(templates, regexOldOrder6, stringRegexOldOrder6, newOrder6);


                var regexOldOrder = new Regex(@"\bПриказ 6Ц\b");

                string stringRegexOldOrder = @"\bПриказ 6Ц\b";

                string newOrder = "Приказ №428";

                ChangeText(templates, regexOldOrder, stringRegexOldOrder, newOrder);

                var testRegex = new Regex(@"\b[Пп]риказу №428\b");
                foreach (var el in templates)
                {
                    MatchCollection matches = testRegex.Matches(el.TextData);

                    foreach (Match match in matches)
                    {
                        Console.WriteLine($"{el.IdTemplate}, {match}, {el.LabelTemplate}"); ;
                    }
                }
            }

        


            //context.EhealthTemplates.UpdateRange(templates);
            //context.SaveChanges();

        
        }
    }
}
