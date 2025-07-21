using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Path                                   ModelClassType CinemachinePathBase CinemachinePathBase CinemachinePathBase Pointer
    // 028 M_UpdateMethod                           ModelEnumType UpdateMethod UpdateMethod UpdateMethod Int32
    // 02C M_PositionUnits                          ModelEnumType PositionUnits PositionUnits PositionUnits Int32
    // 030 M_Speed                                  ModelPrimitiveType float float float Single
    // 034 M_Position                               ModelPrimitiveType float float float Single
    public partial class CinemachineDollyCart : DataModel
    {
        public CinemachinePathBase?                     M_Path                                  { get; set; }
        public UpdateMethod                             M_UpdateMethod                          { get; set; }
        public PositionUnits                            M_PositionUnits                         { get; set; }
        public float                                    M_Speed                                 { get; set; }
        public float                                    M_Position                              { get; set; }

        public static CinemachineDollyCart? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineDollyCart() { Pointer= p0 };

            value.M_Path                                    = GetObject<CinemachinePathBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.CinemachinePathBase.FromPointer); // 0x20 M_Path                      ( ModelClassType CinemachinePathBase CinemachinePathBase CinemachinePathBase Pointer )
            value.M_UpdateMethod                            = (UpdateMethod)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_UpdateMethod              ( ModelEnumType UpdateMethod UpdateMethod UpdateMethod Int32 )
            value.M_PositionUnits                           = (PositionUnits)GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_PositionUnits             ( ModelEnumType PositionUnits PositionUnits PositionUnits Int32 )
            value.M_Speed                                   = GetSingle(new IntPtr(p + 0x030)); // 0x30 M_Speed                     ( ModelPrimitiveType float float float Single )
            value.M_Position                                = GetSingle(new IntPtr(p + 0x034)); // 0x34 M_Position                  ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
