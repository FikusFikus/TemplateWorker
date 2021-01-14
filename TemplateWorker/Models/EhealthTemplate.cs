using System;
using System.Collections.Generic;

#nullable disable

namespace TemplateWorker.Models
{
    public partial class EhealthTemplate
    {
        public int IdTemplate { get; set; }
        public Guid GuidTemplate { get; set; }
        public int IdTemplateFolder { get; set; }
        public string LabelTemplate { get; set; }
        public string Comment { get; set; }
        public Guid GuidRecordType { get; set; }
        public int IdDocumentType { get; set; }
        public string TextData { get; set; }
        public string Properties { get; set; }
        public int? IdTrigger { get; set; }
        public string EditTextData { get; set; }
        public DateTime? EditBegin { get; set; }
        public DateTime? EditLastSave { get; set; }
        public string EditClientId { get; set; }
        public int? EditIdUser { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
