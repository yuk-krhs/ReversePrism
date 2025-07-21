using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Material                                 ModelClassType Material Material Material Pointer
    // 030 decalEntities                            NativeArray`1<DecalEntity> IL2CPP_TYPE_GENERICINST
    // 040 DecalProjectors                          ModelClassListType DecalProjector[] DecalProjector[] List<DecalProjector> Pointer
    // 048 TransformAccessArray                     ModelEnumType TransformAccessArray TransformAccessArray TransformAccessArray Int32
    public partial class DecalEntityChunk : DataModel
    {
        public Material?                                Material                                { get; set; }
        public List<DecalProjector>?                    DecalProjectors                         { get; set; }
        public TransformAccessArray                     TransformAccessArray                    { get; set; }

        public static DecalEntityChunk? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecalEntityChunk() { Pointer= p0 };

            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x028), ReversePrism.DataModels.Material.FromPointer); // 0x28 Material                    ( ModelClassType Material Material Material Pointer )
            value.DecalProjectors                           = GetObjectList<DecalProjector>(new IntPtr(p + 0x040), ReversePrism.DataModels.DecalProjector.FromPointer); // 0x40 DecalProjectors             ( ModelClassListType DecalProjector[] DecalProjector[] List<DecalProjector> Pointer )
            value.TransformAccessArray                      = (TransformAccessArray)GetInt32(new IntPtr(p + 0x048)); // 0x48 TransformAccessArray        ( ModelEnumType TransformAccessArray TransformAccessArray TransformAccessArray Int32 )

            return value;
        }
    }
}
