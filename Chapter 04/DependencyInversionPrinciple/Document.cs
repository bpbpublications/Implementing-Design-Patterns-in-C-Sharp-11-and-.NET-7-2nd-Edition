using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_04.DependencyInversionPrinciple
{
    class Document
    {
        private IDocumentConversion pdfConverter;
        private IDocumentConversion excelConveter;

        public Document(IDocumentConversion pdfConverter, IDocumentConversion excelConverter)
        {
            this.pdfConverter = pdfConverter;
            this.excelConveter = excelConveter;
        }

        public void GetPdfFormat()
        {
            var pdf = this.pdfConverter.Convert(this);
        }

        public void GetExcelFormat()
        {
            var excel = this.excelConveter.Convert(this);
        }
    }
}
