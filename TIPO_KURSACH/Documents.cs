using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Globalization;

namespace TIPO_KURSACH
{
    class Documents
    {
        public void CreateCheckDocument(int IDComputer, string lastNameClient, string firstNameClient, string otchestvo, string dateTimeBegin, string dateTimeEnd, string money)
        {
            Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();
            object missing = System.Reflection.Missing.Value;
            object path = @"C:\Users\Геральт из Ривии\Desktop\TIPO_KURSACH\TestDoc.dot";
            Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref path, ref missing, ref missing, ref missing);

            foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
            {
                Microsoft.Office.Interop.Word.Range headerRange =
                section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;

                headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);

                headerRange.ParagraphFormat.Alignment =
                Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
                headerRange.Font.Size = 10;
                headerRange.Text = "Счёт по ФИО " + lastNameClient + " " + firstNameClient + " " + otchestvo;
            }

            //Добавление нижнего колонтитула
            foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
            {
                //
                Microsoft.Office.Interop.Word.Range footerRange =
        wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                //Установка цвета текста
                footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdAuto;
                //Размер
                footerRange.Font.Size = 10;
                //Установка расположения по центру
                footerRange.ParagraphFormat.Alignment =
                    Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                //Установка текста для вывода в нижнем колонтитуле
                footerRange.Text = "Подпись сотрудника:_____________                                               Подпись клиента:_____________";
            }

            Microsoft.Office.Interop.Word.Paragraph txt = document.Content.Paragraphs.Add(ref missing);

            Table table = document.Tables.Add(txt.Range, 2, 7, ref missing, ref missing);

            table.Borders.Enable = 1;

            winword.Visible = true;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    var cell = table.Cell(i + 1, j + 1);

                    if (cell.RowIndex == 1)
                    {
                        switch (j)
                        {
                            case 0:
                                cell.Range.Text = "Номер компьютера";
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                            case 1:
                                cell.Range.Text = "Фамилия";
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                            case 2:
                                cell.Range.Text = "Имя";
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                            case 3:
                                cell.Range.Text = "Отчество";
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                            case 4:
                                cell.Range.Text = "Время начала работы";
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                            case 5:
                                cell.Range.Text = "Время окончания работы";
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                            case 6:
                                cell.Range.Text = "Сумма к оплате";
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                        }
                    }
                    else
                    {
                        switch (j)
                        {
                            case 0:
                                cell.Range.Text = IDComputer.ToString();
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                            case 1:
                                cell.Range.Text = lastNameClient;
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                            case 2:
                                cell.Range.Text = firstNameClient;
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                            case 3:
                                cell.Range.Text = otchestvo;
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                            case 4:
                                cell.Range.Text = dateTimeBegin;
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                            case 5:
                                cell.Range.Text = dateTimeEnd;
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                            case 6:
                                cell.Range.Text = money;
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                        }
                    }
                }
            }
        }

        public void CreateReceipsDocument()
        {

        }
    }
}