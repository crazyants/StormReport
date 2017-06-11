﻿using System;
using System.Text;

namespace StormReport.BuildTable
{
    public class HtmlTable
    {
        private StringBuilder table;

        public HtmlTable()
        {
            table = new StringBuilder();
        }

        public void InitTable()
        {
            table.Append("<table cellspacing='0' rules='all' border='1'>\n");
        }

        public void EndTable()
        {
            table.Append("</table>\n");
        }

        public void AddRow()
        {
            table.Append("<tr>\n");
        }

        public void EndRow()
        {
            table.Append("</tr>\n");
        }

        public void AddColumnTextHeader(object text, string[] style)
        {
            StringBuilder styles = new StringBuilder();
            Array.ForEach(style, s =>
            {
                styles.Append(s.Contains(";") ? s : s + ";");
            });

            table.Append(string.Format("<th scope='col' style='{0}'>\n", styles));
            table.Append(text);
            table.Append("</th>\n");
        }

        public void AddColumnText(object text, string[] style)
        {
            StringBuilder styles = new StringBuilder();
            Array.ForEach(style, s =>
            {
                styles.Append(s.Contains(";") ? s : s + ";");
            });
            table.Append(string.Format("<td scope='row' style='{0}'>\n", styles));
            table.Append(text);
            table.Append("</td>\n");
        }

        public string ToHtml()
        {
            return table.ToString();
        }
    }
}
