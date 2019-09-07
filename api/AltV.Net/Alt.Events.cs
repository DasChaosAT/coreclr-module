using AltV.Net.Events;

namespace AltV.Net
{
    public static partial class Alt
    {
        /// <summary>
        /// Triggered when a Checkpoint is triggered.
        /// </summary>
        public static event CheckpointDelegate OnCheckpoint
        {
            add => Module.CheckpointEventHandler.Add(value);
            remove => Module.CheckpointEventHandler.Remove(value);
        }

        /// <summary>
        /// Triggered when a player is joining the server.
        /// </summary>
        public static event PlayerConnectDelegate OnPlayerConnect
        {
            add => Module.PlayerConnectEventHandler.Add(value);
            remove => Module.PlayerConnectEventHandler.Remove(value);
        }

        /// <summary>
        /// Triggered when a player is damaged.
        /// </summary>
        public static event PlayerDamageDelegate OnPlayerDamage
        {
            add => Module.PlayerDamageEventHandler.Add(value);
            remove => Module.PlayerDamageEventHandler.Remove(value);
        }

        /// <summary>
        /// Triggered when a player dies.
        /// </summary>
        public static event PlayerDeadDelegate OnPlayerDead
        {
            add => Module.PlayerDeadEventHandler.Add(value);
            remove => Module.PlayerDeadEventHandler.Remove(value);
        }

        /// <summary>
        /// Triggered when a player left the server.
        /// </summary>
        public static event PlayerDisconnectDelegate OnPlayerDisconnect
        {
            add => Module.PlayerDisconnectEventHandler.Add(value);
            remove => Module.PlayerDisconnectEventHandler.Remove(value);
        }

        /// <summary>
        /// Triggered when a player is deleted.
        /// </summary>
        public static event PlayerRemoveDelegate OnPlayerRemove
        {
            add => Module.PlayerRemoveEventHandler.Add(value);
            remove => Module.PlayerRemoveEventHandler.Remove(value);
        }

        /// <summary>
        /// Triggered when a vehicle is deleted.
        /// </summary>
        public static event VehicleRemoveDelegate OnVehicleRemove
        {
            add => Module.VehicleRemoveEventHandler.Add(value);
            remove => Module.VehicleRemoveEventHandler.Remove(value);
        }

        /// <summary>
        /// Triggered when a player changes the vehicle seat.
        /// </summary>
        public static event PlayerChangeVehicleSeatDelegate OnPlayerChangeVehicleSeat
        {
            add => Module.PlayerChangeVehicleSeatEventHandler.Add(value);
            remove => Module.PlayerChangeVehicleSeatEventHandler.Remove(value);
        }

        /// <summary>
        /// Triggered when a player enters a vehicle.
        /// </summary>
        public static event PlayerEnterVehicleDelegate OnPlayerEnterVehicle
        {
            add => Module.PlayerEnterVehicleEventHandler.Add(value);
            remove => Module.PlayerEnterVehicleEventHandler.Remove(value);
        }

        /// <summary>
        /// Triggered when a player lefts a vehicle.
        /// </summary>
        public static event PlayerLeaveVehicleDelegate OnPlayerLeaveVehicle
        {
            add => Module.PlayerLeaveVehicleEventHandler.Add(value);
            remove => Module.PlayerLeaveVehicleEventHandler.Remove(value);
        }

        /// <summary>
        /// Triggered when a clientside event is triggered from a player.
        /// </summary>
        public static event PlayerClientEventDelegate OnPlayerEvent
        {
            add => Module.PlayerClientEventEventHandler.Add(value);
            remove => Module.PlayerClientEventEventHandler.Remove(value);
        }

        /// <summary>
        /// Triggered when a clientside custom event is triggered from a player.
        /// </summary>
        public static event PlayerClientCustomEventDelegate OnPlayerCustomEvent
        {
            add => Module.PlayerClientCustomEventEventHandler.Add(value);
            remove => Module.PlayerClientCustomEventEventHandler.Remove(value);
        }

        /// <summary>
        /// Triggered when a serverside event ist triggered.
        /// </summary>
        public static event ServerEventEventDelegate OnServerEvent
        {
            add => Module.ServerEventEventHandler.Add(value);
            remove => Module.ServerEventEventHandler.Remove(value);
        }

        /// <summary>
        /// Triggered when a serverside custom event is triggered.
        /// </summary>
        public static event ServerCustomEventEventDelegate OnServerCustomEvent
        {
            add => Module.ServerCustomEventEventHandler.Add(value);
            remove => Module.ServerCustomEventEventHandler.Remove(value);
        }

        /// <summary>
        /// Triggered when a server console command is entered.
        /// </summary>
        public static event ConsoleCommandDelegate OnConsoleCommand
        {
            add => Module.ConsoleCommandEventHandler.Add(value);
            remove => Module.ConsoleCommandEventHandler.Remove(value);
        }

        /// <summary>
        /// Triggered when a serverside MetaData is changed.
        /// </summary>
        public static event MetaDataChangeDelegate OnMetaDataChange
        {
            add => Module.MetaDataChangeEventHandler.Add(value);
            remove => Module.MetaDataChangeEventHandler.Remove(value);
        }

        /// <summary>
        /// Triggered when a serverside SyncedMetaData is changed.
        /// </summary>
        public static event MetaDataChangeDelegate OnSyncedMetaDataChange
        {
            add => Module.SyncedMetaDataChangeEventHandler.Add(value);
            remove => Module.SyncedMetaDataChangeEventHandler.Remove(value);
        }

        /// <summary>
        /// Triggered when a alt:V ColShape is triggered.
        /// </summary>
        public static event ColShapeDelegate OnColShape
        {
            add => Module.ColShapeEventHandler.Add(value);
            remove => Module.ColShapeEventHandler.Remove(value);
        }
    }
}