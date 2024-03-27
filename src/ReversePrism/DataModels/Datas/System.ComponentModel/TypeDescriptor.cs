using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _providerTable                           WeakHashtable IL2CPP_TYPE_CLASS
    // 008 _providerTypeTable                       Hashtable IL2CPP_TYPE_CLASS
    // 010 DefaultProviders                         0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 AssociationTable                         0001865464F0 ModelClassType WeakHashtable WeakHashtable WeakHashtable Pointer
    // 020 MetadataVersion                          0001865F38E0 ModelPrimitiveType int int int Int32
    // 024 CollisionIndex                           0001865F38E0 ModelPrimitiveType int int int Int32
    // 028 TraceDescriptor                          00018676C3D0 ModelClassType BooleanSwitch BooleanSwitch BooleanSwitch Pointer
    // 030 PipelineInitializeKeys                   000185B83BB0 ModelEnumListType Guid[] Guid[] List<Guid> Pointer
    // 038 PipelineMergeKeys                        000185B83BB0 ModelEnumListType Guid[] Guid[] List<Guid> Pointer
    // 040 PipelineFilterKeys                       000185B83BB0 ModelEnumListType Guid[] Guid[] List<Guid> Pointer
    // 048 PipelineAttributeFilterKeys              000185B83BB0 ModelEnumListType Guid[] Guid[] List<Guid> Pointer
    // 050 _internalSyncObject                      <object> IL2CPP_TYPE_OBJECT
    // 058 Refreshed                                000186639F00 ModelClassType RefreshEventHandler RefreshEventHandler RefreshEventHandler Pointer
    public partial class TypeDescriptor
    {
        public Hashtable?                               DefaultProviders                        { get; set; }
        public WeakHashtable?                           AssociationTable                        { get; set; }
        public int                                      MetadataVersion                         { get; set; }
        public int                                      CollisionIndex                          { get; set; }
        public BooleanSwitch?                           TraceDescriptor                         { get; set; }
        public List<Guid>?                              PipelineInitializeKeys                  { get; set; }
        public List<Guid>?                              PipelineMergeKeys                       { get; set; }
        public List<Guid>?                              PipelineFilterKeys                      { get; set; }
        public List<Guid>?                              PipelineAttributeFilterKeys             { get; set; }
        public RefreshEventHandler?                     Refreshed                               { get; set; }

        public static TypeDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeDescriptor();

            value.DefaultProviders                          = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 027006024518 0x10 DefaultProviders            ( 0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.AssociationTable                          = GetObject<WeakHashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.WeakHashtable.FromPointer); // 027006024538 0x18 AssociationTable            ( 0001865464F0 ModelClassType WeakHashtable WeakHashtable WeakHashtable Pointer )
            value.MetadataVersion                           = GetInt32(new IntPtr(p + 0x020)); // 027006024558 0x20 MetadataVersion             ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.CollisionIndex                            = GetInt32(new IntPtr(p + 0x024)); // 027006024578 0x24 CollisionIndex              ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.TraceDescriptor                           = GetObject<BooleanSwitch>(new IntPtr(p + 0x028), ReversePrism.DataModels.BooleanSwitch.FromPointer); // 027006024598 0x28 TraceDescriptor             ( 00018676C3D0 ModelClassType BooleanSwitch BooleanSwitch BooleanSwitch Pointer )
            value.PipelineInitializeKeys                    = GetEnumList<Guid>(new IntPtr(p + 0x030)); // 0270060245B8 0x30 PipelineInitializeKeys      ( 000185B83BB0 ModelEnumListType Guid[] Guid[] List<Guid> Pointer )
            value.PipelineMergeKeys                         = GetEnumList<Guid>(new IntPtr(p + 0x038)); // 0270060245D8 0x38 PipelineMergeKeys           ( 000185B83BB0 ModelEnumListType Guid[] Guid[] List<Guid> Pointer )
            value.PipelineFilterKeys                        = GetEnumList<Guid>(new IntPtr(p + 0x040)); // 0270060245F8 0x40 PipelineFilterKeys          ( 000185B83BB0 ModelEnumListType Guid[] Guid[] List<Guid> Pointer )
            value.PipelineAttributeFilterKeys               = GetEnumList<Guid>(new IntPtr(p + 0x048)); // 027006024618 0x48 PipelineAttributeFilterKeys ( 000185B83BB0 ModelEnumListType Guid[] Guid[] List<Guid> Pointer )
            value.Refreshed                                 = GetObject<RefreshEventHandler>(new IntPtr(p + 0x058), ReversePrism.DataModels.RefreshEventHandler.FromPointer); // 027006024658 0x58 Refreshed                   ( 000186639F00 ModelClassType RefreshEventHandler RefreshEventHandler RefreshEventHandler Pointer )

            return value;
        }
    }
}
