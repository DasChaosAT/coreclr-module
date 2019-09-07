using System.Collections.Generic;
using AltV.Net.Elements.Entities;
using AltV.Net.Events;

namespace AltV.Net
{
    public static partial class Alt
    {
        internal static Module Module;

        public static IServer Server => Module.Server;

        /// <summary>
        /// Triggers an server event.
        /// </summary>
        /// <param name="eventName">The name of the event which is triggered.</param>
        /// <param name="args">The arguments for the event.</param>
        public static void Emit(string eventName, params object[] args) => Server.TriggerServerEvent(eventName, args);

        /// <summary>
        /// Triggers an client event to all players.
        /// </summary>
        /// <param name="eventName">The name of the event which is triggered.</param>
        /// <param name="args">The arguments for the event.</param>
        public static void EmitAllClients(string eventName, params object[] args) =>
            Server.TriggerClientEvent(null, eventName, args);

        /// <summary>
        /// Add a log entry with trace level INFO.
        /// </summary>
        /// <param name="message">The message for the log entry.</param>
        public static void Log(string message) => Server.LogInfo(message);

        /// <summary>
        /// Gets all players from the module pool.
        /// </summary>
        /// <returns>All players as collection.</returns>
        public static ICollection<IPlayer> GetAllPlayers() => Module.PlayerPool.GetAllEntities();

        /// <summary>
        /// Gets all vehicles from the module pool.
        /// </summary>
        /// <returns>All vehicles as collection.</returns>
        public static ICollection<IVehicle> GetAllVehicles() =>
            Module.VehiclePool.GetAllEntities();

        /// <summary>
        /// Gets all serverside Blips from the module pool.
        /// </summary>
        /// <returns>All serverside Blips as collection.</returns>
        public static ICollection<IBlip> GetAllBlips() => Module.BlipPool.GetAllObjects();

        /// <summary>
        /// Gets all serverside Checkpoints from the module pool.
        /// </summary>
        /// <returns>All serverside Checkpoints as collection.</returns>
        public static ICollection<ICheckpoint> GetAllCheckpoints() =>
            Module.CheckpointPool.GetAllObjects();

        /// <summary>
        /// Gets all VoiceChannels form the module pool.
        /// </summary>
        /// <returns>All VoiceChannels as collection.</returns>
        public static ICollection<IVoiceChannel> GetAllVoiceChannels() =>
            Module.VoiceChannelPool.GetAllObjects();

        /// <summary>
        /// Gets all alt:V ColShapes from the module pool.
        /// </summary>
        /// <returns>All alt:V ColShapes as collection.</returns>
        public static ICollection<IColShape> GetAllColShapes() =>
            Module.ColShapePool.GetAllObjects();

        /// <summary>
        /// Genereates the JHash for GTA-Models.
        /// </summary>
        /// <param name="stringToHash">The Modelname of the GTA-Model.</param>
        /// <returns>The generated JHash.</returns>
        public static uint Hash(string stringToHash) => Server.Hash(stringToHash);

        internal static void Init(Module module)
        {
            Module = module;
        }
    }
}