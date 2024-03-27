using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 prepareSema                              SemaphoreSlim IL2CPP_TYPE_CLASS
    // 020 UsmMoviePath                             000186671910 ModelPrimitiveType string string string String
    // 028 StartFrame                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 Controller                               00018665A510 ModelClassType CriManaMovieControllerForUI CriManaMovieControllerForUI CriManaMovieControllerForUI Pointer
    // 038 AspectRatioFitter                        0001866DD380 ModelClassType AspectRatioFitter AspectRatioFitter AspectRatioFitter Pointer
    // 040 onCueEventSubject                        Subject`1<CueEventMessage> IL2CPP_TYPE_GENERICINST
    // 048 Canceller                                0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class MoviePlayer
    {
        public string                                   UsmMoviePath                            { get; set; }
        public int                                      StartFrame                              { get; set; }
        public CriManaMovieControllerForUI?             Controller                              { get; set; }
        public AspectRatioFitter?                       AspectRatioFitter                       { get; set; }
        public CancellationTokenSource?                 Canceller                               { get; set; }

        public static MoviePlayer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MoviePlayer();

            value.UsmMoviePath                              = GetString(new IntPtr(p + 0x020)); // 027004375C78 0x20 UsmMoviePath                ( 000186671910 ModelPrimitiveType string string string String )
            value.StartFrame                                = GetInt32(new IntPtr(p + 0x028)); // 027004375C98 0x28 StartFrame                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Controller                                = GetObject<CriManaMovieControllerForUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.CriManaMovieControllerForUI.FromPointer); // 027004375CB8 0x30 Controller                  ( 00018665A510 ModelClassType CriManaMovieControllerForUI CriManaMovieControllerForUI CriManaMovieControllerForUI Pointer )
            value.AspectRatioFitter                         = GetObject<AspectRatioFitter>(new IntPtr(p + 0x038), ReversePrism.DataModels.AspectRatioFitter.FromPointer); // 027004375CD8 0x38 AspectRatioFitter           ( 0001866DD380 ModelClassType AspectRatioFitter AspectRatioFitter AspectRatioFitter Pointer )
            value.Canceller                                 = GetObject<CancellationTokenSource>(new IntPtr(p + 0x048), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 027004375D18 0x48 Canceller                   ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
