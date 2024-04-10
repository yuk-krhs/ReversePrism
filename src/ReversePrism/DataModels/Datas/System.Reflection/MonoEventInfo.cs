using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Declaring_type                           000186692F60 ModelClassType Type Type Type Pointer
    // 018 Reflected_type                           000186692F60 ModelClassType Type Type Type Pointer
    // 020 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 028 Add_method                               0001866138F0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 030 Remove_method                            0001866138F0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 038 Raise_method                             0001866138F0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 040 Attrs                                    00018674DF20 ModelEnumType EventAttributes EventAttributes EventAttributes Int32
    // 048 Other_methods                            000185B7F1F0 ModelClassListType MethodInfo[] MethodInfo[] List<MethodInfo> Pointer
    public partial class MonoEventInfo : DataModel
    {
        public Type?                                    Declaring_type                          { get; set; }
        public Type?                                    Reflected_type                          { get; set; }
        public string                                   Name                                    { get; set; }
        public MethodInfo?                              Add_method                              { get; set; }
        public MethodInfo?                              Remove_method                           { get; set; }
        public MethodInfo?                              Raise_method                            { get; set; }
        public EventAttributes                          Attrs                                   { get; set; }
        public List<MethodInfo>?                        Other_methods                           { get; set; }

        public static MonoEventInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoEventInfo() { Pointer= p0 };

            value.Declaring_type                            = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 024666D3E398 0x10 Declaring_type              ( 000186692F60 ModelClassType Type Type Type Pointer )
            value.Reflected_type                            = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 024666D3E3B8 0x18 Reflected_type              ( 000186692F60 ModelClassType Type Type Type Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 024666D3E3D8 0x20 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Add_method                                = GetObject<MethodInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MethodInfo.FromPointer); // 024666D3E3F8 0x28 Add_method                  ( 0001866138F0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Remove_method                             = GetObject<MethodInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.MethodInfo.FromPointer); // 024666D3E418 0x30 Remove_method               ( 0001866138F0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Raise_method                              = GetObject<MethodInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.MethodInfo.FromPointer); // 024666D3E438 0x38 Raise_method                ( 0001866138F0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Attrs                                     = (EventAttributes)GetInt32(new IntPtr(p + 0x040)); // 024666D3E458 0x40 Attrs                       ( 00018674DF20 ModelEnumType EventAttributes EventAttributes EventAttributes Int32 )
            value.Other_methods                             = GetObjectList<MethodInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.MethodInfo.FromPointer); // 024666D3E478 0x48 Other_methods               ( 000185B7F1F0 ModelClassListType MethodInfo[] MethodInfo[] List<MethodInfo> Pointer )

            return value;
        }
    }
}
