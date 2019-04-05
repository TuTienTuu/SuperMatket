﻿namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sieuthin.Brand")]
    public partial class Brand
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [DisplayName("Tên hiển thị")]
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }

        [DisplayName("Menu cha")]
        public long? ParentID { get; set; }

        [DisplayName("Thứ tự hiển thị")]
        public int? DisplayOrder { get; set; }

        [StringLength(250)]
        public string SeoTitle { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(250)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(250)]
        public string ModifiedBy { get; set; }

        [StringLength(250)]
        public string MetaKeywords { get; set; }

        [StringLength(250)]
        public string MetaDescriptions { get; set; }

        [DisplayName("Trạng thái")]
        public bool? Status { get; set; }

        [DisplayName("Hiển thị ở trang chủ")]
        public bool? ShowOnhome { get; set; }

        [StringLength(250)]
        [DisplayName("Hình ảnh")]
        public string Image { get; set; }
    }
}
