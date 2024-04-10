using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MissionCompletedStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MissionTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 018 MissionType                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MissionCategoryMstIdFieldNumber          int IL2CPP_TYPE_I4
    // 01C MissionCategoryMstId                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MissionMstIdFieldNumber                  int IL2CPP_TYPE_I4
    // 020 MissionMstId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class MissionCompletedStatus : DataModel
    {
        public int                                      MissionType                             { get; set; }
        public int                                      MissionCategoryMstId                    { get; set; }
        public int                                      MissionMstId                            { get; set; }

        public static MissionCompletedStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionCompletedStatus() { Pointer= p0 };

            value.MissionType                               = GetInt32(new IntPtr(p + 0x018)); // 02466225D3D0 0x18 MissionType                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MissionCategoryMstId                      = GetInt32(new IntPtr(p + 0x01C)); // 02466225D410 0x1C MissionCategoryMstId        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MissionMstId                              = GetInt32(new IntPtr(p + 0x020)); // 02466225D450 0x20 MissionMstId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
