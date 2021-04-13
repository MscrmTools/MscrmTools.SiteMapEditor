using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MsCrmTools.SiteMapEditor
{
    public static class ExportToExcel
    {
        private static string Locale;

        internal static void Save(string fileName, TreeView tv, int locale, Control parentControl)
        {
            Locale = $"Title({locale})";
            var package = new ExcelPackage();

            foreach (TreeNode node in tv.Nodes[0].Nodes)
            {
                int rowCount = 4;
                var wkSheet = package.Workbook.Worksheets.Add(GetTitle(node));
                Dictionary<string, string> nodeTag = (Dictionary<string, string>)node.Tag;
                int colCount = 1;
                foreach (var kvp in nodeTag)
                {
                    wkSheet.Cells[1, colCount].Value = kvp.Key + " : " + kvp.Value;

                    colCount++;
                }

                wkSheet.Cells[3, 1].Value = "Group";
                wkSheet.Cells[3, 1, 3, 4].Style.Font.Bold = true;

                wkSheet.Cells[3, 2].Value = "Properties";
                wkSheet.Cells[3, 3].Value = "Sub-Area";
                wkSheet.Cells[3, 4].Value = "SA Properties";

                int treeNodeCount = 1;

                foreach (TreeNode groupNode in node.Nodes)
                {
                    int rowStart = rowCount;

                    // rowStart = rowCount;
                    if (groupNode.Text == "Titles")
                    {
                        continue;
                    }

                    wkSheet.Cells[rowCount, 1].Value = GetTitle(groupNode);
                    AddPropertyCells(wkSheet, ref rowCount, 2, groupNode);

                    //  wkSheet.Cells[rowCount, 2].Value = GetPropertyText((Dictionary<string, string>)groupNode.Tag);

                    int subCount = rowStart - 1;
                    int groupNodeCount = 1;
                    foreach (TreeNode subAreaNode in groupNode.Nodes)
                    {
                        int groupStart = subCount;
                        if (subAreaNode.Text == "Titles")
                        {
                            continue;
                        }

                        subCount++;
                        wkSheet.Cells[subCount, 3].Value = GetTitle(subAreaNode);
                        AddPropertyCells(wkSheet, ref subCount, 4, subAreaNode);
                        //wkSheet.Cells[rowCount, 4].Value = GetPropertyText((Dictionary<string, string>)subAreaNode.Tag);
                        //wkSheet.Cells[rowCount, 4].Style.WrapText
                        wkSheet.Cells[groupStart + 1, 3, subCount, 3].Merge = true;
                        wkSheet.Cells[groupStart + 1, 3].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        wkSheet.Cells[groupStart + 1, 3].Style.Fill.BackgroundColor.SetColor(groupNodeCount % 2 == 0 ? Color.LightGray : Color.PeachPuff);
                        wkSheet.Cells[groupStart + 1, 3].Style.VerticalAlignment = ExcelVerticalAlignment.Top;

                        wkSheet.Cells[groupStart + 1, 3, subCount, 4].Style.Border.BorderAround(ExcelBorderStyle.Medium, groupNodeCount % 2 == 0 ? Color.DarkGray : Color.DarkOrange);
                        groupNodeCount++;
                    }
                    rowCount = rowCount > subCount ? rowCount : subCount;
                    wkSheet.Cells[rowStart, 1, rowCount, 1].Merge = true;
                    wkSheet.Cells[rowStart, 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    wkSheet.Cells[rowStart, 1].Style.Fill.BackgroundColor.SetColor(treeNodeCount % 2 == 0 ? Color.LightGray : Color.PeachPuff);
                    wkSheet.Cells[rowStart, 1].Style.VerticalAlignment = ExcelVerticalAlignment.Top;
                    wkSheet.Cells[rowStart, 1, rowCount, 4].Style.Border.BorderAround(ExcelBorderStyle.Medium, treeNodeCount % 2 == 0 ? Color.DarkGray : Color.DarkOrange);

                    rowCount++;
                    groupNodeCount++;

                    treeNodeCount++;
                }
                wkSheet.Cells[wkSheet.Dimension.Address].AutoFitColumns();
            }

            package.SaveAs(new FileInfo(fileName));

            if (MessageBox.Show(parentControl, $@"File saved to {fileName}:

Would you like to open it now? (Requires Excel)", @"Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start("Excel.exe", $"\"{fileName}\"");
            }
        }

        private static void AddPropertyCells(ExcelWorksheet wkSheet, ref int rowCount, int colCount, TreeNode node)
        {
            Dictionary<string, string> tag = (Dictionary<string, string>)node.Tag;
            foreach (var kvp in tag)
            {
                wkSheet.Cells[rowCount, colCount].Value = kvp.Key + " : " + kvp.Value;
                wkSheet.Cells[rowCount, colCount].Style.Fill.PatternType = ExcelFillStyle.Solid;
                wkSheet.Cells[rowCount, colCount].Style.Fill.BackgroundColor.SetColor(rowCount % 2 == 0 ? Color.LightGray : Color.PeachPuff);

                rowCount++;
            }

            foreach (TreeNode privNode in node.Nodes)
            {
                if (privNode.Text == "Privilege")
                {
                    Dictionary<string, string> privTag = (Dictionary<string, string>)privNode.Tag;
                    string priv = "Privilege: ";
                    if (privTag.ContainsKey("Entity"))
                    {
                        priv += privTag["Entity"] + " : ";
                    }

                    foreach (var priKVP in privTag)
                    {
                        if (priKVP.Key != "Entity")
                        {
                            priv += priKVP.Value + ", ";
                        }
                    }

                    if (priv.Substring(priv.Length - 2, 2) == ", ")
                    {
                        priv = priv.Substring(0, priv.Length - 2);
                    }
                    wkSheet.Cells[rowCount, colCount].Value = priv;
                    wkSheet.Cells[rowCount, colCount].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    wkSheet.Cells[rowCount, colCount].Style.Fill.BackgroundColor.SetColor(rowCount % 2 == 0 ? Color.LightGray : Color.PeachPuff);
                    rowCount++;
                }
            }
            rowCount--;
        }

        private static string GetTitle(TreeNode node)
        {
            if (node.Nodes.ContainsKey("Titles"))
            {
                if (node.Nodes["Titles"].Nodes.ContainsKey(Locale))
                {
                    return ((Dictionary<string, string>)node.Nodes["Titles"].Nodes[Locale].Tag)["Title"];
                    // return node.Nodes["Titles"].Nodes[Locale].Text;
                }
                else if (node.Nodes["Titles"].Nodes.ContainsKey("Title(1033)"))
                {
                    return ((Dictionary<string, string>)node.Nodes["Titles"].Nodes["Title(1033)"].Tag)["Title"];
                }
            }
            return ((Dictionary<string, string>)node.Tag)["Id"];
        }
    }
}