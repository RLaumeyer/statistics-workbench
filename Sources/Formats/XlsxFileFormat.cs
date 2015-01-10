﻿// Statistics Workbench
// http://accord-framework.net
//
// The MIT License (MIT)
// Copyright © 2014-2015, César Souza
//

namespace Workbench.Formats
{
    using Accord.IO;
    using System;
    using System.Data;
    using System.IO;

    /// <summary>
    ///   File format for data tables stored as Excel 2007 (xlsx) files.
    /// </summary>
    /// 
    public class XlsxFileFormat : FileFormatBase, IFileFormat
    {

        public override string Extension { get { return "*.xlsx"; } }

        public override string Description { get { return "Excel worksheets"; } }

        public override bool CanRead { get { return true; } }

        public override bool CanWrite { get { return false; } }

        public override DataTable Read(Stream stream)
        {
            ExcelReader reader = new ExcelReader(stream, true, true);
            return reader.GetWorksheet(0);
        }

        public override void Write(DataTable table, Stream stream)
        {
            throw new NotSupportedException();
        }
    }

}
