using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CommentHandling                          ModelEnumType CommentHandling CommentHandling CommentHandling Int32
    // 014 LineInfoHandling                         ModelEnumType LineInfoHandling LineInfoHandling LineInfoHandling Int32
    // 018 DuplicatePropertyNameHandling            ModelEnumType DuplicatePropertyNameHandling DuplicatePropertyNameHandling DuplicatePropertyNameHandling Int32
    public partial class JsonLoadSettings : DataModel
    {
        public CommentHandling                          CommentHandling                         { get; set; }
        public LineInfoHandling                         LineInfoHandling                        { get; set; }
        public DuplicatePropertyNameHandling            DuplicatePropertyNameHandling           { get; set; }

        public static JsonLoadSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonLoadSettings() { Pointer= p0 };

            value.CommentHandling                           = (CommentHandling)GetInt32(new IntPtr(p + 0x010)); // 0x10 CommentHandling             ( ModelEnumType CommentHandling CommentHandling CommentHandling Int32 )
            value.LineInfoHandling                          = (LineInfoHandling)GetInt32(new IntPtr(p + 0x014)); // 0x14 LineInfoHandling            ( ModelEnumType LineInfoHandling LineInfoHandling LineInfoHandling Int32 )
            value.DuplicatePropertyNameHandling             = (DuplicatePropertyNameHandling)GetInt32(new IntPtr(p + 0x018)); // 0x18 DuplicatePropertyNameHandling ( ModelEnumType DuplicatePropertyNameHandling DuplicatePropertyNameHandling DuplicatePropertyNameHandling Int32 )

            return value;
        }
    }
}
