using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum Simulation
    {
        Undefined,
        FlightSimulationDevice,
        AutomobileSimulationDevice,
        TankSimulationDevice,
        SpaceshipSimulationDevice,
        SubmarineSimulationDevice,
        SailingSimulationDevice,
        MotorcycleSimulationDevice,
        SportsSimulationDevice,
        AirplaneSimulationDevice,
        HelicopterSimulationDevice,
        MagicCarpetSimulationDevice,
        BicylcleSimulationDevice,
        FlightControlStick,
        FlightStick,
        CyclicControl,
        CyclicTrim,
        FlightYoke,
        TrackControl,
        Aileron,
        AileronTrim,
        AntiTorqueControl,
        AutopilotEnable,
        ChaffRelease,
        CollectiveControl,
        DiveBreak,
        ElectronicCountermeasures,
        Elevator,
        ElevatorTrim,
        Rudder,
        Throttle,
        FlightCommunications,
        FlareRelease,
        LandingGear,
        ToeBreak,
        Trigger,
        WeaponsArm,
        WeaponsSelect,
        WingFlaps,
        Accelerator,
        Brake,
        Clutch,
        Shifter,
        Steering,
        TurretDirection,
        BarrelElevation,
        DivePlane,
        Ballast,
        BicycleCrank,
        HandleBars,
        FrontBrake,
        RearBrake,
    }
}
