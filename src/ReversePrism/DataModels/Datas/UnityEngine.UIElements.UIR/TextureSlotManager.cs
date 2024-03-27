using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_SlotCount                              int IL2CPP_TYPE_I4
    // 004 k_SlotSize                               int IL2CPP_TYPE_I4
    // 008 slotIds                                  int[] IL2CPP_TYPE_SZARRAY
    // 010 TextureTableId                           0001865F4E00 ModelPrimitiveType int int int Int32
    // 010 M_Textures                               000185CAB6B8 ModelEnumListType TextureId[] TextureId[] List<TextureId> Pointer
    // 018 M_Tickets                                000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 M_CurrentTicket                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 M_FirstUsedTicket                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 M_GpuTextures                            000185CB1478 ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 030 FreeSlots                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 TextureRegistry                          000186656990 ModelClassType TextureRegistry TextureRegistry TextureRegistry Pointer
    public partial class TextureSlotManager
    {
        public int                                      TextureTableId                          { get; set; }
        public List<TextureId>?                         M_Textures                              { get; set; }
        public List<int>?                               M_Tickets                               { get; set; }
        public int                                      M_CurrentTicket                         { get; set; }
        public int                                      M_FirstUsedTicket                       { get; set; }
        public List<Vector4>?                           M_GpuTextures                           { get; set; }
        public int                                      FreeSlots                               { get; set; }
        public TextureRegistry?                         TextureRegistry                         { get; set; }

        public static TextureSlotManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureSlotManager();

            value.TextureTableId                            = GetInt32(new IntPtr(p + 0x010)); // 027006879E90 0x10 TextureTableId              ( 0001865F4E00 ModelPrimitiveType int int int Int32 )
            value.M_Textures                                = GetEnumList<TextureId>(new IntPtr(p + 0x010)); // 027006879EB0 0x10 M_Textures                  ( 000185CAB6B8 ModelEnumListType TextureId[] TextureId[] List<TextureId> Pointer )
            value.M_Tickets                                 = GetInt32List(new IntPtr(p + 0x018)); // 027006879ED0 0x18 M_Tickets                   ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_CurrentTicket                           = GetInt32(new IntPtr(p + 0x020)); // 027006879EF0 0x20 M_CurrentTicket             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_FirstUsedTicket                         = GetInt32(new IntPtr(p + 0x024)); // 027006879F10 0x24 M_FirstUsedTicket           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_GpuTextures                             = GetEnumList<Vector4>(new IntPtr(p + 0x028)); // 027006879F30 0x28 M_GpuTextures               ( 000185CB1478 ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.FreeSlots                                 = GetInt32(new IntPtr(p + 0x030)); // 027006879F50 0x30 FreeSlots                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TextureRegistry                           = GetObject<TextureRegistry>(new IntPtr(p + 0x038), ReversePrism.DataModels.TextureRegistry.FromPointer); // 027006879F70 0x38 TextureRegistry             ( 000186656990 ModelClassType TextureRegistry TextureRegistry TextureRegistry Pointer )

            return value;
        }
    }
}
