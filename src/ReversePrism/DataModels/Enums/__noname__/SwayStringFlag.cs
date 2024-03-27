using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum SwayStringFlag
    {
        None,
        headZCollide,
        headXCollide,
        skirtCollide,
        planeCollide,
        sleeveCollide,
        chestMoveCollide,
        xzPlaneCollide,
        stopFlag,
        notUpdate,
        skipFrame,
    }
}
