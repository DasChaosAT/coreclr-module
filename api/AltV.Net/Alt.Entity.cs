using AltV.Net.Elements.Entities;

namespace AltV.Net
{
    public static partial class Alt
    {
        /// <summary>
        /// Deletes a Vehicle.
        /// </summary>
        /// <param name="vehicle">The Veicle to delete.</param>
        public static void RemoveVehicle(IVehicle vehicle) =>
            Module.Server.RemoveVehicle(vehicle);

        /// <summary>
        /// Deletes a serverside Blip.
        /// </summary>
        /// <param name="blip">The serverside Blip to delete.</param>
        public static void RemoveBlip(IBlip blip) =>
            Module.Server.RemoveBlip(blip);

        /// <summary>
        /// Deletes a serverside Checkpoint.
        /// </summary>
        /// <param name="checkpoint">The serverside Checkpoint to delete.</param>
        public static void RemoveCheckpoint(ICheckpoint checkpoint) =>
            Module.Server.RemoveCheckpoint(checkpoint);
        
        /// <summary>
        /// Deletes a ColShape.
        /// </summary>
        /// <param name="colShape">The Colshape to delete.</param>
        public static void RemoveColShape(IColShape colShape) =>
            Module.Server.RemoveColShape(colShape);
    }
}