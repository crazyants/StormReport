﻿using System.Collections.Generic;
using System.Drawing;
using System.Web.UI;

namespace StormReport.Test
{
    [ExcelFileName("ExcelReport", useDateTimeToAdditionalName: true)]
    public class ClassTest
    {
        private List<ClassTest> List { get; set; }

        public ClassTest()
        {
            List = new List<ClassTest>();
        }

        [ExportableColumnHeaderName("Nome do Cliente")]
        [ExportableColumnHeaderStyle("text-align: center;", "color: red;", "font-size: 17px;")]
        [ExportableColumnContentStyle("text-align: center;", "color: gray;", "font-size: 17px;")]
        public string Nome { get; set; }

        [ExportableColumnHeaderName("Idade do Cliente")]
        [ExportableColumnHeaderStyle("text-align: center;", "color: red;", "font-size: 17px;")]
        [ExportableColumnContentStyle("text-align: center;", "color: blue;", "font-size: 17px;")]
        public int Idade { get; set; }

        [ExportableColumnHeaderName("Cidade do Cliente")]
        [ExportableColumnHeaderStyle("text-align: center;", "color: red;", "font-size: 17px;")]
        [ExportableColumnContentStyle("text-align: center;", "color: gray;", "font-size: 17px;")]
        public string Cidade { get; set; }

        [ExportableColumnHeaderName("Estado do Cliente")]
        [ExportableColumnHeaderStyle("text-align: center;", "color: red;", "font-size: 17px;")]
        [ExportableColumnContentStyle("text-align: center;", "color: blue;", "font-size: 17px;")]
        public string Estado { get; set; }
        public void Add(ClassTest e)
        {
            List.Add(e);
        }

        public List<ClassTest> GetList()
        {
            return List;
        }
    }

    public class ClassTestWithoutName
    {
        private List<ClassTest> List { get; set; }

        public ClassTestWithoutName()
        {
            List = new List<ClassTest>();
        }

        [ExportableColumnHeaderName("Nome do Cliente")]
        public string Nome { get; set; }

        [ExportableColumnHeaderName("Idade do Cliente")]
        public int Idade { get; set; }

        [ExportableColumnHeaderName("Cidade do Cliente")]
        public string Cidade { get; set; }

        [ExportableColumnHeaderName("Estado do Cliente")]
        public string Estado { get; set; }

        public void Add(ClassTest e)
        {
            List.Add(e);
        }

        public List<ClassTest> GetList()
        {
            return List;
        }
    }
}
