using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 CreateDate                               000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<PresentStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PresentIdFieldNumber                     int IL2CPP_TYPE_I4
    // 038 PresentId                                000186671910 ModelPrimitiveType string string string String
    // 000 CommentFieldNumber                       int IL2CPP_TYPE_I4
    // 040 Comment                                  000186671910 ModelPrimitiveType string string string String
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 048 _EndDate                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 CreateDateFieldNumber                    int IL2CPP_TYPE_I4
    // 050 _CreateDate                              000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 AmountFieldNumber                        int IL2CPP_TYPE_I4
    // 058 Amount                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PresentStateFieldNumber                  int IL2CPP_TYPE_I4
    // 05C PresentState                             00018650E000 ModelEnumType PresentState PresentState PresentState Int32
    // 000 ProductFieldNumber                       int IL2CPP_TYPE_I4
    // 060 Product                                  0001865A5470 ModelClassType ProductStatus ProductStatus ProductStatus Pointer
    public partial class PresentStatus : DataModel
    {
        public DateTime                                 EndDate                                 { get; set; }
        public DateTime                                 CreateDate                              { get; set; }
        public string                                   PresentId                               { get; set; }
        public string                                   Comment                                 { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public Timestamp?                               _CreateDate                             { get; set; }
        public int                                      Amount                                  { get; set; }
        public PresentState                             PresentState                            { get; set; }
        public ProductStatus?                           Product                                 { get; set; }

        public static PresentStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PresentStatus() { Pointer= p0 };

            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x010)); // 024662401938 0x10 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x020)); // 024662401958 0x20 CreateDate                  ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.PresentId                                 = GetString(new IntPtr(p + 0x038)); // 0246624019D8 0x38 PresentId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Comment                                   = GetString(new IntPtr(p + 0x040)); // 024662401A18 0x40 Comment                     ( 000186671910 ModelPrimitiveType string string string String )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x048), ReversePrism.DataModels.Timestamp.FromPointer); // 024662401A58 0x48 _EndDate                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._CreateDate                               = GetObject<Timestamp>(new IntPtr(p + 0x050), ReversePrism.DataModels.Timestamp.FromPointer); // 024662401A98 0x50 _CreateDate                 ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.Amount                                    = GetInt32(new IntPtr(p + 0x058)); // 024662401AD8 0x58 Amount                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PresentState                              = (PresentState)GetInt32(new IntPtr(p + 0x05C)); // 024662401B18 0x5C PresentState                ( 00018650E000 ModelEnumType PresentState PresentState PresentState Int32 )
            value.Product                                   = GetObject<ProductStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProductStatus.FromPointer); // 024662401B58 0x60 Product                     ( 0001865A5470 ModelClassType ProductStatus ProductStatus ProductStatus Pointer )
            value.EndDate                       = ToDateTime(value._EndDate);
            value.CreateDate                    = ToDateTime(value._CreateDate);

            return value;
        }
    }
}
