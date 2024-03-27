using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AnnounceStatus                           0001866F7410 ModelClassType IAnnounceStatus IAnnounceStatus IAnnounceStatus Pointer
    // 018 IsNormalCell                             0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 01C Category                                 0001865EA870 ModelEnumType AnnounceCategory AnnounceCategory AnnounceCategory Int32
    public partial class AnnounceListItemViewModel
    {
        public IAnnounceStatus?                         AnnounceStatus                          { get; set; }
        public bool                                     IsNormalCell                            { get; set; }
        public AnnounceCategory                         Category                                { get; set; }

        public static AnnounceListItemViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceListItemViewModel();

            value.AnnounceStatus                            = GetObject<IAnnounceStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAnnounceStatus.FromPointer); // 0270D5E590C0 0x10 AnnounceStatus              ( 0001866F7410 ModelClassType IAnnounceStatus IAnnounceStatus IAnnounceStatus Pointer )
            value.IsNormalCell                              = GetBool(new IntPtr(p + 0x018)); // 0270D5E590E0 0x18 IsNormalCell                ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.Category                                  = (AnnounceCategory)GetInt32(new IntPtr(p + 0x01C)); // 0270D5E59100 0x1C Category                    ( 0001865EA870 ModelEnumType AnnounceCategory AnnounceCategory AnnounceCategory Int32 )

            return value;
        }
    }
}
