using System;
using System.Collections.Generic;
using NetDaemon.HassModel;
using NetDaemon.HassModel.Entities;
using System.Text.Json.Serialization;

namespace HomeAssistantGenerated
{
	public interface IEntities
	{
		AlarmControlPanelEntities AlarmControlPanel { get; }

		AlertEntities Alert { get; }

		AutomationEntities Automation { get; }

		BinarySensorEntities BinarySensor { get; }

		ButtonEntities Button { get; }

		CalendarEntities Calendar { get; }

		CameraEntities Camera { get; }

		ClimateEntities Climate { get; }

		CoverEntities Cover { get; }

		DeviceTrackerEntities DeviceTracker { get; }

		GroupEntities Group { get; }

		HumidifierEntities Humidifier { get; }

		InputBooleanEntities InputBoolean { get; }

		InputDatetimeEntities InputDatetime { get; }

		InputNumberEntities InputNumber { get; }

		InputSelectEntities InputSelect { get; }

		InputTextEntities InputText { get; }

		LightEntities Light { get; }

		MediaPlayerEntities MediaPlayer { get; }

		NumberEntities Number { get; }

		PersistentNotificationEntities PersistentNotification { get; }

		PersonEntities Person { get; }

		RemoteEntities Remote { get; }

		SceneEntities Scene { get; }

		ScriptEntities Script { get; }

		SelectEntities Select { get; }

		SensorEntities Sensor { get; }

		SunEntities Sun { get; }

		SwitchEntities Switch { get; }

		TimerEntities Timer { get; }

		VacuumEntities Vacuum { get; }

		VarEntities Var { get; }

		VariableEntities Variable { get; }

		WeatherEntities Weather { get; }

		ZoneEntities Zone { get; }
	}

	public class Entities : IEntities
	{
		private readonly IHaContext _haContext;
		public Entities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AlarmControlPanelEntities AlarmControlPanel => new(_haContext);
		public AlertEntities Alert => new(_haContext);
		public AutomationEntities Automation => new(_haContext);
		public BinarySensorEntities BinarySensor => new(_haContext);
		public ButtonEntities Button => new(_haContext);
		public CalendarEntities Calendar => new(_haContext);
		public CameraEntities Camera => new(_haContext);
		public ClimateEntities Climate => new(_haContext);
		public CoverEntities Cover => new(_haContext);
		public DeviceTrackerEntities DeviceTracker => new(_haContext);
		public GroupEntities Group => new(_haContext);
		public HumidifierEntities Humidifier => new(_haContext);
		public InputBooleanEntities InputBoolean => new(_haContext);
		public InputDatetimeEntities InputDatetime => new(_haContext);
		public InputNumberEntities InputNumber => new(_haContext);
		public InputSelectEntities InputSelect => new(_haContext);
		public InputTextEntities InputText => new(_haContext);
		public LightEntities Light => new(_haContext);
		public MediaPlayerEntities MediaPlayer => new(_haContext);
		public NumberEntities Number => new(_haContext);
		public PersistentNotificationEntities PersistentNotification => new(_haContext);
		public PersonEntities Person => new(_haContext);
		public RemoteEntities Remote => new(_haContext);
		public SceneEntities Scene => new(_haContext);
		public ScriptEntities Script => new(_haContext);
		public SelectEntities Select => new(_haContext);
		public SensorEntities Sensor => new(_haContext);
		public SunEntities Sun => new(_haContext);
		public SwitchEntities Switch => new(_haContext);
		public TimerEntities Timer => new(_haContext);
		public VacuumEntities Vacuum => new(_haContext);
		public VarEntities Var => new(_haContext);
		public VariableEntities Variable => new(_haContext);
		public WeatherEntities Weather => new(_haContext);
		public ZoneEntities Zone => new(_haContext);
	}

	public class AlarmControlPanelEntities
	{
		private readonly IHaContext _haContext;
		public AlarmControlPanelEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Ground Floor Doors</summary>
		public AlarmControlPanelEntity GroundFloorDoors => new(_haContext, "alarm_control_panel.ground_floor_doors");
		///<summary>Ground Floor Windows</summary>
		public AlarmControlPanelEntity GroundFloorWindows => new(_haContext, "alarm_control_panel.ground_floor_windows");
		///<summary>SquiggleBear Hoose</summary>
		public AlarmControlPanelEntity SquigglebearHoose => new(_haContext, "alarm_control_panel.squigglebear_hoose");
		///<summary>Upstair Windows</summary>
		public AlarmControlPanelEntity UpstairWindows => new(_haContext, "alarm_control_panel.upstair_windows");
	}

	public class AlertEntities
	{
		private readonly IHaContext _haContext;
		public AlertEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Kitchen Mouse Trap</summary>
		public AlertEntity KitchenMouseTrap => new(_haContext, "alert.kitchen_mouse_trap");
		///<summary>Office Mouse Trap</summary>
		public AlertEntity OfficeMouseTrap => new(_haContext, "alert.office_mouse_trap");
		///<summary>Toilet Mouse Trap</summary>
		public AlertEntity ToiletMouseTrap => new(_haContext, "alert.toilet_mouse_trap");
	}

	public class AutomationEntities
	{
		private readonly IHaContext _haContext;
		public AutomationEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Backgarden: Turn on Lights When its Dark and the back door is opened</summary>
		public AutomationEntity BackgardenTurnOnLightsWhenItsDarkAndTheBackDoorIsOpened => new(_haContext, "automation.backgarden_turn_on_lights_when_its_dark_and_the_back_door_is_opened");
		///<summary>Bathroom: Turn On Lights When Bathroom Colour Switch Clicked</summary>
		public AutomationEntity BathroomTurnOnLightsWhenBathroomColourSwitchClicked => new(_haContext, "automation.bathroom_turn_on_lights_when_bathroom_colour_switch_clicked");
		///<summary>Bathroom: Turn On Lights When Bathroom White Switch Clicked</summary>
		public AutomationEntity BathroomTurnOnLightsWhenBathroomSwitchOneClicked2 => new(_haContext, "automation.bathroom_turn_on_lights_when_bathroom_switch_one_clicked_2");
		///<summary>Bedroom: Squiggley's Wardrobe Turn On Light When The Door Opens</summary>
		public AutomationEntity BedroomLightSquiggleysWardrobeWhenTheDoorOpens => new(_haContext, "automation.bedroom_light_squiggleys_wardrobe_when_the_door_opens");
		///<summary>Bedroom: Wee Bears Wardrobe Turn On Light When The Door Opens</summary>
		public AutomationEntity BedroomLightWeeBearsWardrobeWhenTheDoorOpens => new(_haContext, "automation.bedroom_light_wee_bears_wardrobe_when_the_door_opens");
		///<summary>Bedroom : Night Light Turn On Boolean when Motion is Detected</summary>
		public AutomationEntity BedroomNightLightTurnOnBooleanWhenMotionIsDetected2 => new(_haContext, "automation.bedroom_night_light_turn_on_boolean_when_motion_is_detected_2");
		///<summary>Bedroom : Night Light Stop Timer and Turn Off Boolean</summary>
		public AutomationEntity BedroomStopTimerAndTurnOffNightLight => new(_haContext, "automation.bedroom_stop_timer_and_turn_off_night_light");
		///<summary>Bedroom: Toggle Squiggley Ceiling Lights</summary>
		public AutomationEntity BedroomToggleSquiggleCeilingLights => new(_haContext, "automation.bedroom_toggle_squiggle_ceiling_lights");
		///<summary>Bedroom: Toggle Squiggley Side Lights</summary>
		public AutomationEntity BedroomToggleSquiggleyTableLights => new(_haContext, "automation.bedroom_toggle_squiggley_table_lights");
		///<summary>Bedroom: Toggle Wee Bear Ceiling Lights</summary>
		public AutomationEntity BedroomToggleWeeBearCeilingLights => new(_haContext, "automation.bedroom_toggle_wee_bear_ceiling_lights");
		///<summary>Bedroom: Toggle Wee Bear Side Lights </summary>
		public AutomationEntity BedroomToggleWeeBearTableLights => new(_haContext, "automation.bedroom_toggle_wee_bear_table_lights");
		///<summary>Bedroom: Turn House Off When Wee Bear Long Clicks Button</summary>
		public AutomationEntity BedroomTurnHouseOffWhenButtonPressed => new(_haContext, "automation.bedroom_turn_house_off_when_button_pressed");
		///<summary>Bedroom: Turn House Off When Squiggley Double Clicks Button</summary>
		public AutomationEntity BedroomTurnHouseOffWhenSquiggleySingleClicksButton => new(_haContext, "automation.bedroom_turn_house_off_when_squiggley_single_clicks_button");
		///<summary>Bedroom: Night Light Turn Off And Cancel Timer When Boolean Off</summary>
		public AutomationEntity BedroomTurnOffNightLightAndCancelTimerWhenBooleanOff => new(_haContext, "automation.bedroom_turn_off_night_light_and_cancel_timer_when_boolean_off");
		///<summary>Bedroom: Squiggley's Wardrobe Turn Off Light When The Door Closes</summary>
		public AutomationEntity BedroomTurnOffSquiggleySWardrobeLightWhenTheDoorCloses => new(_haContext, "automation.bedroom_turn_off_squiggley_s_wardrobe_light_when_the_door_closes");
		///<summary>Bedroom: Wee Bears Wardrobe Turn Off Light When The Door Closes</summary>
		public AutomationEntity BedroomTurnOffWeeBearsWardrobeLightWhenTheDoorCloses => new(_haContext, "automation.bedroom_turn_off_wee_bears_wardrobe_light_when_the_door_closes");
		///<summary>Wee Bear: Toggle Front Lights</summary>
		public AutomationEntity BedroomTurnOnLightsWhenSwitchOneClicked => new(_haContext, "automation.bedroom_turn_on_lights_when_switch_one_clicked");
		///<summary>Wee Bear: Toggle Back Lights</summary>
		public AutomationEntity BedroomTurnOnLightsWhenSwitchTwoClicked => new(_haContext, "automation.bedroom_turn_on_lights_when_switch_two_clicked");
		///<summary>Bedroom: Night Light Turn On And Start Timer When Boolean On</summary>
		public AutomationEntity BedroomTurnOnNightLightAndStartTimerWhenBooleanOn => new(_haContext, "automation.bedroom_turn_on_night_light_and_start_timer_when_boolean_on");
		///<summary>Car Defroster: Flash Light If Car Needs Defrosted</summary>
		public AutomationEntity CarDefrosterFlashLightIfCarNeedsDefrosted => new(_haContext, "automation.car_defroster_flash_light_if_car_needs_defrosted");
		///<summary>Car Defroster: Start Monitoring Temperature</summary>
		public AutomationEntity CarDefrosterStartMonitoringTemperature => new(_haContext, "automation.car_defroster_start_monitoring_temperature");
		///<summary>Car Defroster: Stop Monitoring Temperature</summary>
		public AutomationEntity CarDefrosterStopMonitoringTemperature => new(_haContext, "automation.car_defroster_stop_monitoring_temperature");
		///<summary>CCTV: Motion Detected by Bridge Camera</summary>
		public AutomationEntity CctvMotionDetectedByBridgeCamera => new(_haContext, "automation.cctv_motion_detected_by_bridge_camera");
		///<summary>CCTV: Motion detected From Garage Roof Camera</summary>
		public AutomationEntity CctvMotionDetectedFromGarageRoofCamera2 => new(_haContext, "automation.cctv_motion_detected_from_garage_roof_camera_2");
		///<summary>CCTV: Motion detected in the Back Climbing Camera</summary>
		public AutomationEntity CctvMotionDetectedInTheBackClimbingCamera2 => new(_haContext, "automation.cctv_motion_detected_in_the_back_climbing_camera_2");
		///<summary>CCTV: Motion detected in the Back Door Camera</summary>
		public AutomationEntity CctvMotionDetectedInTheBackDoorCamera => new(_haContext, "automation.cctv_motion_detected_in_the_back_door_camera");
		///<summary>CCTV: Motion detected in the Squirrely Palace</summary>
		public AutomationEntity CctvMotionDetectedInTheSquirrelyPalace => new(_haContext, "automation.cctv_motion_detected_in_the_squirrely_palace");
		///<summary>CCTV: Motion detected - Check Office Mouse Cam</summary>
		public AutomationEntity CctvMotionDetectedInTheSquirrelyPalaceDuplicate => new(_haContext, "automation.cctv_motion_detected_in_the_squirrely_palace_duplicate");
		///<summary>Common Lights: Toggle Common Lights When Bathroom Button 2 is Clicked</summary>
		public AutomationEntity CommonLightsToggleCommonLightsWhenBathroomButton2IsClicked => new(_haContext, "automation.common_lights_toggle_common_lights_when_bathroom_button_2_is_clicked");
		///<summary>Dark Outside: Close curtains</summary>
		public AutomationEntity DarkOutsideCloseCurtains => new(_haContext, "automation.dark_outside_close_curtains");
		///<summary>Toilet: Dim lights based on sun elevation</summary>
		public AutomationEntity DimLightsBasedOnSunElevation => new(_haContext, "automation.dim_lights_based_on_sun_elevation");
		///<summary>DoorBell: Flash Lights when Boolean is true</summary>
		public AutomationEntity DoorbellFlashLightsWhenBooleanIsTrue => new(_haContext, "automation.doorbell_flash_lights_when_boolean_is_true");
		///<summary>DoorBell: Notify House and Flash Eve Lights when DoorBell Rung</summary>
		public AutomationEntity DoorbellNotifyHouseAndFlashEveLightsWhenDoorbellRung2 => new(_haContext, "automation.doorbell_notify_house_and_flash_eve_lights_when_doorbell_rung_2");
		///<summary>Garden: Notify when motion is detected at the Garden Gate</summary>
		public AutomationEntity GardenNotifyWhenMotionIsDetectedAtTheGardenGate => new(_haContext, "automation.garden_notify_when_motion_is_detected_at_the_garden_gate");
		///<summary>Garden: Notify when motion is detected in back garden corner</summary>
		public AutomationEntity GardenNotifyWhenMotionIsDetectedInBackGardenCorner => new(_haContext, "automation.garden_notify_when_motion_is_detected_in_back_garden_corner");
		///<summary>Garden: Notify when motion is detected in front of office window</summary>
		public AutomationEntity GardenNotifyWhenMotionIsDetectedInFrontOfOfficeWindow => new(_haContext, "automation.garden_notify_when_motion_is_detected_in_front_of_office_window");
		///<summary>Garden: Turn on eve lights when its dark and motion is detected</summary>
		public AutomationEntity GardenTurnOnEveLightsWhenItsDarkAndMotionIsDetected => new(_haContext, "automation.garden_turn_on_eve_lights_when_its_dark_and_motion_is_detected");
		///<summary>Garden: Turn on lights when its dark</summary>
		public AutomationEntity GardenTurnOnLightsWhenItsDark => new(_haContext, "automation.garden_turn_on_lights_when_its_dark");
		///<summary>Tag Scanned: Good Morning </summary>
		public AutomationEntity GoodmorningtagIsScanned => new(_haContext, "automation.goodmorningtag_is_scanned");
		///<summary>Hallway: Turn on Lights When Hallway Light Switch One Clicked</summary>
		public AutomationEntity HallwayTurnOnLightsWhenHallwayLightSwitchOneClicked => new(_haContext, "automation.hallway_turn_on_lights_when_hallway_light_switch_one_clicked");
		///<summary>Hallway: Toggle Lights When Bathroom Wall Switch 3 Clicked</summary>
		public AutomationEntity HallwayTurnOnLightsWhenStairSwitchOneClicked => new(_haContext, "automation.hallway_turn_on_lights_when_stair_switch_one_clicked");
		///<summary>Heating: Active/deactivate heating schedule for room</summary>
		public AutomationEntity HeatingActiveDeactivateHeatingScheduleForRoom => new(_haContext, "automation.heating_active_deactivate_heating_schedule_for_room");
		///<summary>Heating: Bedroom Schedule</summary>
		public AutomationEntity HeatingBedroomSchedule => new(_haContext, "automation.heating_bedroom_schedule");
		///<summary>Heating: Kitchen Schedule</summary>
		public AutomationEntity HeatingKitchenSchedule => new(_haContext, "automation.heating_kitchen_schedule");
		///<summary>Heating: Livingroom Schedule</summary>
		public AutomationEntity HeatingLivingroomSchedule => new(_haContext, "automation.heating_livingroom_schedule");
		///<summary>Heating: Office Schedule</summary>
		public AutomationEntity HeatingOfficeSchedule => new(_haContext, "automation.heating_office_schedule");
		///<summary>Heating: Turn All Heating off week day nights</summary>
		public AutomationEntity HeatingTurnAllHeatingOffWeekDayNights => new(_haContext, "automation.heating_turn_all_heating_off_week_day_nights");
		///<summary>Heating: Turn All Heating off weekend nights</summary>
		public AutomationEntity HeatingTurnAllHeatingOffWeekendNights => new(_haContext, "automation.heating_turn_all_heating_off_weekend_nights");
		///<summary>Heating: Turn Off Boost heating for room</summary>
		public AutomationEntity HeatingTurnOffBoostHeatingForRoom => new(_haContext, "automation.heating_turn_off_boost_heating_for_room");
		///<summary>Heating: Turn Off When Boost Timer is Finished</summary>
		public AutomationEntity HeatingTurnOffWhenBoostTimerIsFinished => new(_haContext, "automation.heating_turn_off_when_boost_timer_is_finished");
		///<summary>Heating: Turn off when schedule becomes inactive</summary>
		public AutomationEntity HeatingTurnOffWhenScheduleBecomesInactive => new(_haContext, "automation.heating_turn_off_when_schedule_becomes_inactive");
		///<summary>Heating: Turn On Boost heating for room</summary>
		public AutomationEntity HeatingTurnOnBoostHeatingForRoom => new(_haContext, "automation.heating_turn_on_boost_heating_for_room");
		///<summary>Heating: Toggle Boost heating for room</summary>
		public AutomationEntity HeatingTurnOnBoostHeatingForRoomDuplicate => new(_haContext, "automation.heating_turn_on_boost_heating_for_room_duplicate");
		///<summary>Heating: Turn on when schedule is active and house is occupied</summary>
		public AutomationEntity HeatingTurnOnWhenScheduleIsActiveAndHouseIsOccupied => new(_haContext, "automation.heating_turn_on_when_schedule_is_active_and_house_is_occupied");
		///<summary>Heating: Turn on when schedule is active and Someone Arrives Home</summary>
		public AutomationEntity HeatingTurnOnWhenScheduleIsActiveAndSomeoneArrivesHome => new(_haContext, "automation.heating_turn_on_when_schedule_is_active_and_someone_arrives_home");
		///<summary>Heating: Vestibule Schedule</summary>
		public AutomationEntity HeatingVestibuleSchedule => new(_haContext, "automation.heating_vestibule_schedule");
		///<summary>Heating: Wee Bear Schedule</summary>
		public AutomationEntity HeatingWeeBearSchedule => new(_haContext, "automation.heating_wee_bear_schedule");
		///<summary>Home Assistant Startup: Setting up defaults</summary>
		public AutomationEntity HomeAssistantStartupSettingUpDefaults => new(_haContext, "automation.home_assistant_startup_setting_up_defaults");
		///<summary>Kitchen: Bench Ceiling Lights - Brighten</summary>
		public AutomationEntity KitchenBenchCeilingLightsBrighten => new(_haContext, "automation.kitchen_bench_ceiling_lights_brighten");
		///<summary>Kitchen: Main Ceiling Lights - Brighten</summary>
		public AutomationEntity KitchenBrightenMainCeilingLights => new(_haContext, "automation.kitchen_brighten_main_ceiling_lights");
		///<summary>Kitchen: Cooking Ceiling Lights - Brighten</summary>
		public AutomationEntity KitchenCookingCeilingLightsBrighten => new(_haContext, "automation.kitchen_cooking_ceiling_lights_brighten");
		///<summary>Kitchen: Dining Ceiling Lights - Brighten </summary>
		public AutomationEntity KitchenDiningCeilingLightsBrighten => new(_haContext, "automation.kitchen_dining_ceiling_lights_brighten");
		///<summary>Kitchen: Bench Ceiling Lights - Toggle </summary>
		public AutomationEntity KitchenToggleBenchCeilingLights => new(_haContext, "automation.kitchen_toggle_bench_ceiling_lights");
		///<summary>Kitchen: Cooking Ceiling Lights - Toggle</summary>
		public AutomationEntity KitchenToggleCookingLights => new(_haContext, "automation.kitchen_toggle_cooking_lights");
		///<summary>Kitchen: Dining Ceiling Lights - Toggle </summary>
		public AutomationEntity KitchenToggleDiningCeilingLights => new(_haContext, "automation.kitchen_toggle_dining_ceiling_lights");
		///<summary>Kitchen: Main Ceiling Lights - Toggle</summary>
		public AutomationEntity KitchenToggleMainCeilingLights => new(_haContext, "automation.kitchen_toggle_main_ceiling_lights");
		///<summary>Lighting: Is it Dark Outside?</summary>
		public AutomationEntity LightingIsItDarkOutside => new(_haContext, "automation.lighting_is_it_dark_outside");
		///<summary>Lighting: Is it Light Outside?</summary>
		public AutomationEntity LightingIsItLightOutside => new(_haContext, "automation.lighting_is_it_light_outside");
		///<summary>Livingroom: Calibrate curtain</summary>
		public AutomationEntity LivingroomCalibrateCurtain => new(_haContext, "automation.livingroom_calibrate_curtain");
		///<summary>Livingroom: Toggle Ceiling lights</summary>
		public AutomationEntity LivingroomCeilingLightSwitch => new(_haContext, "automation.livingroom_ceiling_light_switch");
		///<summary>Livingroom: Kodi Decrease Volume</summary>
		public AutomationEntity LivingroomKodiDecreaseVolume => new(_haContext, "automation.livingroom_kodi_decrease_volume");
		///<summary>Livingroom: Kodi Increase Volume</summary>
		public AutomationEntity LivingroomKodiIncreaseVolume => new(_haContext, "automation.livingroom_kodi_increase_volume");
		///<summary>Livingroom: Lights  Off</summary>
		public AutomationEntity LivingroomLightsOff => new(_haContext, "automation.livingroom_lights_off");
		///<summary>Livingroom: Toggle Lamps</summary>
		public AutomationEntity LivingroomMakeCeilingLightsBrighter => new(_haContext, "automation.livingroom_make_ceiling_lights_brighter");
		///<summary>Livingroom: Open Curtain if its Closed</summary>
		public AutomationEntity LivingroomOpenCurtainIfItsClosed => new(_haContext, "automation.livingroom_open_curtain_if_its_closed");
		///<summary>Livingroom: Orange 50% Lights</summary>
		public AutomationEntity LivingroomOrange50Lights => new(_haContext, "automation.livingroom_orange_50_lights");
		///<summary>Livingroom: Red 30% Lights </summary>
		public AutomationEntity LivingroomRed30Lights => new(_haContext, "automation.livingroom_red_30_lights");
		///<summary>Livingroom: Stupid Box Off (Double click)</summary>
		public AutomationEntity LivingroomStupidBoxOffDoubleClick => new(_haContext, "automation.livingroom_stupid_box_off_double_click");
		///<summary>Livingroom: Switch Kodi Profile to Wee Bear</summary>
		public AutomationEntity LivingroomSwitchKodiProfileToWeeBear => new(_haContext, "automation.livingroom_switch_kodi_profile_to_wee_bear");
		///<summary>Livingroom: Switch Kodi Profile to Squiggley</summary>
		public AutomationEntity LivingroomSwitchProfileToSquiggley => new(_haContext, "automation.livingroom_switch_profile_to_squiggley");
		///<summary>Livingroom: Toggle Ceiling lights (White)</summary>
		public AutomationEntity LivingroomToggleCeilingLightsWhite => new(_haContext, "automation.livingroom_toggle_ceiling_lights_white");
		///<summary>Livingroom: Close Curtain if its Open</summary>
		public AutomationEntity LivingroomToggleCurtains => new(_haContext, "automation.livingroom_toggle_curtains");
		///<summary>Livingroom: Toggle Lamps (Red)</summary>
		public AutomationEntity LivingroomToggleLampsRed => new(_haContext, "automation.livingroom_toggle_lamps_red");
		///<summary>Livingroom: Toggle Stupid Box</summary>
		public AutomationEntity LivingroomToggleStupidBox => new(_haContext, "automation.livingroom_toggle_stupid_box");
		///<summary>Livingroom: Turn Off Amp When Shield TV is Turned Off</summary>
		public AutomationEntity LivingroomTurnOffAmpWhenShieldTvIsTurnedOff => new(_haContext, "automation.livingroom_turn_off_amp_when_shield_tv_is_turned_off");
		///<summary>Livingroom: Turn On Amp When Shield TV is Turned On</summary>
		public AutomationEntity LivingroomTurnOnOffAmpWhenShieldTvIsTurnedOnOff => new(_haContext, "automation.livingroom_turn_on_off_amp_when_shield_tv_is_turned_on_off");
		///<summary>Office: Turn On Monitors, PC And Stars If Dark</summary>
		public AutomationEntity LivingroomTurnToggleTvAmpKodiAmbiLightingAndTableLamps => new(_haContext, "automation.livingroom_turn_toggle_tv_amp_kodi_ambi_lighting_and_table_lamps");
		///<summary>Livingroom: Yellow 100% Lights </summary>
		public AutomationEntity LivingroomYellow100Lights => new(_haContext, "automation.livingroom_yellow_100_lights");
		///<summary>Logger: Configure Logging Levels</summary>
		public AutomationEntity LoggerConfigureLoggingLevels => new(_haContext, "automation.logger_configure_logging_levels");
		///<summary>Makeup: Reset Lights When Input Boolean Turned Off</summary>
		public AutomationEntity MakeupResetLightsWhenSwitchTurnedOff2 => new(_haContext, "automation.makeup_reset_lights_when_switch_turned_off_2");
		///<summary>Makeup: Start Timer and Turn On Lights</summary>
		public AutomationEntity MakeupStartTimerAndTurnOnLights => new(_haContext, "automation.makeup_start_timer_and_turn_on_lights");
		///<summary>Makeup : Stop Timer and Turn Off Input Boolean</summary>
		public AutomationEntity MakeupStopTimerAndTurnOffSwitch => new(_haContext, "automation.makeup_stop_timer_and_turn_off_switch");
		///<summary>Mousetrap: Notify Squiggley When a Mouse is Caught in Trap One</summary>
		public AutomationEntity MousetrapNotifySquiggleyWhenAMouseIsCaughtInTrapOne => new(_haContext, "automation.mousetrap_notify_squiggley_when_a_mouse_is_caught_in_trap_one");
		///<summary>Mousetrap: Notify Squiggley When a Mouse is Caught in Trap Three</summary>
		public AutomationEntity MousetrapNotifySquiggleyWhenAMouseIsCaughtInTrapThree => new(_haContext, "automation.mousetrap_notify_squiggley_when_a_mouse_is_caught_in_trap_three");
		///<summary>Mousetrap: Notify Squiggley When a Mouse is Caught in Trap Two</summary>
		public AutomationEntity MousetrapNotifySquiggleyWhenAMouseIsCaughtInTrapTwo => new(_haContext, "automation.mousetrap_notify_squiggley_when_a_mouse_is_caught_in_trap_two");
		///<summary>Livingroom: Movie Night: Movie Ended</summary>
		public AutomationEntity MovieNightMovieEnded => new(_haContext, "automation.movie_night_movie_ended");
		///<summary>Livingroom: Movie Night Movie Paused</summary>
		public AutomationEntity MovieNightMoviePaused => new(_haContext, "automation.movie_night_movie_paused");
		///<summary>Livingroom: Movie Night: Zaphod Movie Playing</summary>
		public AutomationEntity MovieNightZaphodMoviePlaying => new(_haContext, "automation.movie_night_zaphod_movie_playing");
		///<summary>Office: Turn off stars when spotlight is turned on</summary>
		public AutomationEntity NewAutomation => new(_haContext, "automation.new_automation");
		///<summary>Notifications: Turn Off Squirrel Notifications when back door is opened</summary>
		public AutomationEntity NotificationsTurnOffSquirrelNotificationsWhenBackDoorIsOpened2 => new(_haContext, "automation.notifications_turn_off_squirrel_notifications_when_back_door_is_opened_2");
		///<summary>Notifications: Turn On Squirrel Notifications when back door is Closed</summary>
		public AutomationEntity NotificationsTurnOnSquirrelNotificationsWhenBackDoorIsClosed2 => new(_haContext, "automation.notifications_turn_on_squirrel_notifications_when_back_door_is_closed_2");
		///<summary>Occupancy: Announce Arrive/Leave Home</summary>
		public AutomationEntity OccupancyAnnounceArriveLeaveHome => new(_haContext, "automation.occupancy_announce_arrive_leave_home");
		///<summary>Occupancy: Back Nut Hut Opened</summary>
		public AutomationEntity OccupancyBackNutHutOpened => new(_haContext, "automation.occupancy_back_nut_hut_opened");
		///<summary>Occupancy: Dev : Send message on location updates</summary>
		public AutomationEntity OccupancyDevSendMessageOnLocationUpdates => new(_haContext, "automation.occupancy_dev_send_message_on_location_updates");
		///<summary>Occupancy: Front Nut Hut Opened</summary>
		public AutomationEntity OccupancyFrontNutHutOpened2 => new(_haContext, "automation.occupancy_front_nut_hut_opened_2");
		///<summary>Occupancy: Notify Squiggley when someone leaves home</summary>
		public AutomationEntity OccupancyNotifySquiggleyWhenSomeoneLeavesHome => new(_haContext, "automation.occupancy_notify_squiggley_when_someone_leaves_home");
		///<summary>Occupancy: Occupancy Off</summary>
		public AutomationEntity OccupancyOccupancyOff => new(_haContext, "automation.occupancy_occupancy_off");
		///<summary>Occupancy: Occupancy On</summary>
		public AutomationEntity OccupancyOccupancyOn => new(_haContext, "automation.occupancy_occupancy_on");
		///<summary>Occupancy: Palace Front Door Opened</summary>
		public AutomationEntity OccupancyPalaceFrontDoorOpened => new(_haContext, "automation.occupancy_palace_front_door_opened");
		///<summary>Occupancy: Perform Welcome Home When Someone Arrives</summary>
		public AutomationEntity OccupancyPerformWelcomeHomeWhenSomeoneArrives => new(_haContext, "automation.occupancy_perform_welcome_home_when_someone_arrives");
		///<summary>Occupancy: Turn Everything Off When Everyone Leaves</summary>
		public AutomationEntity OccupancyTurnEverythingOffWhenEveryoneLeaves => new(_haContext, "automation.occupancy_turn_everything_off_when_everyone_leaves");
		///<summary>Occupancy: Turn Off Garden Lights If Nobody is Home</summary>
		public AutomationEntity OccupancyTurnOffBackGardenLightsIfNobodyIsHome => new(_haContext, "automation.occupancy_turn_off_back_garden_lights_if_nobody_is_home");
		///<summary>Occupancy: Turn Off Garden Lights At Dawn</summary>
		public AutomationEntity OccupancyTurnOffGardenLightsAtDawn2 => new(_haContext, "automation.occupancy_turn_off_garden_lights_at_dawn_2");
		///<summary>Occupancy: Turn On Garden Lights At Dusk</summary>
		public AutomationEntity OccupancyTurnOnGardenLightsAtDusk => new(_haContext, "automation.occupancy_turn_on_garden_lights_at_dusk");
		///<summary>Occupancy: Turn On Common Lights When Dark and Someone Is Home</summary>
		public AutomationEntity OccupancyTurnOnLightsWhenDarkAndSomeoneIsHome => new(_haContext, "automation.occupancy_turn_on_lights_when_dark_and_someone_is_home");
		///<summary>Occupancy: Turn On the Common Lights When Someone Opens the Front Door</summary>
		public AutomationEntity OccupancyTurnOnTheCommonLightsWhenSomeoneOpensTheFrontDoor => new(_haContext, "automation.occupancy_turn_on_the_common_lights_when_someone_opens_the_front_door");
		///<summary>Office: Turn on Office Ceiling One & Four When Office Switch One Clicked</summary>
		public AutomationEntity OfficeTurnOnOfficeCeilingOneFourWhenOfficeSwitchOneClicked => new(_haContext, "automation.office_turn_on_office_ceiling_one_four_when_office_switch_one_clicked");
		///<summary>Office: Turn on Office Ceiling Two & Three When Office Switch Two Clicked</summary>
		public AutomationEntity OfficeTurnOnOfficeCeilingTwoThreeWhenOfficeSwitchTwoClicked => new(_haContext, "automation.office_turn_on_office_ceiling_two_three_when_office_switch_two_clicked");
		///<summary>Office: Wall Switch - Make it smelly</summary>
		public AutomationEntity OfficeWallSwitchMakeItSmelly => new(_haContext, "automation.office_wall_switch_make_it_smelly");
		///<summary>Office: Wall Switch - Turn on Back Lights  </summary>
		public AutomationEntity OfficeWallSwitchTurnOnBackLights => new(_haContext, "automation.office_wall_switch_turn_on_back_lights");
		///<summary>Office: Wall Switch - Turn on Infinity Lamp</summary>
		public AutomationEntity OfficeWallSwitchTurnOnInfinityLamp => new(_haContext, "automation.office_wall_switch_turn_on_infinity_lamp");
		///<summary>Office: Wall Switch - Turn on Stars </summary>
		public AutomationEntity OfficeWallSwitchTurnOnStars => new(_haContext, "automation.office_wall_switch_turn_on_stars");
		///<summary>Office: Wall Switch - Turn on Window Lights </summary>
		public AutomationEntity OfficeWallSwitchTurnOnWindowLights => new(_haContext, "automation.office_wall_switch_turn_on_window_lights");
		///<summary>Packages: Notify Squiggley on Package Status Change</summary>
		public AutomationEntity PackagesNotifySquiggleyOnPackageStatusChange => new(_haContext, "automation.packages_notify_squiggley_on_package_status_change");
		///<summary>Rubbish: Reset Landfill Dismissed</summary>
		public AutomationEntity ResetLandfillDismissed => new(_haContext, "automation.reset_landfill_dismissed");
		///<summary>Rubbish: Reset Garden Bin Dismissed </summary>
		public AutomationEntity RubbishResetGardenBinDismissed => new(_haContext, "automation.rubbish_reset_garden_bin_dismissed");
		///<summary>Rubbish: Reset Recycling Dismissed </summary>
		public AutomationEntity RubbishResetRecyclingDismissed => new(_haContext, "automation.rubbish_reset_recycling_dismissed");
		///<summary>Send Notification for Home Assistant Alert</summary>
		public AutomationEntity SendNotificationForHomeAssistantAlert2 => new(_haContext, "automation.send_notification_for_home_assistant_alert_2");
		///<summary>Server: Turn Off The Server Fan When It Has Cooled</summary>
		public AutomationEntity ServerTurnOffTheServerFanWhenItHasCooled => new(_haContext, "automation.server_turn_off_the_server_fan_when_it_has_cooled");
		///<summary>Server: Turn On Fan When Its Hot</summary>
		public AutomationEntity ServerTurnOnFanWhenItsHot => new(_haContext, "automation.server_turn_on_fan_when_its_hot");
		///<summary>Sleeping: Mark Squiggley as awake when couch opens or closes </summary>
		public AutomationEntity SleepingMarkAsAwakeWhenCouchPopOutClosed => new(_haContext, "automation.sleeping_mark_as_awake_when_couch_pop_out_closed");
		///<summary>Sleeping: Pause Kodi When I Fall Asleep On The Couch</summary>
		public AutomationEntity SleepingPauseKodiWhenIFallAsleepOnTheCouch => new(_haContext, "automation.sleeping_pause_kodi_when_i_fall_asleep_on_the_couch");
		///<summary>Sleeping: Squiggley has woken up</summary>
		public AutomationEntity SleepingSquiggleyHasWokenUp => new(_haContext, "automation.sleeping_squiggley_has_woken_up");
		///<summary>Sleeping: Squiggley Has Fallen Asleep On the Couch </summary>
		public AutomationEntity SleepingSquiggleyIsAwake => new(_haContext, "automation.sleeping_squiggley_is_awake");
		///<summary>Slow Cooker: Turn Off Slow Cooker at specified time</summary>
		public AutomationEntity SlowCookerTurnOffSlowCookerAtSpecifiedTime => new(_haContext, "automation.slow_cooker_turn_off_slow_cooker_at_specified_time");
		///<summary>Slow Cooker: Turn On at specified time</summary>
		public AutomationEntity SlowCookerTurnOnAtSpecifiedTime => new(_haContext, "automation.slow_cooker_turn_on_at_specified_time");
		///<summary>Squiggley Heart Rate </summary>
		public AutomationEntity SquiggleyHeartRate => new(_haContext, "automation.squiggley_heart_rate");
		///<summary>Squiggley Sleep Status</summary>
		public AutomationEntity SquiggleySleepStatus => new(_haContext, "automation.squiggley_sleep_status");
		///<summary>Tag Scanned: Good Morning Office Heating</summary>
		public AutomationEntity TagScannedGoodMorningOfficeHeating => new(_haContext, "automation.tag_scanned_good_morning_office_heating");
		///<summary>Toilet: Motion Detected And Door Closed Then Stop Timer And Set Occupied</summary>
		public AutomationEntity ToiletMotionDetectedAndDoorClosedThenStopTimerAndSetOccupied => new(_haContext, "automation.toilet_motion_detected_and_door_closed_then_stop_timer_and_set_occupied");
		///<summary>Toilet: Occupied And Door Opened Then Start Timer</summary>
		public AutomationEntity ToiletOccupiedAndDoorOpenedThenStartTimer => new(_haContext, "automation.toilet_occupied_and_door_opened_then_start_timer");
		///<summary>Toilet: Occupied Turn vestibule One Light To Red</summary>
		public AutomationEntity ToiletOccupiedTurnVestibuleOneLightToRed => new(_haContext, "automation.toilet_occupied_turn_vestibule_one_light_to_red");
		///<summary>Toilet: Turn off lights at end of timer</summary>
		public AutomationEntity ToiletTurnOffLightsAtEndOfTimer => new(_haContext, "automation.toilet_turn_off_lights_at_end_of_timer");
		///<summary>Toilet: Turn on Toilet Ceiling When Toilet Switch Clicked</summary>
		public AutomationEntity ToiletTurnOnToiletCeilingWhenToiletSwitchClicked2 => new(_haContext, "automation.toilet_turn_on_toilet_ceiling_when_toilet_switch_clicked_2");
		///<summary>Toilet: Unoccupied, Door is Opened Then Turn On Lights And Start Timer</summary>
		public AutomationEntity ToiletUnoccupiedDoorIsOpenedThenTurnOnLightsAndStartTimer => new(_haContext, "automation.toilet_unoccupied_door_is_opened_then_turn_on_lights_and_start_timer");
		///<summary>Vestibule: Toggle Lights When Switch Clicked</summary>
		public AutomationEntity VestibuleToggleLightsWhenSwitchClicked => new(_haContext, "automation.vestibule_toggle_lights_when_switch_clicked");
		///<summary>Vestibule: Turn on Lights when front door opened and its dark</summary>
		public AutomationEntity VestibuleTurnOnLightsWhenFrontDoorOpenedAndItsDark => new(_haContext, "automation.vestibule_turn_on_lights_when_front_door_opened_and_its_dark");
		///<summary>Vestibule: Turn on one light low red When Motion Is Detected and home is off</summary>
		public AutomationEntity VestibuleTurnOnLightsWhenMotionIsDetected => new(_haContext, "automation.vestibule_turn_on_lights_when_motion_is_detected");
		///<summary>Vestibule: Turn on Lights When Motion is Detected and its Dark</summary>
		public AutomationEntity VestibuleTurnOnLightsWhenMotionIsDetectedAndItsDark => new(_haContext, "automation.vestibule_turn_on_lights_when_motion_is_detected_and_its_dark");
		///<summary>Weather: Sunset Transition</summary>
		public AutomationEntity WeatherSunsetTransition => new(_haContext, "automation.weather_sunset_transition");
		///<summary>Wee Bear: Toggle Office Lamp</summary>
		public AutomationEntity WeeBearToggleOfficeLamp => new(_haContext, "automation.wee_bear_toggle_office_lamp");
		///<summary>Xmas: Turn On Outside Xmas Lights At Dusk</summary>
		public AutomationEntity XmasTurnOnOutsideXmasLightsAtDusk => new(_haContext, "automation.xmas_turn_on_outside_xmas_lights_at_dusk");
		///<summary>Zigbee: Disable Zigbee Join</summary>
		public AutomationEntity ZigbeeDisableZigbeeJoin => new(_haContext, "automation.zigbee_disable_zigbee_join");
		///<summary>Zigbee: Disable Zigbee Join Timer</summary>
		public AutomationEntity ZigbeeDisableZigbeeJoinTimer => new(_haContext, "automation.zigbee_disable_zigbee_join_timer");
		///<summary>Zigbee: Enable Zigbee Join</summary>
		public AutomationEntity ZigbeeEnableZigbeeJoin => new(_haContext, "automation.zigbee_enable_zigbee_join");
	}

	public class BinarySensorEntities
	{
		private readonly IHaContext _haContext;
		public BinarySensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>0x00158d000431d9a1 contact</summary>
		public BinarySensorEntity E0x00158d000431d9a1Contact => new(_haContext, "binary_sensor.0x00158d000431d9a1_contact");
		///<summary>Ambilight Button</summary>
		public BinarySensorEntity AmbilightButton => new(_haContext, "binary_sensor.ambilight_button");
		///<summary>Back Corner Motion</summary>
		public BinarySensorEntity BackCornerMotion => new(_haContext, "binary_sensor.back_corner_motion");
		///<summary>Back Door Motion</summary>
		public BinarySensorEntity BackDoorMotion => new(_haContext, "binary_sensor.back_door_motion");
		///<summary>Back Door Sensor_contact</summary>
		public BinarySensorEntity BackDoorSensorContact => new(_haContext, "binary_sensor.back_door_sensor_contact");
		///<summary>Back Garden Motion occupancy</summary>
		public BinarySensorEntity BackGardenMotionOccupancy => new(_haContext, "binary_sensor.back_garden_motion_occupancy");
		///<summary>Back Garden Motion update available</summary>
		public BinarySensorEntity BackGardenMotionUpdateAvailable => new(_haContext, "binary_sensor.back_garden_motion_update_available");
		///<summary>Back Nut Hut Lid_contact</summary>
		public BinarySensorEntity BackNutHutLidContact => new(_haContext, "binary_sensor.back_nut_hut_lid_contact");
		///<summary>Bathroom Colour Light Switch contact</summary>
		public BinarySensorEntity BathroomColourLightSwitchContact => new(_haContext, "binary_sensor.bathroom_colour_light_switch_contact");
		///<summary>Bathroom Window Sensor_contact</summary>
		public BinarySensorEntity BathroomWindowSensorContact => new(_haContext, "binary_sensor.bathroom_window_sensor_contact");
		///<summary>Bed Sensor</summary>
		public BinarySensorEntity BedSensor => new(_haContext, "binary_sensor.bed_sensor");
		///<summary>Bedroom Window Sensor One_contact</summary>
		public BinarySensorEntity BedroomWindowSensorOneContact => new(_haContext, "binary_sensor.bedroom_window_sensor_one_contact");
		///<summary>Bedroom Window Sensor Two_contact</summary>
		public BinarySensorEntity BedroomWindowSensorTwoContact => new(_haContext, "binary_sensor.bedroom_window_sensor_two_contact");
		///<summary>Bottom Left</summary>
		public BinarySensorEntity BottomLeft => new(_haContext, "binary_sensor.bottom_left");
		///<summary>Bottom Right</summary>
		public BinarySensorEntity BottomRight => new(_haContext, "binary_sensor.bottom_right");
		///<summary>Bridge Motion</summary>
		public BinarySensorEntity BridgeMotion => new(_haContext, "binary_sensor.bridge_motion");
		///<summary>Button Moon Router led</summary>
		public BinarySensorEntity ButtonMoonRouterLed => new(_haContext, "binary_sensor.button_moon_router_led");
		///<summary>Castle Motion occupancy</summary>
		public BinarySensorEntity CastleMotionOccupancy => new(_haContext, "binary_sensor.castle_motion_occupancy");
		///<summary>Castle Motion update available</summary>
		public BinarySensorEntity CastleMotionUpdateAvailable => new(_haContext, "binary_sensor.castle_motion_update_available");
		///<summary>Cricket-One Firmware Updates Available</summary>
		public BinarySensorEntity CricketOneFirmwareUpdatesAvailable => new(_haContext, "binary_sensor.cricket_one_firmware_updates_available");
		///<summary>Cricket-One Pending Notices Present</summary>
		public BinarySensorEntity CricketOnePendingNoticesPresent => new(_haContext, "binary_sensor.cricket_one_pending_notices_present");
		///<summary>Front Castle Motion</summary>
		public BinarySensorEntity FrontCastleMotion => new(_haContext, "binary_sensor.front_castle_motion");
		///<summary>Front Door Motion</summary>
		public BinarySensorEntity FrontDoorMotion => new(_haContext, "binary_sensor.front_door_motion");
		///<summary>Front Door Sensor contact</summary>
		public BinarySensorEntity FrontDoorSensorContact => new(_haContext, "binary_sensor.front_door_sensor_contact");
		///<summary>Front Gate Motion occupancy</summary>
		public BinarySensorEntity FrontGateMotionOccupancy => new(_haContext, "binary_sensor.front_gate_motion_occupancy");
		///<summary>Front Gate Motion update available</summary>
		public BinarySensorEntity FrontGateMotionUpdateAvailable => new(_haContext, "binary_sensor.front_gate_motion_update_available");
		///<summary>Front Nut Hut Lid_contact</summary>
		public BinarySensorEntity FrontNutHutLidContact => new(_haContext, "binary_sensor.front_nut_hut_lid_contact");
		///<summary>Garage Door Sensor contact</summary>
		public BinarySensorEntity GarageDoorSensorContact => new(_haContext, "binary_sensor.garage_door_sensor_contact");
		///<summary>Garage Roof Motion</summary>
		public BinarySensorEntity GarageRoofMotion => new(_haContext, "binary_sensor.garage_roof_motion");
		///<summary>Garage Roof Motion occupancy</summary>
		public BinarySensorEntity GarageRoofMotionOccupancy => new(_haContext, "binary_sensor.garage_roof_motion_occupancy");
		///<summary>Garage Roof Motion update available</summary>
		public BinarySensorEntity GarageRoofMotionUpdateAvailable => new(_haContext, "binary_sensor.garage_roof_motion_update_available");
		///<summary>Hallway Light Switch One_contact</summary>
		public BinarySensorEntity HallwayLightSwitchOneContact => new(_haContext, "binary_sensor.hallway_light_switch_one_contact");
		///<summary>heart-of-gold_server</summary>
		public BinarySensorEntity HeartOfGoldServer => new(_haContext, "binary_sensor.heart_of_gold_server");
		///<summary>heart-of-gold_VM_blazor_dev_environment_USB_asustek_computer_aura_led_controller_connected</summary>
		public BinarySensorEntity HeartOfGoldVmBlazorDevEnvironmentUsbAsustekComputerAuraLedControllerConnected => new(_haContext, "binary_sensor.heart_of_gold_vm_blazor_dev_environment_usb_asustek_computer_aura_led_controller_connected");
		///<summary>heart-of-gold_VM_blazor_dev_environment_USB_cooler_master_technology_inc_amd_sr4_lamplight_control_connected</summary>
		public BinarySensorEntity HeartOfGoldVmBlazorDevEnvironmentUsbCoolerMasterTechnologyIncAmdSr4LamplightControlConnected => new(_haContext, "binary_sensor.heart_of_gold_vm_blazor_dev_environment_usb_cooler_master_technology_inc_amd_sr4_lamplight_control_connected");
		///<summary>heart-of-gold_VM_blazor_dev_environment_USB_intel_corp_connected</summary>
		public BinarySensorEntity HeartOfGoldVmBlazorDevEnvironmentUsbIntelCorpConnected => new(_haContext, "binary_sensor.heart_of_gold_vm_blazor_dev_environment_usb_intel_corp_connected");
		///<summary>heart-of-gold_VM_ubuntu_USB_asustek_computer_aura_led_controller_connected</summary>
		public BinarySensorEntity HeartOfGoldVmUbuntuUsbAsustekComputerAuraLedControllerConnected => new(_haContext, "binary_sensor.heart_of_gold_vm_ubuntu_usb_asustek_computer_aura_led_controller_connected");
		///<summary>heart-of-gold_VM_ubuntu_USB_cooler_master_technology_inc_amd_sr4_lamplight_control_connected</summary>
		public BinarySensorEntity HeartOfGoldVmUbuntuUsbCoolerMasterTechnologyIncAmdSr4LamplightControlConnected => new(_haContext, "binary_sensor.heart_of_gold_vm_ubuntu_usb_cooler_master_technology_inc_amd_sr4_lamplight_control_connected");
		///<summary>heart-of-gold_VM_ubuntu_USB_intel_corp_connected</summary>
		public BinarySensorEntity HeartOfGoldVmUbuntuUsbIntelCorpConnected => new(_haContext, "binary_sensor.heart_of_gold_vm_ubuntu_usb_intel_corp_connected");
		///<summary>iPad Focus</summary>
		public BinarySensorEntity IpadFocus => new(_haContext, "binary_sensor.ipad_focus");
		///<summary>Kaggi II mop attached</summary>
		public BinarySensorEntity KaggiIiMopAttached => new(_haContext, "binary_sensor.kaggi_ii_mop_attached");
		///<summary>KingSquigglePad App Inactive</summary>
		public BinarySensorEntity KingsquigglepadAppInactive => new(_haContext, "binary_sensor.kingsquigglepad_app_inactive");
		///<summary>KingSquigglePad Bluetooth State</summary>
		public BinarySensorEntity KingsquigglepadBluetoothState => new(_haContext, "binary_sensor.kingsquigglepad_bluetooth_state");
		///<summary>KingSquigglePad Device Locked</summary>
		public BinarySensorEntity KingsquigglepadDeviceLocked => new(_haContext, "binary_sensor.kingsquigglepad_device_locked");
		///<summary>KingSquigglePad Device Secure</summary>
		public BinarySensorEntity KingsquigglepadDeviceSecure => new(_haContext, "binary_sensor.kingsquigglepad_device_secure");
		///<summary>KingSquigglePad Doze Mode</summary>
		public BinarySensorEntity KingsquigglepadDozeMode => new(_haContext, "binary_sensor.kingsquigglepad_doze_mode");
		///<summary>KingSquigglePad Headphones</summary>
		public BinarySensorEntity KingsquigglepadHeadphones => new(_haContext, "binary_sensor.kingsquigglepad_headphones");
		///<summary>KingSquigglePad High Accuracy Mode</summary>
		public BinarySensorEntity KingsquigglepadHighAccuracyMode => new(_haContext, "binary_sensor.kingsquigglepad_high_accuracy_mode");
		///<summary>KingSquigglePad Interactive</summary>
		public BinarySensorEntity KingsquigglepadInteractive => new(_haContext, "binary_sensor.kingsquigglepad_interactive");
		///<summary>KingSquigglePad Is Charging</summary>
		public BinarySensorEntity KingsquigglepadIsCharging => new(_haContext, "binary_sensor.kingsquigglepad_is_charging");
		///<summary>KingSquigglePad Keyguard Locked</summary>
		public BinarySensorEntity KingsquigglepadKeyguardLocked => new(_haContext, "binary_sensor.kingsquigglepad_keyguard_locked");
		///<summary>KingSquigglePad Keyguard Secure</summary>
		public BinarySensorEntity KingsquigglepadKeyguardSecure => new(_haContext, "binary_sensor.kingsquigglepad_keyguard_secure");
		///<summary>KingSquigglePad Mic Muted</summary>
		public BinarySensorEntity KingsquigglepadMicMuted => new(_haContext, "binary_sensor.kingsquigglepad_mic_muted");
		///<summary>KingSquigglePad Mobile Data</summary>
		public BinarySensorEntity KingsquigglepadMobileData => new(_haContext, "binary_sensor.kingsquigglepad_mobile_data");
		///<summary>KingSquigglePad Mobile Data Roaming</summary>
		public BinarySensorEntity KingsquigglepadMobileDataRoaming => new(_haContext, "binary_sensor.kingsquigglepad_mobile_data_roaming");
		///<summary>KingSquigglePad Music Active</summary>
		public BinarySensorEntity KingsquigglepadMusicActive => new(_haContext, "binary_sensor.kingsquigglepad_music_active");
		///<summary>KingSquigglePad Power Save</summary>
		public BinarySensorEntity KingsquigglepadPowerSave => new(_haContext, "binary_sensor.kingsquigglepad_power_save");
		///<summary>KingSquigglePad Speakerphone</summary>
		public BinarySensorEntity KingsquigglepadSpeakerphone => new(_haContext, "binary_sensor.kingsquigglepad_speakerphone");
		///<summary>KingSquigglePad WiFi State</summary>
		public BinarySensorEntity KingsquigglepadWifiState => new(_haContext, "binary_sensor.kingsquigglepad_wifi_state");
		///<summary>Kitchen Mouse Trap contact</summary>
		public BinarySensorEntity KitchenMouseTrap => new(_haContext, "binary_sensor.kitchen_mouse_trap");
		///<summary>Kitchen Tree Button</summary>
		public BinarySensorEntity KitchenTreeButton => new(_haContext, "binary_sensor.kitchen_tree_button");
		///<summary>Kitchen Window Sensor contact</summary>
		public BinarySensorEntity KitchenWindowSensorContact => new(_haContext, "binary_sensor.kitchen_window_sensor_contact");
		///<summary>Livingroom Curtain update available</summary>
		public BinarySensorEntity LivingroomCurtainUpdateAvailable => new(_haContext, "binary_sensor.livingroom_curtain_update_available");
		///<summary>Livingroom Light Switch One contact</summary>
		public BinarySensorEntity LivingroomLightSwitchOneContact => new(_haContext, "binary_sensor.livingroom_light_switch_one_contact");
		///<summary>Livingroom Window One Sensor contact</summary>
		public BinarySensorEntity LivingroomWindowOneSensorContact => new(_haContext, "binary_sensor.livingroom_window_one_sensor_contact");
		///<summary>Livingroom Window Two Sensor contact</summary>
		public BinarySensorEntity LivingroomWindowTwoSensorContact => new(_haContext, "binary_sensor.livingroom_window_two_sensor_contact");
		///<summary>LivingroomWLED Firmware</summary>
		public BinarySensorEntity LivingroomwledFirmware => new(_haContext, "binary_sensor.livingroomwled_firmware");
		///<summary>Manager Test</summary>
		public BinarySensorEntity ManagerTest => new(_haContext, "binary_sensor.manager_test");
		///<summary>Monitors Button</summary>
		public BinarySensorEntity MonitorsButton => new(_haContext, "binary_sensor.monitors_button");
		///<summary>Mr Spoon Router led</summary>
		public BinarySensorEntity MrSpoonRouterLed => new(_haContext, "binary_sensor.mr_spoon_router_led");
		///<summary>MultiSensor 6: Home Security - Motion detection</summary>
		public BinarySensorEntity Multisensor6HomeSecurityMotionDetection => new(_haContext, "binary_sensor.multisensor_6_home_security_motion_detection");
		///<summary>MultiSensor 6: Home Security - Tampering, product cover removed</summary>
		public BinarySensorEntity Multisensor6HomeSecurityTamperingProductCoverRemoved => new(_haContext, "binary_sensor.multisensor_6_home_security_tampering_product_cover_removed");
		///<summary>MultiSensor 6: Low battery level</summary>
		public BinarySensorEntity Multisensor6LowBatteryLevel => new(_haContext, "binary_sensor.multisensor_6_low_battery_level");
		///<summary>Office Mouse Trap contact</summary>
		public BinarySensorEntity OfficeMouseTrap => new(_haContext, "binary_sensor.office_mouse_trap");
		///<summary>Office Switch One_contact</summary>
		public BinarySensorEntity OfficeSwitchOneContact => new(_haContext, "binary_sensor.office_switch_one_contact");
		///<summary>Office Switch Two_contact</summary>
		public BinarySensorEntity OfficeSwitchTwoContact => new(_haContext, "binary_sensor.office_switch_two_contact");
		///<summary>Office Window Sensor One Contact</summary>
		public BinarySensorEntity OfficeWindowSensorOneContact => new(_haContext, "binary_sensor.office_window_sensor_one_contact");
		///<summary>Office Window Sensor Two_contact</summary>
		public BinarySensorEntity OfficeWindowSensorTwoContact => new(_haContext, "binary_sensor.office_window_sensor_two_contact");
		///<summary>Palace Front Door contact</summary>
		public BinarySensorEntity PalaceFrontDoorContact => new(_haContext, "binary_sensor.palace_front_door_contact");
		///<summary>Palace Motion</summary>
		public BinarySensorEntity PalaceMotion => new(_haContext, "binary_sensor.palace_motion");
		///<summary>Remote UI</summary>
		public BinarySensorEntity RemoteUi => new(_haContext, "binary_sensor.remote_ui");
		///<summary>Samsung CLX-3300 Series</summary>
		public BinarySensorEntity SamsungClx3300Series => new(_haContext, "binary_sensor.samsung_clx_3300_series");
		///<summary>Samsung CLX-3300 Series</summary>
		public BinarySensorEntity SamsungClx3300Series2 => new(_haContext, "binary_sensor.samsung_clx_3300_series_2");
		///<summary>Server Fan button</summary>
		public BinarySensorEntity ServerFanButton => new(_haContext, "binary_sensor.server_fan_button");
		///<summary>Server Fan Running</summary>
		public BinarySensorEntity ServerFanRunning => new(_haContext, "binary_sensor.server_fan_running");
		///<summary>Skylight Window Contact contact</summary>
		public BinarySensorEntity SkylightWindowContactContact => new(_haContext, "binary_sensor.skylight_window_contact_contact");
		///<summary>Slow Cooker Button</summary>
		public BinarySensorEntity SlowCookerButton => new(_haContext, "binary_sensor.slow_cooker_button");
		///<summary>BigSquigglePad is Charging</summary>
		public BinarySensorEntity SmT870IsCharging => new(_haContext, "binary_sensor.sm_t870_is_charging");
		///<summary>Small Squiggle Pad Is Charging</summary>
		public BinarySensorEntity SmallSquigglePadIsCharging => new(_haContext, "binary_sensor.small_squiggle_pad_is_charging");
		///<summary>SmallSquigglePad Is Charging</summary>
		public BinarySensorEntity SmallsquigglepadIsCharging => new(_haContext, "binary_sensor.smallsquigglepad_is_charging");
		///<summary>Snapshots Stale</summary>
		public BinarySensorEntity SnapshotsStale => new(_haContext, "binary_sensor.snapshots_stale");
		public BinarySensorEntity SonoffBasicButton => new(_haContext, "binary_sensor.sonoff_basic_button");
		///<summary>Sonoff POW Button</summary>
		public BinarySensorEntity SonoffPowButton => new(_haContext, "binary_sensor.sonoff_pow_button");
		///<summary>SquigglePad Is Charging</summary>
		public BinarySensorEntity SquigglepadIsCharging => new(_haContext, "binary_sensor.squigglepad_is_charging");
		///<summary>SquigglePhone Is Charging</summary>
		public BinarySensorEntity SquigglephoneIsCharging => new(_haContext, "binary_sensor.squigglephone_is_charging");
		///<summary>Squiggley Couch contact</summary>
		public BinarySensorEntity SquiggleyCouchContact => new(_haContext, "binary_sensor.squiggley_couch_contact");
		///<summary>Squiggley Nightlight Motion Sensor_occupancy</summary>
		public BinarySensorEntity SquiggleyNightlightMotionSensorOccupancy => new(_haContext, "binary_sensor.squiggley_nightlight_motion_sensor_occupancy");
		///<summary>Squiggley oan da couch</summary>
		public BinarySensorEntity SquiggleyOanDaCouch => new(_haContext, "binary_sensor.squiggley_oan_da_couch");
		///<summary>Squiggley Wardrobe Door Sensor contact</summary>
		public BinarySensorEntity SquiggleyWardrobeDoorSensorContact => new(_haContext, "binary_sensor.squiggley_wardrobe_door_sensor_contact");
		///<summary>Stair Light Switch One_contact</summary>
		public BinarySensorEntity StairLightSwitchOneContact => new(_haContext, "binary_sensor.stair_light_switch_one_contact");
		///<summary>Stair Light Switch Two_contact</summary>
		public BinarySensorEntity StairLightSwitchTwoContact => new(_haContext, "binary_sensor.stair_light_switch_two_contact");
		///<summary>Stairs Window Sensor contact</summary>
		public BinarySensorEntity StairsWindowSensorContact => new(_haContext, "binary_sensor.stairs_window_sensor_contact");
		///<summary>Toilet Door Sensor</summary>
		public BinarySensorEntity ToiletDoorSensorContact => new(_haContext, "binary_sensor.toilet_door_sensor_contact");
		///<summary>Toilet Light Switch_contact</summary>
		public BinarySensorEntity ToiletLightSwitchContact => new(_haContext, "binary_sensor.toilet_light_switch_contact");
		///<summary>Toilet Motion Sensor_occupancy</summary>
		public BinarySensorEntity ToiletMotionSensorOccupancy => new(_haContext, "binary_sensor.toilet_motion_sensor_occupancy");
		///<summary>Toilet Mouse Trap contact</summary>
		public BinarySensorEntity ToiletMouseTrap => new(_haContext, "binary_sensor.toilet_mouse_trap");
		///<summary>Toilet Window Sensor_contact</summary>
		public BinarySensorEntity ToiletWindowSensorContact => new(_haContext, "binary_sensor.toilet_window_sensor_contact");
		///<summary>Top Left</summary>
		public BinarySensorEntity TopLeft => new(_haContext, "binary_sensor.top_left");
		///<summary>Top Right</summary>
		public BinarySensorEntity TopRight => new(_haContext, "binary_sensor.top_right");
		///<summary>Updater</summary>
		public BinarySensorEntity Updater => new(_haContext, "binary_sensor.updater");
		///<summary>Vestibule Light Switch One_contact</summary>
		public BinarySensorEntity VestibuleLightSwitchOneContact => new(_haContext, "binary_sensor.vestibule_light_switch_one_contact");
		///<summary>Vestibule Motion Sensor_occupancy</summary>
		public BinarySensorEntity VestibuleMotionSensorOccupancy => new(_haContext, "binary_sensor.vestibule_motion_sensor_occupancy");
		///<summary>Wee Bear Couch contact</summary>
		public BinarySensorEntity WeeBearCouchContact => new(_haContext, "binary_sensor.wee_bear_couch_contact");
		///<summary>Wee Bear Nightlight Motion Sensor_occupancy</summary>
		public BinarySensorEntity WeeBearNightlightMotionSensorOccupancy => new(_haContext, "binary_sensor.wee_bear_nightlight_motion_sensor_occupancy");
		///<summary>Wee Bear oan da couch</summary>
		public BinarySensorEntity WeeBearOanDaCouch => new(_haContext, "binary_sensor.wee_bear_oan_da_couch");
		///<summary>wee bear wardrobe door one contact</summary>
		public BinarySensorEntity WeeBearWardrobeDoorOneContact => new(_haContext, "binary_sensor.wee_bear_wardrobe_door_one_contact");
		///<summary>wee bear wardrobe door three contact</summary>
		public BinarySensorEntity WeeBearWardrobeDoorThreeContact => new(_haContext, "binary_sensor.wee_bear_wardrobe_door_three_contact");
		///<summary>wee bear wardrobe door two contact</summary>
		public BinarySensorEntity WeeBearWardrobeDoorTwoContact => new(_haContext, "binary_sensor.wee_bear_wardrobe_door_two_contact");
		///<summary>Wee Bear Window Sensor One_contact</summary>
		public BinarySensorEntity WeeBearWindowSensorOneContact => new(_haContext, "binary_sensor.wee_bear_window_sensor_one_contact");
		///<summary>Wee Bear Window Sensor Two_contact</summary>
		public BinarySensorEntity WeeBearWindowSensorTwoContact => new(_haContext, "binary_sensor.wee_bear_window_sensor_two_contact");
		///<summary>Workday Sensor</summary>
		public BinarySensorEntity WorkdaySensor => new(_haContext, "binary_sensor.workday_sensor");
		///<summary>ZaphodWLED Firmware</summary>
		public BinarySensorEntity ZaphodwledFirmware => new(_haContext, "binary_sensor.zaphodwled_firmware");
	}

	public class ButtonEntities
	{
		private readonly IHaContext _haContext;
		public ButtonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Back Climbing Reboot</summary>
		public ButtonEntity BackClimbingReboot => new(_haContext, "button.back_climbing_reboot");
		///<summary>Back Door Reboot</summary>
		public ButtonEntity BackDoorReboot => new(_haContext, "button.back_door_reboot");
		///<summary>Front Climbing Reboot</summary>
		public ButtonEntity FrontClimbingReboot => new(_haContext, "button.front_climbing_reboot");
		///<summary>Front Garden Reboot</summary>
		public ButtonEntity FrontGardenReboot => new(_haContext, "button.front_garden_reboot");
		///<summary>Garage Roof Reboot</summary>
		public ButtonEntity GarageRoofReboot => new(_haContext, "button.garage_roof_reboot");
		///<summary>Kaggi II life span brush reset</summary>
		public ButtonEntity KaggiIiLifeSpanBrushReset => new(_haContext, "button.kaggi_ii_life_span_brush_reset");
		///<summary>Kaggi II life span filter reset</summary>
		public ButtonEntity KaggiIiLifeSpanFilterReset => new(_haContext, "button.kaggi_ii_life_span_filter_reset");
		///<summary>Kaggi II life span side brush reset</summary>
		public ButtonEntity KaggiIiLifeSpanSideBrushReset => new(_haContext, "button.kaggi_ii_life_span_side_brush_reset");
		///<summary>Kaggi II relocate</summary>
		public ButtonEntity KaggiIiRelocate => new(_haContext, "button.kaggi_ii_relocate");
		///<summary>LivingroomWLED Restart</summary>
		public ButtonEntity LivingroomwledRestart => new(_haContext, "button.livingroomwled_restart");
		///<summary>LivingroomWLED Update</summary>
		public ButtonEntity LivingroomwledUpdate => new(_haContext, "button.livingroomwled_update");
		///<summary>MultiSensor 6: Ping</summary>
		public ButtonEntity Multisensor6Ping => new(_haContext, "button.multisensor_6_ping");
		///<summary>Scan Clients (Heart-Of-Gold)</summary>
		public ButtonEntity ScanClientsHeartOfGold => new(_haContext, "button.scan_clients_heart_of_gold");
		///<summary>ZaphodWLED Restart</summary>
		public ButtonEntity ZaphodwledRestart => new(_haContext, "button.zaphodwled_restart");
		///<summary>ZaphodWLED Update</summary>
		public ButtonEntity ZaphodwledUpdate => new(_haContext, "button.zaphodwled_update");
	}

	public class CalendarEntities
	{
		private readonly IHaContext _haContext;
		public CalendarEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Garbage Collection</summary>
		public CalendarEntity GarbageCollection => new(_haContext, "calendar.garbage_collection");
	}

	public class CameraEntities
	{
		private readonly IHaContext _haContext;
		public CameraEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Back Climbing - Profile000_MainStream</summary>
		public CameraEntity BackClimbingProfile000Mainstream => new(_haContext, "camera.back_climbing_profile000_mainstream");
		///<summary>Back Climbing - Profile000_MainStream</summary>
		public CameraEntity BackClimbingProfile000Mainstream2 => new(_haContext, "camera.back_climbing_profile000_mainstream_2");
		///<summary>Back Door - Profile000_MainStream</summary>
		public CameraEntity BackDoorProfile000Mainstream => new(_haContext, "camera.back_door_profile000_mainstream");
		///<summary>Back Door - Profile000_MainStream</summary>
		public CameraEntity BackDoorProfile000Mainstream2 => new(_haContext, "camera.back_door_profile000_mainstream_2");
		///<summary>Back Door - Profile001_SubStream</summary>
		public CameraEntity BackDoorProfile001Substream => new(_haContext, "camera.back_door_profile001_substream");
		///<summary>Zaphod Hyperion Instance</summary>
		public CameraEntity FirstLedHardwareInstance => new(_haContext, "camera.first_led_hardware_instance");
		///<summary>Front Climbing - Profile000_MainStream</summary>
		public CameraEntity FrontClimbingProfile000Mainstream2 => new(_haContext, "camera.front_climbing_profile000_mainstream_2");
		///<summary>Front Door</summary>
		public CameraEntity FrontDoor => new(_haContext, "camera.front_door");
		///<summary>Front Garden - Profile000_MainStream</summary>
		public CameraEntity FrontGardenProfile000Mainstream2 => new(_haContext, "camera.front_garden_profile000_mainstream_2");
		///<summary>Garage Roof - Profile000_MainStream</summary>
		public CameraEntity GarageRoofProfile000Mainstream => new(_haContext, "camera.garage_roof_profile000_mainstream");
		///<summary>Kaggi II live map</summary>
		public CameraEntity KaggiIiLiveMap => new(_haContext, "camera.kaggi_ii_live_map");
	}

	public class ClimateEntities
	{
		private readonly IHaContext _haContext;
		public ClimateEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bathroom</summary>
		public ClimateEntity Bathroom => new(_haContext, "climate.bathroom");
		///<summary>bedroom</summary>
		public ClimateEntity Bedroom => new(_haContext, "climate.bedroom");
		///<summary>Kitchen</summary>
		public ClimateEntity Kitchen => new(_haContext, "climate.kitchen");
		///<summary>Livingroom</summary>
		public ClimateEntity Livingroom => new(_haContext, "climate.livingroom");
		///<summary>Office</summary>
		public ClimateEntity Office => new(_haContext, "climate.office");
		///<summary>Vestibule</summary>
		public ClimateEntity Vestibule => new(_haContext, "climate.vestibule");
		///<summary>Wee Bear</summary>
		public ClimateEntity Weebear => new(_haContext, "climate.weebear");
	}

	public class CoverEntities
	{
		private readonly IHaContext _haContext;
		public CoverEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Livingroom Curtain</summary>
		public CoverEntity LivingroomCurtain => new(_haContext, "cover.livingroom_curtain");
	}

	public class DeviceTrackerEntities
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Wee Bear</summary>
		public DeviceTrackerEntity ClairesIphone => new(_haContext, "device_tracker.claires_iphone");
		///<summary>iPad</summary>
		public DeviceTrackerEntity Ipad => new(_haContext, "device_tracker.ipad");
		///<summary>KingSquigglePad</summary>
		public DeviceTrackerEntity Kingsquigglepad => new(_haContext, "device_tracker.kingsquigglepad");
		///<summary>Kitchen_Tablet</summary>
		public DeviceTrackerEntity KitchenTablet => new(_haContext, "device_tracker.kitchen_tablet");
		///<summary>SHIELD_Tablet_K1</summary>
		public DeviceTrackerEntity ShieldTabletK1 => new(_haContext, "device_tracker.shield_tablet_k1");
		///<summary>BigSquigglePad</summary>
		public DeviceTrackerEntity SmT870 => new(_haContext, "device_tracker.sm_t870");
		///<summary>Small Squiggle Pad</summary>
		public DeviceTrackerEntity SmallSquigglePad => new(_haContext, "device_tracker.small_squiggle_pad");
		///<summary>SmallSquigglePad</summary>
		public DeviceTrackerEntity Smallsquigglepad => new(_haContext, "device_tracker.smallsquigglepad");
		///<summary>Squiggley</summary>
		public DeviceTrackerEntity Squigglepad => new(_haContext, "device_tracker.squigglepad");
		///<summary>Squiggley</summary>
		public DeviceTrackerEntity Squigglephone => new(_haContext, "device_tracker.squigglephone");
	}

	public class GroupEntities
	{
		private readonly IHaContext _haContext;
		public GroupEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>All Garden Lights</summary>
		public GroupEntity AllGardenLights => new(_haContext, "group.all_garden_lights");
		///<summary>All Lights</summary>
		public GroupEntity AllLights => new(_haContext, "group.all_lights");
		///<summary>Common Lights</summary>
		public GroupEntity CommonLights => new(_haContext, "group.common_lights");
		///<summary>Downstairs Lights</summary>
		public GroupEntity DownstairsLights => new(_haContext, "group.downstairs_lights");
		///<summary>Exterior Doors</summary>
		public GroupEntity ExteriorDoors => new(_haContext, "group.exterior_doors");
		///<summary>Exterior Windows</summary>
		public GroupEntity ExteriorWindows => new(_haContext, "group.exterior_windows");
		///<summary>Heating Check Doors</summary>
		public GroupEntity HeatingCheckDoors => new(_haContext, "group.heating_check_doors");
		///<summary>Inside Xmas Lights</summary>
		public GroupEntity InsideXmasLights => new(_haContext, "group.inside_xmas_lights");
		///<summary>Outside Xmas Lights</summary>
		public GroupEntity OutsideXmasLights => new(_haContext, "group.outside_xmas_lights");
		///<summary>Upstairs lights</summary>
		public GroupEntity UpstairsLights => new(_haContext, "group.upstairs_lights");
	}

	public class HumidifierEntities
	{
		private readonly IHaContext _haContext;
		public HumidifierEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Squiggley Smells</summary>
		public HumidifierEntity SquiggleySmells => new(_haContext, "humidifier.squiggley_smells");
	}

	public class InputBooleanEntities
	{
		private readonly IHaContext _haContext;
		public InputBooleanEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Accuweather Logging</summary>
		public InputBooleanEntity AccuweatherLogging => new(_haContext, "input_boolean.accuweather_logging");
		///<summary>Curtain Calibration</summary>
		public InputBooleanEntity ActivateCurtainCalibration => new(_haContext, "input_boolean.activate_curtain_calibration");
		///<summary>Airvisual Logging</summary>
		public InputBooleanEntity AirvisualLogging => new(_haContext, "input_boolean.airvisual_logging");
		///<summary>Alarm_Control Panel Logging</summary>
		public InputBooleanEntity AlarmControlPanelLogging => new(_haContext, "input_boolean.alarm_control_panel_logging");
		///<summary>Alarm Logging</summary>
		public InputBooleanEntity AlarmLogging => new(_haContext, "input_boolean.alarm_logging");
		///<summary>Alert Logging</summary>
		public InputBooleanEntity AlertLogging => new(_haContext, "input_boolean.alert_logging");
		///<summary>Automation Logging</summary>
		public InputBooleanEntity AutomationLogging => new(_haContext, "input_boolean.automation_logging");
		///<summary>Bathroom Schedule Active</summary>
		public InputBooleanEntity BathroomScheduleActive => new(_haContext, "input_boolean.bathroom_schedule_active");
		///<summary>Bedroom Schedule Active</summary>
		public InputBooleanEntity BedroomScheduleActive => new(_haContext, "input_boolean.bedroom_schedule_active");
		///<summary>Bedroom Squirrel Notifications</summary>
		public InputBooleanEntity BedroomSquirrelNotifications => new(_haContext, "input_boolean.bedroom_squirrel_notifications");
		///<summary>Binary Sensor Logging</summary>
		public InputBooleanEntity BinarySensorLogging => new(_haContext, "input_boolean.binary_sensor_logging");
		///<summary>Boost Bathroom Heating</summary>
		public InputBooleanEntity BoostBathroomHeating => new(_haContext, "input_boolean.boost_bathroom_heating");
		///<summary>Boost Bedroom Heating</summary>
		public InputBooleanEntity BoostBedroomHeating => new(_haContext, "input_boolean.boost_bedroom_heating");
		///<summary>Boost Kitchen Heating</summary>
		public InputBooleanEntity BoostKitchenHeating => new(_haContext, "input_boolean.boost_kitchen_heating");
		///<summary>Boost Livingroom Heating</summary>
		public InputBooleanEntity BoostLivingroomHeating => new(_haContext, "input_boolean.boost_livingroom_heating");
		///<summary>Boost Office Heating</summary>
		public InputBooleanEntity BoostOfficeHeating => new(_haContext, "input_boolean.boost_office_heating");
		///<summary>Boost Vestibule Heating</summary>
		public InputBooleanEntity BoostVestibuleHeating => new(_haContext, "input_boolean.boost_vestibule_heating");
		///<summary>Boost wee_bear Heating</summary>
		public InputBooleanEntity BoostWeebearHeating => new(_haContext, "input_boolean.boost_weebear_heating");
		///<summary>Broadlink Logging</summary>
		public InputBooleanEntity BroadlinkLogging => new(_haContext, "input_boolean.broadlink_logging");
		///<summary>Car Defrost timer</summary>
		public InputBooleanEntity CarDefrostTimer => new(_haContext, "input_boolean.car_defrost_timer");
		///<summary>Certificate Expiry Logging</summary>
		public InputBooleanEntity CertExpiryLogging => new(_haContext, "input_boolean.cert_expiry_logging");
		///<summary>Circadian Lighting</summary>
		public InputBooleanEntity CircadianLighting => new(_haContext, "input_boolean.circadian_lighting");
		///<summary>Climate Logging</summary>
		public InputBooleanEntity ClimateLogging => new(_haContext, "input_boolean.climate_logging");
		///<summary>Cloudflare Logging</summary>
		public InputBooleanEntity CloudflareLogging => new(_haContext, "input_boolean.cloudflare_logging");
		///<summary>Core Logging</summary>
		public InputBooleanEntity CoreLogging => new(_haContext, "input_boolean.core_logging");
		///<summary>Cover Logging</summary>
		public InputBooleanEntity CoverLogging => new(_haContext, "input_boolean.cover_logging");
		///<summary>Dark Outside</summary>
		public InputBooleanEntity DarkOutside => new(_haContext, "input_boolean.dark_outside");
		///<summary>Bathroom</summary>
		public InputBooleanEntity DeebotBathroom => new(_haContext, "input_boolean.deebot_bathroom");
		///<summary>Bedroom</summary>
		public InputBooleanEntity DeebotBedroom => new(_haContext, "input_boolean.deebot_bedroom");
		///<summary>Hallway</summary>
		public InputBooleanEntity DeebotHallway => new(_haContext, "input_boolean.deebot_hallway");
		///<summary>Kitchen</summary>
		public InputBooleanEntity DeebotKitchen => new(_haContext, "input_boolean.deebot_kitchen");
		///<summary>Living Room</summary>
		public InputBooleanEntity DeebotLivingroom => new(_haContext, "input_boolean.deebot_livingroom");
		///<summary>Office</summary>
		public InputBooleanEntity DeebotOffice => new(_haContext, "input_boolean.deebot_office");
		///<summary>Toilet</summary>
		public InputBooleanEntity DeebotToilet => new(_haContext, "input_boolean.deebot_toilet");
		///<summary>Vestibule</summary>
		public InputBooleanEntity DeebotVestibule => new(_haContext, "input_boolean.deebot_vestibule");
		///<summary>Wee Bear</summary>
		public InputBooleanEntity DeebotWeeBear => new(_haContext, "input_boolean.deebot_wee_bear");
		///<summary>Development Mode</summary>
		public InputBooleanEntity DevMode => new(_haContext, "input_boolean.dev_mode");
		///<summary>dev_netdaemon_apps_concurrency_test_app</summary>
		public InputBooleanEntity DevNetdaemonAppsConcurrencyTestApp => new(_haContext, "input_boolean.dev_netdaemon_apps_concurrency_test_app");
		///<summary>dev_netdaemon_apps_concurrency_test_app2</summary>
		public InputBooleanEntity DevNetdaemonAppsConcurrencyTestApp2 => new(_haContext, "input_boolean.dev_netdaemon_apps_concurrency_test_app2");
		///<summary>dev_netdaemon_apps_hello_app</summary>
		public InputBooleanEntity DevNetdaemonAppsHelloApp => new(_haContext, "input_boolean.dev_netdaemon_apps_hello_app");
		///<summary>dev_netdaemon_apps_yaml_app</summary>
		public InputBooleanEntity DevNetdaemonAppsYamlApp => new(_haContext, "input_boolean.dev_netdaemon_apps_yaml_app");
		///<summary>dev_netdaemon_debug_host_apps_extensions_mqtt_entity_manager_app</summary>
		public InputBooleanEntity DevNetdaemonDebugHostAppsExtensionsMqttEntityManagerApp => new(_haContext, "input_boolean.dev_netdaemon_debug_host_apps_extensions_mqtt_entity_manager_app");
		///<summary>dev_netdaemon_light_notification_flash_light_on_movement</summary>
		public InputBooleanEntity DevNetdaemonLightNotificationFlashLightOnMovement => new(_haContext, "input_boolean.dev_netdaemon_light_notification_flash_light_on_movement");
		///<summary>dev_netdaemon_net_daemon_apps_apps_light_notification_flash_light_on_movement</summary>
		public InputBooleanEntity DevNetdaemonNetDaemonAppsAppsLightNotificationFlashLightOnMovement => new(_haContext, "input_boolean.dev_netdaemon_net_daemon_apps_apps_light_notification_flash_light_on_movement");
		///<summary>dev_netdaemon_net_daemon_apps_apps_squiggley_apps_flash_light_on_movement</summary>
		public InputBooleanEntity DevNetdaemonNetDaemonAppsAppsSquiggleyAppsFlashLightOnMovement => new(_haContext, "input_boolean.dev_netdaemon_net_daemon_apps_apps_squiggley_apps_flash_light_on_movement");
		///<summary>dev_netdaemon_net_daemon_apps_apps_squiggley_apps_light_on_test</summary>
		public InputBooleanEntity DevNetdaemonNetDaemonAppsAppsSquiggleyAppsLightOnTest => new(_haContext, "input_boolean.dev_netdaemon_net_daemon_apps_apps_squiggley_apps_light_on_test");
		///<summary>Device Tracker Logging</summary>
		public InputBooleanEntity DeviceTrackerLogging => new(_haContext, "input_boolean.device_tracker_logging");
		///<summary>Door Bell Pressed</summary>
		public InputBooleanEntity DoorbellFlashLights => new(_haContext, "input_boolean.doorbell_flash_lights");
		///<summary>Enable Bathroom Schedule</summary>
		public InputBooleanEntity EnableBathroomSchedule => new(_haContext, "input_boolean.enable_bathroom_schedule");
		///<summary>Enable Bedroom Schedule</summary>
		public InputBooleanEntity EnableBedroomSchedule => new(_haContext, "input_boolean.enable_bedroom_schedule");
		///<summary>Enable Kitchen Schedule</summary>
		public InputBooleanEntity EnableKitchenSchedule => new(_haContext, "input_boolean.enable_kitchen_schedule");
		///<summary>Enable Livingroom Schedule</summary>
		public InputBooleanEntity EnableLivingroomSchedule => new(_haContext, "input_boolean.enable_livingroom_schedule");
		///<summary>Enable Office Schedule</summary>
		public InputBooleanEntity EnableOfficeSchedule => new(_haContext, "input_boolean.enable_office_schedule");
		///<summary>Enable Vestibule Schedule</summary>
		public InputBooleanEntity EnableVestibuleSchedule => new(_haContext, "input_boolean.enable_vestibule_schedule");
		///<summary>Enable wee_bear Schedule</summary>
		public InputBooleanEntity EnableWeebearSchedule => new(_haContext, "input_boolean.enable_weebear_schedule");
		///<summary>Entity Registry Logging</summary>
		public InputBooleanEntity EntityRegistryLogging => new(_haContext, "input_boolean.entity_registry_logging");
		///<summary>EspHome Logging</summary>
		public InputBooleanEntity EsphomeLogging => new(_haContext, "input_boolean.esphome_logging");
		///<summary>Everyone Sleeping</summary>
		public InputBooleanEntity EveryoneSleeping => new(_haContext, "input_boolean.everyone_sleeping");
		///<summary>Fan Logging</summary>
		public InputBooleanEntity FanLogging => new(_haContext, "input_boolean.fan_logging");
		///<summary>Dismiss Garden Bin</summary>
		public InputBooleanEntity GardenBinDismissed => new(_haContext, "input_boolean.garden_bin_dismissed");
		///<summary>GPS logger Logging</summary>
		public InputBooleanEntity GpsloggerLogging => new(_haContext, "input_boolean.gpslogger_logging");
		///<summary>Heatmiser Neo Logging</summary>
		public InputBooleanEntity HeatmiserneoLogging => new(_haContext, "input_boolean.heatmiserneo_logging");
		///<summary>History Logging</summary>
		public InputBooleanEntity HistoryLogging => new(_haContext, "input_boolean.history_logging");
		///<summary>Home Off</summary>
		public InputBooleanEntity HomeOff => new(_haContext, "input_boolean.home_off");
		///<summary>Http Logging</summary>
		public InputBooleanEntity HttpLogging => new(_haContext, "input_boolean.http_logging");
		///<summary>Hyperion Logging</summary>
		public InputBooleanEntity HyperionLogging => new(_haContext, "input_boolean.hyperion_logging");
		///<summary>Influx Logging</summary>
		public InputBooleanEntity InfluxLogging => new(_haContext, "input_boolean.influx_logging");
		///<summary>Influxdb Logging</summary>
		public InputBooleanEntity InfluxdbLogging => new(_haContext, "input_boolean.influxdb_logging");
		///<summary>IZone Logging</summary>
		public InputBooleanEntity IzoneLogging => new(_haContext, "input_boolean.izone_logging");
		///<summary>Kitchen Schedule Active</summary>
		public InputBooleanEntity KitchenScheduleActive => new(_haContext, "input_boolean.kitchen_schedule_active");
		///<summary>Kitchen Squirrel Notifications</summary>
		public InputBooleanEntity KitchenSquirrelNotifications => new(_haContext, "input_boolean.kitchen_squirrel_notifications");
		///<summary>Dismiss Landfill Bin</summary>
		public InputBooleanEntity LandfillBinDismissed => new(_haContext, "input_boolean.landfill_bin_dismissed");
		///<summary>Light Logging</summary>
		public InputBooleanEntity LightLogging => new(_haContext, "input_boolean.light_logging");
		///<summary>Lighting timer</summary>
		public InputBooleanEntity LightingTimer => new(_haContext, "input_boolean.lighting_timer");
		///<summary>Livingroom Schedule Active</summary>
		public InputBooleanEntity LivingroomScheduleActive => new(_haContext, "input_boolean.livingroom_schedule_active");
		///<summary>livingroom Squirrel Notifications</summary>
		public InputBooleanEntity LivingroomSquirrelNotifications => new(_haContext, "input_boolean.livingroom_squirrel_notifications");
		///<summary>Local_ip Logging</summary>
		public InputBooleanEntity LocalIpLogging => new(_haContext, "input_boolean.local_ip_logging");
		///<summary>Location Logging</summary>
		public InputBooleanEntity LocationLogging => new(_haContext, "input_boolean.location_logging");
		///<summary>Lock Logging</summary>
		public InputBooleanEntity LockLogging => new(_haContext, "input_boolean.lock_logging");
		///<summary>Makeup Time</summary>
		public InputBooleanEntity MakeupLights => new(_haContext, "input_boolean.makeup_lights");
		///<summary>Media Player Cast Logging</summary>
		public InputBooleanEntity MediaPlayerCastLogging => new(_haContext, "input_boolean.media_player_cast_logging");
		///<summary>Media Player Logging</summary>
		public InputBooleanEntity MediaPlayerLogging => new(_haContext, "input_boolean.media_player_logging");
		///<summary>Migraine Mode</summary>
		public InputBooleanEntity MigraineMode => new(_haContext, "input_boolean.migraine_mode");
		public InputBooleanEntity MoronMachine => new(_haContext, "input_boolean.moron_machine");
		///<summary>Movie Lighting</summary>
		public InputBooleanEntity MovieLighting => new(_haContext, "input_boolean.movie_lighting");
		///<summary>MQTT Logging</summary>
		public InputBooleanEntity MqttLogging => new(_haContext, "input_boolean.mqtt_logging");
		///<summary>netdaemon_appmodelhelloyamlapp</summary>
		public InputBooleanEntity NetdaemonAppmodelhelloyamlapp => new(_haContext, "input_boolean.netdaemon_appmodelhelloyamlapp");
		///<summary>netdaemon_extensionsschedulingschedulingapp</summary>
		public InputBooleanEntity NetdaemonExtensionsschedulingschedulingapp => new(_haContext, "input_boolean.netdaemon_extensionsschedulingschedulingapp");
		///<summary>netdaemon_hassmodelhelloworldapp</summary>
		public InputBooleanEntity NetdaemonHassmodelhelloworldapp => new(_haContext, "input_boolean.netdaemon_hassmodelhelloworldapp");
		///<summary>netdaemon_hassmodellightonmovement</summary>
		public InputBooleanEntity NetdaemonHassmodellightonmovement => new(_haContext, "input_boolean.netdaemon_hassmodellightonmovement");
		///<summary>netdaemon_netdaemonappsappssquiggleyappsflashlightonmovement</summary>
		public InputBooleanEntity NetdaemonNetdaemonappsappssquiggleyappsflashlightonmovement => new(_haContext, "input_boolean.netdaemon_netdaemonappsappssquiggleyappsflashlightonmovement");
		///<summary>netdaemon_netdaemonappsappssquiggleyappsflashlightonmovementtest</summary>
		public InputBooleanEntity NetdaemonNetdaemonappsappssquiggleyappsflashlightonmovementtest => new(_haContext, "input_boolean.netdaemon_netdaemonappsappssquiggleyappsflashlightonmovementtest");
		///<summary>netdaemon_squiggleyflashlightonmovement</summary>
		public InputBooleanEntity NetdaemonSquiggleyflashlightonmovement => new(_haContext, "input_boolean.netdaemon_squiggleyflashlightonmovement");
		///<summary>Night Light Stripper</summary>
		public InputBooleanEntity NightLightStripper => new(_haContext, "input_boolean.night_light_stripper");
		///<summary>Nobody Home</summary>
		public InputBooleanEntity NobodyHome => new(_haContext, "input_boolean.nobody_home");
		///<summary>Notify Logging</summary>
		public InputBooleanEntity NotifyLogging => new(_haContext, "input_boolean.notify_logging");
		///<summary>Send Notification To TV</summary>
		public InputBooleanEntity NotifyTv => new(_haContext, "input_boolean.notify_tv");
		///<summary>Nzbget Logging</summary>
		public InputBooleanEntity NzbgetLogging => new(_haContext, "input_boolean.nzbget_logging");
		///<summary>Occupancy</summary>
		public InputBooleanEntity Occupancy => new(_haContext, "input_boolean.occupancy");
		///<summary>Office Schedule Active</summary>
		public InputBooleanEntity OfficeScheduleActive => new(_haContext, "input_boolean.office_schedule_active");
		///<summary>Office Squirrel Notifications</summary>
		public InputBooleanEntity OfficeSquirrelNotifications => new(_haContext, "input_boolean.office_squirrel_notifications");
		///<summary>Open Weathermap Logging</summary>
		public InputBooleanEntity OpenweathermapLogging => new(_haContext, "input_boolean.openweathermap_logging");
		///<summary>OZW Logging</summary>
		public InputBooleanEntity OzwLogging => new(_haContext, "input_boolean.ozw_logging");
		///<summary>Pi Hole Logging</summary>
		public InputBooleanEntity PiHoleLogging => new(_haContext, "input_boolean.pi_hole_logging");
		///<summary>Pulselight Active</summary>
		public InputBooleanEntity PulselightActive => new(_haContext, "input_boolean.pulselight_active");
		///<summary>Python Scripts Logging</summary>
		public InputBooleanEntity PythonLogging => new(_haContext, "input_boolean.python_logging");
		///<summary>Recollect Waste Logging</summary>
		public InputBooleanEntity RecollectWasteLogging => new(_haContext, "input_boolean.recollect_waste_logging");
		///<summary>Recorder Logging</summary>
		public InputBooleanEntity RecorderLogging => new(_haContext, "input_boolean.recorder_logging");
		///<summary>Dismiss Recycling Bin</summary>
		public InputBooleanEntity RecyclingBinDismissed => new(_haContext, "input_boolean.recycling_bin_dismissed");
		///<summary>Roomba Logging</summary>
		public InputBooleanEntity RoombaLogging => new(_haContext, "input_boolean.roomba_logging");
		///<summary>Scripts Logging</summary>
		public InputBooleanEntity ScriptsLogging => new(_haContext, "input_boolean.scripts_logging");
		///<summary>Sensor Logging</summary>
		public InputBooleanEntity SensorLogging => new(_haContext, "input_boolean.sensor_logging");
		///<summary>Shelly Logging</summary>
		public InputBooleanEntity ShellyLogging => new(_haContext, "input_boolean.shelly_logging");
		///<summary>Shodan Logging</summary>
		public InputBooleanEntity ShodanLogging => new(_haContext, "input_boolean.shodan_logging");
		///<summary>Slow Cooker timer</summary>
		public InputBooleanEntity SlowCookerTimer => new(_haContext, "input_boolean.slow_cooker_timer");
		///<summary>Sonarr Logging</summary>
		public InputBooleanEntity SonarrLogging => new(_haContext, "input_boolean.sonarr_logging");
		///<summary>Squiggley Home</summary>
		public InputBooleanEntity SquiggleyHome => new(_haContext, "input_boolean.squiggley_home");
		///<summary>Squirrel Notifications</summary>
		public InputBooleanEntity SquirrelNotifications => new(_haContext, "input_boolean.squirrel_notifications");
		///<summary>Stupid Box</summary>
		public InputBooleanEntity StupidBox => new(_haContext, "input_boolean.stupid_box");
		///<summary>Sun2 Logging</summary>
		public InputBooleanEntity Sun2Logging => new(_haContext, "input_boolean.sun2_logging");
		///<summary>Switch Logging</summary>
		public InputBooleanEntity SwitchLogging => new(_haContext, "input_boolean.switch_logging");
		///<summary>Tasmota Logging</summary>
		public InputBooleanEntity TasmotaLogging => new(_haContext, "input_boolean.tasmota_logging");
		///<summary>Tautulli Logging</summary>
		public InputBooleanEntity TautulliLogging => new(_haContext, "input_boolean.tautulli_logging");
		///<summary>Toilet Light Automations</summary>
		public InputBooleanEntity ToiletCeilingLightsEnabled => new(_haContext, "input_boolean.toilet_ceiling_lights_enabled");
		///<summary>Toilet Occupied</summary>
		public InputBooleanEntity ToiletOccupied => new(_haContext, "input_boolean.toilet_occupied");
		///<summary>Travis Ci Logging</summary>
		public InputBooleanEntity TravisciLogging => new(_haContext, "input_boolean.travisci_logging");
		///<summary>Tuya Logging</summary>
		public InputBooleanEntity TuyaLogging => new(_haContext, "input_boolean.tuya_logging");
		///<summary>Unifi Direct Logging</summary>
		public InputBooleanEntity UnifiDirectLogging => new(_haContext, "input_boolean.unifi_direct_logging");
		///<summary>Unifi Logging</summary>
		public InputBooleanEntity UnifiLogging => new(_haContext, "input_boolean.unifi_logging");
		///<summary>VERA Logging</summary>
		public InputBooleanEntity VeraLogging => new(_haContext, "input_boolean.vera_logging");
		///<summary>Vestibule Light Automations</summary>
		public InputBooleanEntity VestibuleLightsEnabled => new(_haContext, "input_boolean.vestibule_lights_enabled");
		///<summary>Vestibule Schedule Active</summary>
		public InputBooleanEntity VestibuleScheduleActive => new(_haContext, "input_boolean.vestibule_schedule_active");
		///<summary>Websocket API Logging</summary>
		public InputBooleanEntity WebsocketApiLogging => new(_haContext, "input_boolean.websocket_api_logging");
		///<summary>Websocket Logging</summary>
		public InputBooleanEntity WebsocketLogging => new(_haContext, "input_boolean.websocket_logging");
		///<summary>Wee Bear Home</summary>
		public InputBooleanEntity WeeBearHome => new(_haContext, "input_boolean.wee_bear_home");
		///<summary>wee_bear Schedule Active</summary>
		public InputBooleanEntity WeeBearScheduleActive => new(_haContext, "input_boolean.wee_bear_schedule_active");
		///<summary>Wee Bear Office Squirrel Notifications</summary>
		public InputBooleanEntity WeebearOfficeSquirrelNotifications => new(_haContext, "input_boolean.weebear_office_squirrel_notifications");
		///<summary>WLED Logging</summary>
		public InputBooleanEntity WledLogging => new(_haContext, "input_boolean.wled_logging");
		///<summary>Xiaomi Aqara Logging</summary>
		public InputBooleanEntity XiaomiAqaraLogging => new(_haContext, "input_boolean.xiaomi_aqara_logging");
		///<summary>Xiaomi Miio Logging</summary>
		public InputBooleanEntity XiaomiMiioLogging => new(_haContext, "input_boolean.xiaomi_miio_logging");
		///<summary>ZHA Logging</summary>
		public InputBooleanEntity ZhaLogging => new(_haContext, "input_boolean.zha_logging");
		///<summary>Allow devices to join</summary>
		public InputBooleanEntity ZigbeePermitJoin => new(_haContext, "input_boolean.zigbee_permit_join");
		///<summary>Zwave Logging</summary>
		public InputBooleanEntity ZwaveLogging => new(_haContext, "input_boolean.zwave_logging");
	}

	public class InputDatetimeEntities
	{
		private readonly IHaContext _haContext;
		public InputDatetimeEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Start checking if the car needs defrosted</summary>
		public InputDatetimeEntity CarDefrostWeekdayMorningStart => new(_haContext, "input_datetime.car_defrost_weekday_morning_start");
		///<summary>Stop checking if the car needs defrosted</summary>
		public InputDatetimeEntity CarDefrostWeekdayMorningStop => new(_haContext, "input_datetime.car_defrost_weekday_morning_stop");
		///<summary>All rooms week night stop</summary>
		public InputDatetimeEntity HeatingAllRoomsWeekNightStop => new(_haContext, "input_datetime.heating_all_rooms_week_night_stop");
		///<summary>All rooms weekend night stop</summary>
		public InputDatetimeEntity HeatingAllRoomsWeekendNightStop => new(_haContext, "input_datetime.heating_all_rooms_weekend_night_stop");
		///<summary>Bedroom weekday start</summary>
		public InputDatetimeEntity HeatingBedroomWeekdayStart => new(_haContext, "input_datetime.heating_bedroom_weekday_start");
		///<summary>Bedroom weekday stop</summary>
		public InputDatetimeEntity HeatingBedroomWeekdayStop => new(_haContext, "input_datetime.heating_bedroom_weekday_stop");
		///<summary>Bedroom weekend start</summary>
		public InputDatetimeEntity HeatingBedroomWeekendStart => new(_haContext, "input_datetime.heating_bedroom_weekend_start");
		///<summary>Bedroom weekend stop</summary>
		public InputDatetimeEntity HeatingBedroomWeekendStop => new(_haContext, "input_datetime.heating_bedroom_weekend_stop");
		///<summary>Kitchen weekday start</summary>
		public InputDatetimeEntity HeatingKitchenWeekdayStart => new(_haContext, "input_datetime.heating_kitchen_weekday_start");
		///<summary>Kitchen weekday stop</summary>
		public InputDatetimeEntity HeatingKitchenWeekdayStop => new(_haContext, "input_datetime.heating_kitchen_weekday_stop");
		///<summary>Kitchen weekend start</summary>
		public InputDatetimeEntity HeatingKitchenWeekendStart => new(_haContext, "input_datetime.heating_kitchen_weekend_start");
		///<summary>Kitchen weekend stop</summary>
		public InputDatetimeEntity HeatingKitchenWeekendStop => new(_haContext, "input_datetime.heating_kitchen_weekend_stop");
		///<summary>Livingroom weekday start</summary>
		public InputDatetimeEntity HeatingLivingroomWeekdayStart => new(_haContext, "input_datetime.heating_livingroom_weekday_start");
		///<summary>Livingroom weekday stop</summary>
		public InputDatetimeEntity HeatingLivingroomWeekdayStop => new(_haContext, "input_datetime.heating_livingroom_weekday_stop");
		///<summary>Livingroom weekend start</summary>
		public InputDatetimeEntity HeatingLivingroomWeekendStart => new(_haContext, "input_datetime.heating_livingroom_weekend_start");
		///<summary>Livingroom weekend stop</summary>
		public InputDatetimeEntity HeatingLivingroomWeekendStop => new(_haContext, "input_datetime.heating_livingroom_weekend_stop");
		///<summary>Office weekday start</summary>
		public InputDatetimeEntity HeatingOfficeWeekdayStart => new(_haContext, "input_datetime.heating_office_weekday_start");
		///<summary>Office weekday stop</summary>
		public InputDatetimeEntity HeatingOfficeWeekdayStop => new(_haContext, "input_datetime.heating_office_weekday_stop");
		///<summary>Office weekend start</summary>
		public InputDatetimeEntity HeatingOfficeWeekendStart => new(_haContext, "input_datetime.heating_office_weekend_start");
		///<summary>Office weekend stop</summary>
		public InputDatetimeEntity HeatingOfficeWeekendStop => new(_haContext, "input_datetime.heating_office_weekend_stop");
		///<summary>Vestibule weekday start</summary>
		public InputDatetimeEntity HeatingVestibuleWeekdayStart => new(_haContext, "input_datetime.heating_vestibule_weekday_start");
		///<summary>Vestibule weekday stop</summary>
		public InputDatetimeEntity HeatingVestibuleWeekdayStop => new(_haContext, "input_datetime.heating_vestibule_weekday_stop");
		///<summary>Vestibule weekend start</summary>
		public InputDatetimeEntity HeatingVestibuleWeekendStart => new(_haContext, "input_datetime.heating_vestibule_weekend_start");
		///<summary>Vestibule weekend stop</summary>
		public InputDatetimeEntity HeatingVestibuleWeekendStop => new(_haContext, "input_datetime.heating_vestibule_weekend_stop");
		///<summary>wee_bear weekday start</summary>
		public InputDatetimeEntity HeatingWeeBearWeekdayStart => new(_haContext, "input_datetime.heating_wee_bear_weekday_start");
		///<summary>wee_bear weekday stop</summary>
		public InputDatetimeEntity HeatingWeeBearWeekdayStop => new(_haContext, "input_datetime.heating_wee_bear_weekday_stop");
		///<summary>wee_bear weekend start</summary>
		public InputDatetimeEntity HeatingWeeBearWeekendStart => new(_haContext, "input_datetime.heating_wee_bear_weekend_start");
		///<summary>wee_bear weekend stop</summary>
		public InputDatetimeEntity HeatingWeeBearWeekendStop => new(_haContext, "input_datetime.heating_wee_bear_weekend_stop");
		///<summary>Week day evening start</summary>
		public InputDatetimeEntity LightingWeekdayEveningStart => new(_haContext, "input_datetime.lighting_weekday_evening_start");
		///<summary>Week day evening stop</summary>
		public InputDatetimeEntity LightingWeekdayEveningStop => new(_haContext, "input_datetime.lighting_weekday_evening_stop");
		///<summary>Week day morning start</summary>
		public InputDatetimeEntity LightingWeekdayMorningStart => new(_haContext, "input_datetime.lighting_weekday_morning_start");
		///<summary>Week day morning stop</summary>
		public InputDatetimeEntity LightingWeekdayMorningStop => new(_haContext, "input_datetime.lighting_weekday_morning_stop");
		///<summary>Weekend evening start</summary>
		public InputDatetimeEntity LightingWeekendEveningStart => new(_haContext, "input_datetime.lighting_weekend_evening_start");
		///<summary>Weekend evening stop</summary>
		public InputDatetimeEntity LightingWeekendEveningStop => new(_haContext, "input_datetime.lighting_weekend_evening_stop");
		///<summary>Weekend morning start</summary>
		public InputDatetimeEntity LightingWeekendMorningStart => new(_haContext, "input_datetime.lighting_weekend_morning_start");
		///<summary>Weekend morning stop</summary>
		public InputDatetimeEntity LightingWeekendMorningStop => new(_haContext, "input_datetime.lighting_weekend_morning_stop");
		///<summary>Slow cooker start</summary>
		public InputDatetimeEntity SlowCookerStart => new(_haContext, "input_datetime.slow_cooker_start");
		///<summary>Slow cooker stop</summary>
		public InputDatetimeEntity SlowCookerStop => new(_haContext, "input_datetime.slow_cooker_stop");
		///<summary>Toilet Lights Duration</summary>
		public InputDatetimeEntity ToiletCeilingLightsDuration => new(_haContext, "input_datetime.toilet_ceiling_lights_duration");
	}

	public class InputNumberEntities
	{
		private readonly IHaContext _haContext;
		public InputNumberEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bathroom Boost</summary>
		public InputNumberEntity BathroomBoost => new(_haContext, "input_number.bathroom_boost");
		///<summary>Bathroom Minimum Temperature</summary>
		public InputNumberEntity BathroomMinimumTemperature => new(_haContext, "input_number.bathroom_minimum_temperature");
		///<summary>Bathroom Temperature</summary>
		public InputNumberEntity BathroomTemperature => new(_haContext, "input_number.bathroom_temperature");
		///<summary>Bedroom Boost</summary>
		public InputNumberEntity BedroomBoost => new(_haContext, "input_number.bedroom_boost");
		///<summary>Bedroom Minimum Temperature</summary>
		public InputNumberEntity BedroomMinimumTemperature => new(_haContext, "input_number.bedroom_minimum_temperature");
		///<summary>Bedroom Temperature</summary>
		public InputNumberEntity BedroomTemperature => new(_haContext, "input_number.bedroom_temperature");
		///<summary>Dark Outside Brightness</summary>
		public InputNumberEntity DarkOutsideBrightness => new(_haContext, "input_number.dark_outside_brightness");
		///<summary>Colour</summary>
		public InputNumberEntity InputColor => new(_haContext, "input_number.input_color");
		///<summary>Kitchen Boost</summary>
		public InputNumberEntity KitchenBoost => new(_haContext, "input_number.kitchen_boost");
		///<summary>Kitchen Minimum Temperature</summary>
		public InputNumberEntity KitchenMinimumTemperature => new(_haContext, "input_number.kitchen_minimum_temperature");
		///<summary>Kitchen Temperature</summary>
		public InputNumberEntity KitchenTemperature => new(_haContext, "input_number.kitchen_temperature");
		///<summary>Livingroom Boost</summary>
		public InputNumberEntity LivingroomBoost => new(_haContext, "input_number.livingroom_boost");
		///<summary>Livingroom Minimum Temperature</summary>
		public InputNumberEntity LivingroomMinimumTemperature => new(_haContext, "input_number.livingroom_minimum_temperature");
		///<summary>Livingroom Temperature</summary>
		public InputNumberEntity LivingroomTemperature => new(_haContext, "input_number.livingroom_temperature");
		///<summary>Makup Lights Duration</summary>
		public InputNumberEntity MakeupLightsDuration => new(_haContext, "input_number.makeup_lights_duration");
		///<summary>Migraine Brightness</summary>
		public InputNumberEntity MigraineBrightness => new(_haContext, "input_number.migraine_brightness");
		///<summary>Night Light Brightness</summary>
		public InputNumberEntity NightLightBrightness => new(_haContext, "input_number.night_light_brightness");
		///<summary>Night Light Duration</summary>
		public InputNumberEntity NightLightDuration => new(_haContext, "input_number.night_light_duration");
		///<summary>Normal Brightness</summary>
		public InputNumberEntity NormalBrightness => new(_haContext, "input_number.normal_brightness");
		///<summary>Office Boost</summary>
		public InputNumberEntity OfficeBoost => new(_haContext, "input_number.office_boost");
		///<summary>Office Button Height</summary>
		public InputNumberEntity OfficeButtonHeight => new(_haContext, "input_number.office_button_height");
		///<summary>Office Button Width</summary>
		public InputNumberEntity OfficeButtonWidth => new(_haContext, "input_number.office_button_width");
		///<summary>Office Minimum Temperature</summary>
		public InputNumberEntity OfficeMinimumTemperature => new(_haContext, "input_number.office_minimum_temperature");
		///<summary>Office Temperature</summary>
		public InputNumberEntity OfficeTemperature => new(_haContext, "input_number.office_temperature");
		///<summary>Pulselight Brightness</summary>
		public InputNumberEntity PulselightBrightness => new(_haContext, "input_number.pulselight_brightness");
		///<summary>Pulselight Delay</summary>
		public InputNumberEntity PulselightDelay => new(_haContext, "input_number.pulselight_delay");
		///<summary>Pulselight Transition</summary>
		public InputNumberEntity PulselightTransition => new(_haContext, "input_number.pulselight_transition");
		///<summary>Fan Off</summary>
		public InputNumberEntity ServerFanOffTemperature => new(_haContext, "input_number.server_fan_off_temperature");
		///<summary>Fan On</summary>
		public InputNumberEntity ServerFanOnTemperature => new(_haContext, "input_number.server_fan_on_temperature");
		///<summary>Toilet Lights Timer Duration</summary>
		public InputNumberEntity ToiletLightsTimer => new(_haContext, "input_number.toilet_lights_timer");
		///<summary>Vestibule Boost</summary>
		public InputNumberEntity VestibuleBoost => new(_haContext, "input_number.vestibule_boost");
		///<summary>Vestibule Minimum Temperature</summary>
		public InputNumberEntity VestibuleMinimumTemperature => new(_haContext, "input_number.vestibule_minimum_temperature");
		///<summary>Vestibule Temperature</summary>
		public InputNumberEntity VestibuleTemperature => new(_haContext, "input_number.vestibule_temperature");
		///<summary>Wee Bear Boost</summary>
		public InputNumberEntity WeebearBoost => new(_haContext, "input_number.weebear_boost");
		///<summary>Wee Bear Minimum Temperature</summary>
		public InputNumberEntity WeebearMinimumTemperature => new(_haContext, "input_number.weebear_minimum_temperature");
		///<summary>Wee Bear Temperature</summary>
		public InputNumberEntity WeebearTemperature => new(_haContext, "input_number.weebear_temperature");
	}

	public class InputSelectEntities
	{
		private readonly IHaContext _haContext;
		public InputSelectEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Cast camera</summary>
		public InputSelectEntity CameraDropdown => new(_haContext, "input_select.camera_dropdown");
		///<summary>To Screen</summary>
		public InputSelectEntity CastToScreenDropdown => new(_haContext, "input_select.cast_to_screen_dropdown");
		///<summary>Fan Speed</summary>
		public InputSelectEntity FanSpeed => new(_haContext, "input_select.fan_speed");
		///<summary>House Occupancy</summary>
		public InputSelectEntity HouseOccupancyStatus => new(_haContext, "input_select.house_occupancy_status");
		///<summary>Log Level</summary>
		public InputSelectEntity LogLevel => new(_haContext, "input_select.log_level");
		///<summary>Home Users</summary>
		public InputSelectEntity NotifyDevice => new(_haContext, "input_select.notify_device");
		///<summary>Squiggley Sleep Status</summary>
		public InputSelectEntity SquiggleySleepStatus => new(_haContext, "input_select.squiggley_sleep_status");
		///<summary>Wee Bear Sleep Status</summary>
		public InputSelectEntity WeeBearSleepStatus => new(_haContext, "input_select.wee_bear_sleep_status");
	}

	public class InputTextEntities
	{
		private readonly IHaContext _haContext;
		public InputTextEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>KODI Media Content Type</summary>
		public InputTextEntity KodiMediaContentType => new(_haContext, "input_text.kodi_media_content_type");
		///<summary>Pulselight Color</summary>
		public InputTextEntity PulselightColor => new(_haContext, "input_text.pulselight_color");
		///<summary>Pulselight Light Id</summary>
		public InputTextEntity PulselightLightId => new(_haContext, "input_text.pulselight_light_id");
		///<summary>Message To Send</summary>
		public InputTextEntity SendMessage => new(_haContext, "input_text.send_message");
		///<summary>Value Room</summary>
		public InputTextEntity Valueroom => new(_haContext, "input_text.valueroom");
	}

	public class LightEntities
	{
		private readonly IHaContext _haContext;
		public LightEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Alarm Lights</summary>
		public LightEntity AlarmLights => new(_haContext, "light.alarm_lights");
		///<summary>All Vestibule Lights</summary>
		public LightEntity AllVestibuleLights => new(_haContext, "light.all_vestibule_lights");
		///<summary>back_garden</summary>
		public LightEntity BackGarden => new(_haContext, "light.back_garden");
		///<summary>Back Garden Eight</summary>
		public LightEntity BackGardenEight => new(_haContext, "light.back_garden_eight");
		///<summary>Back Garden Eleven</summary>
		public LightEntity BackGardenEleven => new(_haContext, "light.back_garden_eleven");
		///<summary>Back Garden Five</summary>
		public LightEntity BackGardenFive => new(_haContext, "light.back_garden_five");
		///<summary>Back Garden Four</summary>
		public LightEntity BackGardenFour => new(_haContext, "light.back_garden_four");
		///<summary>Back Garden Nine</summary>
		public LightEntity BackGardenNine => new(_haContext, "light.back_garden_nine");
		///<summary>Back Garden One</summary>
		public LightEntity BackGardenOne => new(_haContext, "light.back_garden_one");
		///<summary>Back Garden Seven</summary>
		public LightEntity BackGardenSeven => new(_haContext, "light.back_garden_seven");
		///<summary>Back Garden Six</summary>
		public LightEntity BackGardenSix => new(_haContext, "light.back_garden_six");
		///<summary>Back Garden Ten</summary>
		public LightEntity BackGardenTen => new(_haContext, "light.back_garden_ten");
		///<summary>Back Garden Three</summary>
		public LightEntity BackGardenThree => new(_haContext, "light.back_garden_three");
		///<summary>Back Garden Twelve</summary>
		public LightEntity BackGardenTwelve => new(_haContext, "light.back_garden_twelve");
		///<summary>Back Garden Two</summary>
		public LightEntity BackGardenTwo => new(_haContext, "light.back_garden_two");
		///<summary>Back Wall Ceiling</summary>
		public LightEntity BackWallCeiling => new(_haContext, "light.back_wall_ceiling");
		///<summary>Back Wall Ceiling One</summary>
		public LightEntity BackWallCeilingOne => new(_haContext, "light.back_wall_ceiling_one");
		///<summary>back_wall_ceiling_three</summary>
		public LightEntity BackWallCeilingThree => new(_haContext, "light.back_wall_ceiling_three");
		///<summary>Back Wall Ceiling Two</summary>
		public LightEntity BackWallCeilingTwo => new(_haContext, "light.back_wall_ceiling_two");
		///<summary>back_wall_ceiling_two</summary>
		public LightEntity BackWallCeilingTwo2 => new(_haContext, "light.back_wall_ceiling_two_2");
		///<summary>Bathroom Ceiling</summary>
		public LightEntity BathroomCeiling => new(_haContext, "light.bathroom_ceiling");
		///<summary>bathroom_ceiling_one</summary>
		public LightEntity BathroomCeilingOne => new(_haContext, "light.bathroom_ceiling_one");
		///<summary>bathroom_ceiling_two</summary>
		public LightEntity BathroomCeilingTwo => new(_haContext, "light.bathroom_ceiling_two");
		///<summary>Bear Stripper</summary>
		public LightEntity BearStripper => new(_haContext, "light.bear_stripper");
		///<summary>Bedroom Ceiling</summary>
		public LightEntity BedroomCeiling => new(_haContext, "light.bedroom_ceiling");
		///<summary>Bedroom Ceiling Five</summary>
		public LightEntity BedroomCeilingFive => new(_haContext, "light.bedroom_ceiling_five");
		///<summary>Bedroom Ceiling Four</summary>
		public LightEntity BedroomCeilingFour => new(_haContext, "light.bedroom_ceiling_four");
		///<summary>Bedroom Ceiling One</summary>
		public LightEntity BedroomCeilingOne => new(_haContext, "light.bedroom_ceiling_one");
		///<summary>Bedroom Ceiling Three</summary>
		public LightEntity BedroomCeilingThree => new(_haContext, "light.bedroom_ceiling_three");
		///<summary>Bedroom Ceiling Two</summary>
		public LightEntity BedroomCeilingTwo => new(_haContext, "light.bedroom_ceiling_two");
		///<summary>Bench Ceiling</summary>
		public LightEntity BenchCeiling => new(_haContext, "light.bench_ceiling");
		///<summary>Bench Ceiling One</summary>
		public LightEntity BenchCeilingOne => new(_haContext, "light.bench_ceiling_one");
		///<summary>Bench Ceiling Two</summary>
		public LightEntity BenchCeilingTwo => new(_haContext, "light.bench_ceiling_two");
		///<summary>Cooking Ceiling</summary>
		public LightEntity CookingCeiling => new(_haContext, "light.cooking_ceiling");
		///<summary>Cooking Ceiling One</summary>
		public LightEntity CookingCeilingOne => new(_haContext, "light.cooking_ceiling_one");
		///<summary>Cooking Ceiling Two</summary>
		public LightEntity CookingCeilingTwo => new(_haContext, "light.cooking_ceiling_two");
		///<summary>Couch Lamp One</summary>
		public LightEntity CouchLampOne => new(_haContext, "light.couch_lamp_one");
		///<summary>Couch Lamp Two</summary>
		public LightEntity CouchLampTwo => new(_haContext, "light.couch_lamp_two");
		///<summary>Dining Ceiling</summary>
		public LightEntity DiningCeiling => new(_haContext, "light.dining_ceiling");
		///<summary>Dining Ceiling One</summary>
		public LightEntity DiningCeilingOne => new(_haContext, "light.dining_ceiling_one");
		///<summary>Dining Ceiling Two</summary>
		public LightEntity DiningCeilingTwo => new(_haContext, "light.dining_ceiling_two");
		///<summary>Dita Lamp</summary>
		public LightEntity Dita => new(_haContext, "light.dita");
		///<summary>Dog Lamps</summary>
		public LightEntity DogLamps => new(_haContext, "light.dog_lamps");
		///<summary>Door Lamp</summary>
		public LightEntity DoorLamp => new(_haContext, "light.door_lamp");
		///<summary>Eve Ceiling One</summary>
		public LightEntity EveCeilingOne => new(_haContext, "light.eve_ceiling_one");
		///<summary>Eve Ceiling Three</summary>
		public LightEntity EveCeilingThree => new(_haContext, "light.eve_ceiling_three");
		///<summary>Eve Ceiling Two</summary>
		public LightEntity EveCeilingTwo => new(_haContext, "light.eve_ceiling_two");
		///<summary>Fairy Lights</summary>
		public LightEntity FairyLights => new(_haContext, "light.fairy_lights");
		///<summary>Firework Lights</summary>
		public LightEntity FireworkLights => new(_haContext, "light.firework_lights");
		///<summary>Zaphod Hyperion Instance</summary>
		public LightEntity FirstLedHardwareInstance => new(_haContext, "light.first_led_hardware_instance");
		///<summary>Floor Lamp</summary>
		public LightEntity FloorLamp => new(_haContext, "light.floor_lamp");
		///<summary>Front Door Eve Lights</summary>
		public LightEntity FrontDoorEveLights => new(_haContext, "light.front_door_eve_lights");
		///<summary>Front Garden Lights</summary>
		public LightEntity FrontGardenLights => new(_haContext, "light.front_garden_lights");
		///<summary>Hall Ceiling</summary>
		public LightEntity HallCeiling => new(_haContext, "light.hall_ceiling");
		///<summary>Hall Ceiling One</summary>
		public LightEntity HallCeilingOne => new(_haContext, "light.hall_ceiling_one");
		///<summary>hall_ceiling_three</summary>
		public LightEntity HallCeilingThree => new(_haContext, "light.hall_ceiling_three");
		///<summary>hall_ceiling_two</summary>
		public LightEntity HallCeilingTwo => new(_haContext, "light.hall_ceiling_two");
		///<summary>Infinity</summary>
		public LightEntity Infinity => new(_haContext, "light.infinity");
		///<summary>Infinity Lamp</summary>
		public LightEntity InfinityLamp => new(_haContext, "light.infinity_lamp");
		///<summary>Kitchen Ceiling</summary>
		public LightEntity KitchenCeiling => new(_haContext, "light.kitchen_ceiling");
		///<summary>Kitchen Strippers</summary>
		public LightEntity KitchenStrippers => new(_haContext, "light.kitchen_strippers");
		///<summary>Kitchen Tree</summary>
		public LightEntity KitchenTree => new(_haContext, "light.kitchen_tree");
		///<summary>Livingroom Ceiling</summary>
		public LightEntity LivingroomCeiling => new(_haContext, "light.livingroom_ceiling");
		///<summary>LivingroomWLED</summary>
		public LightEntity Livingroomwled => new(_haContext, "light.livingroomwled");
		///<summary>lower_cooking_stripper</summary>
		public LightEntity LowerCookingStripper => new(_haContext, "light.lower_cooking_stripper");
		///<summary>lower_main_stripper</summary>
		public LightEntity LowerMainStripper => new(_haContext, "light.lower_main_stripper");
		///<summary>Main Ceiling</summary>
		public LightEntity MainCeiling => new(_haContext, "light.main_ceiling");
		///<summary>Main Ceiling Five</summary>
		public LightEntity MainCeilingFive => new(_haContext, "light.main_ceiling_five");
		///<summary>Main Ceiling Four</summary>
		public LightEntity MainCeilingFour => new(_haContext, "light.main_ceiling_four");
		///<summary>Main Ceiling One</summary>
		public LightEntity MainCeilingOne => new(_haContext, "light.main_ceiling_one");
		///<summary>Main Ceiling Six</summary>
		public LightEntity MainCeilingSix => new(_haContext, "light.main_ceiling_six");
		///<summary>Main Ceiling Three</summary>
		public LightEntity MainCeilingThree => new(_haContext, "light.main_ceiling_three");
		///<summary>Main Ceiling Two</summary>
		public LightEntity MainCeilingTwo => new(_haContext, "light.main_ceiling_two");
		///<summary>Marmaduke Lamp</summary>
		public LightEntity Marmaduke => new(_haContext, "light.marmaduke");
		///<summary>Monitor Backlight</summary>
		public LightEntity MonitorBacklight => new(_haContext, "light.monitor_backlight");
		///<summary>Monitor Light</summary>
		public LightEntity MonitorLight => new(_haContext, "light.monitor_light");
		///<summary>Movie Lights</summary>
		public LightEntity MovieLights => new(_haContext, "light.movie_lights");
		///<summary>Mural Ceiling</summary>
		public LightEntity MuralCeiling => new(_haContext, "light.mural_ceiling");
		///<summary>mural_ceiling_one</summary>
		public LightEntity MuralCeilingOne => new(_haContext, "light.mural_ceiling_one");
		///<summary>mural_ceiling_two</summary>
		public LightEntity MuralCeilingTwo => new(_haContext, "light.mural_ceiling_two");
		///<summary>nightlight_stripper</summary>
		public LightEntity NightlightStripper => new(_haContext, "light.nightlight_stripper");
		///<summary>Office Ceiling</summary>
		public LightEntity OfficeCeiling => new(_haContext, "light.office_ceiling");
		///<summary>Office Ceiling Four</summary>
		public LightEntity OfficeCeilingFour => new(_haContext, "light.office_ceiling_four");
		///<summary>office_ceiling_one</summary>
		public LightEntity OfficeCeilingOne => new(_haContext, "light.office_ceiling_one");
		///<summary>Office Ceiling Three</summary>
		public LightEntity OfficeCeilingThree => new(_haContext, "light.office_ceiling_three");
		///<summary>Office Ceiling Two</summary>
		public LightEntity OfficeCeilingTwo => new(_haContext, "light.office_ceiling_two");
		///<summary>Office Lamps</summary>
		public LightEntity OfficeLamps => new(_haContext, "light.office_lamps");
		///<summary>Office Spotlight</summary>
		public LightEntity OfficeSpotlight => new(_haContext, "light.office_spotlight");
		///<summary>Server Fan Blue LED</summary>
		public LightEntity ServerFanBlueLed => new(_haContext, "light.server_fan_blue_led");
		///<summary>Server Fan POW Blue LED</summary>
		public LightEntity ServerFanPowBlueLed => new(_haContext, "light.server_fan_pow_blue_led");
		///<summary>Side lights</summary>
		public LightEntity SideLights => new(_haContext, "light.side_lights");
		///<summary>small_wardrobe</summary>
		public LightEntity SmallWardrobe => new(_haContext, "light.small_wardrobe");
		///<summary>small_wardrobe_stripper</summary>
		public LightEntity SmallWardrobeStripper => new(_haContext, "light.small_wardrobe_stripper");
		///<summary>Squiggley Lamp</summary>
		public LightEntity SquiggleyLamp => new(_haContext, "light.squiggley_lamp");
		///<summary>Squiggley Smells</summary>
		public LightEntity SquiggleySmells => new(_haContext, "light.squiggley_smells");
		///<summary>Squiggley Wardrobe</summary>
		public LightEntity SquiggleyWardrobe => new(_haContext, "light.squiggley_wardrobe");
		///<summary>Stair Ceiling</summary>
		public LightEntity StairCeiling => new(_haContext, "light.stair_ceiling");
		///<summary>Stair Ceiling One</summary>
		public LightEntity StairCeilingOne => new(_haContext, "light.stair_ceiling_one");
		///<summary>stair_ceiling_three</summary>
		public LightEntity StairCeilingThree => new(_haContext, "light.stair_ceiling_three");
		///<summary>stair_ceiling_two</summary>
		public LightEntity StairCeilingTwo => new(_haContext, "light.stair_ceiling_two");
		///<summary>Stars</summary>
		public LightEntity Stars => new(_haContext, "light.stars");
		///<summary>Stars</summary>
		public LightEntity Stars2 => new(_haContext, "light.stars_2");
		///<summary>Table Lamps</summary>
		public LightEntity TableLamps => new(_haContext, "light.table_lamps");
		///<summary>Toilet Ceiling</summary>
		public LightEntity ToiletCeiling => new(_haContext, "light.toilet_ceiling");
		///<summary>Toilet Ceiling One</summary>
		public LightEntity ToiletCeilingOne => new(_haContext, "light.toilet_ceiling_one");
		///<summary>Toilet Ceiling Two</summary>
		public LightEntity ToiletCeilingTwo => new(_haContext, "light.toilet_ceiling_two");
		///<summary>TV Ceiling</summary>
		public LightEntity TvCeiling => new(_haContext, "light.tv_ceiling");
		///<summary>tv_ceiling_one</summary>
		public LightEntity TvCeilingOne => new(_haContext, "light.tv_ceiling_one");
		///<summary>TV Lamp</summary>
		public LightEntity TvLamp => new(_haContext, "light.tv_lamp");
		///<summary>upper_cooking_stripper</summary>
		public LightEntity UpperCookingStripper => new(_haContext, "light.upper_cooking_stripper");
		///<summary>upper_main_stripper</summary>
		public LightEntity UpperMainStripper => new(_haContext, "light.upper_main_stripper");
		///<summary>Vestibule Ceiling Lights</summary>
		public LightEntity VestibuleCeilingLights => new(_haContext, "light.vestibule_ceiling_lights");
		///<summary>Vestibule Ceiling Four</summary>
		public LightEntity VestibuleFour => new(_haContext, "light.vestibule_four");
		///<summary>vestibule_one</summary>
		public LightEntity VestibuleOne => new(_haContext, "light.vestibule_one");
		///<summary>Vestibule Ceiling Three</summary>
		public LightEntity VestibuleThree => new(_haContext, "light.vestibule_three");
		///<summary>vestibule_two</summary>
		public LightEntity VestibuleTwo => new(_haContext, "light.vestibule_two");
		///<summary>Wardrobe Lamp</summary>
		public LightEntity WardrobeLamp => new(_haContext, "light.wardrobe_lamp");
		///<summary>Wee Bear Ceiling</summary>
		public LightEntity WeeBearCeiling => new(_haContext, "light.wee_bear_ceiling");
		///<summary>Wee Bear Ceiling Four</summary>
		public LightEntity WeeBearCeilingFour => new(_haContext, "light.wee_bear_ceiling_four");
		///<summary>Wee Bear Ceiling One</summary>
		public LightEntity WeeBearCeilingOne => new(_haContext, "light.wee_bear_ceiling_one");
		///<summary>Wee Bear Ceiling Three</summary>
		public LightEntity WeeBearCeilingThree => new(_haContext, "light.wee_bear_ceiling_three");
		///<summary>Wee Bear Ceiling Two</summary>
		public LightEntity WeeBearCeilingTwo => new(_haContext, "light.wee_bear_ceiling_two");
		///<summary>Wee Bear Lamp</summary>
		public LightEntity WeeBearLamp => new(_haContext, "light.wee_bear_lamp");
		///<summary>Wee Bear Office Lamp</summary>
		public LightEntity WeeBearOfficeLamp => new(_haContext, "light.wee_bear_office_lamp");
		///<summary>Wee Bear Wardrobe Stripper</summary>
		public LightEntity WeeBearWardrobeStripper => new(_haContext, "light.wee_bear_wardrobe_stripper");
		///<summary>Window Ceiling</summary>
		public LightEntity WindowCeiling => new(_haContext, "light.window_ceiling");
		///<summary>window_ceiling_four</summary>
		public LightEntity WindowCeilingFour => new(_haContext, "light.window_ceiling_four");
		///<summary>window_ceiling_one</summary>
		public LightEntity WindowCeilingOne => new(_haContext, "light.window_ceiling_one");
		///<summary>window_ceiling_three</summary>
		public LightEntity WindowCeilingThree => new(_haContext, "light.window_ceiling_three");
		///<summary>window_ceiling_two</summary>
		public LightEntity WindowCeilingTwo => new(_haContext, "light.window_ceiling_two");
		///<summary>ZaphodWLED</summary>
		public LightEntity Zaphodwled => new(_haContext, "light.zaphodwled");
	}

	public class MediaPlayerEntities
	{
		private readonly IHaContext _haContext;
		public MediaPlayerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom speaker</summary>
		public MediaPlayerEntity BedroomSpeaker => new(_haContext, "media_player.bedroom_speaker");
		///<summary>Kitchen speaker</summary>
		public MediaPlayerEntity KitchenSpeaker => new(_haContext, "media_player.kitchen_speaker");
		///<summary>Living room TV</summary>
		public MediaPlayerEntity LivingRoomTv => new(_haContext, "media_player.living_room_tv");
		///<summary>Livingroom speaker</summary>
		public MediaPlayerEntity LivingroomSpeaker => new(_haContext, "media_player.livingroom_speaker");
		///<summary>Livingroom TV</summary>
		public MediaPlayerEntity LivingroomTv => new(_haContext, "media_player.livingroom_tv");
		///<summary>LivingroomTV</summary>
		public MediaPlayerEntity Livingroomtv => new(_haContext, "media_player.livingroomtv");
		public MediaPlayerEntity Marvin => new(_haContext, "media_player.marvin");
		///<summary>Marvin</summary>
		public MediaPlayerEntity Marvin2 => new(_haContext, "media_player.marvin_2");
		///<summary>Marvin Shield</summary>
		public MediaPlayerEntity MarvinShield => new(_haContext, "media_player.marvin_shield");
		///<summary>noisemaker</summary>
		public MediaPlayerEntity Noisemaker => new(_haContext, "media_player.noisemaker");
		///<summary>Office display</summary>
		public MediaPlayerEntity OfficeDisplay => new(_haContext, "media_player.office_display");
		///<summary>Wee Bear speaker</summary>
		public MediaPlayerEntity OfficeSpeaker => new(_haContext, "media_player.office_speaker");
		///<summary>Vroomfondel</summary>
		public MediaPlayerEntity OpenhomeUuid674040046dd31e720516B827ebaeac9f => new(_haContext, "media_player.openhome_uuid_67404004_6dd3_1e72_0516_b827ebaeac9f");
		///<summary>Plex (claire.valentine@sky.com - Plex Web - Safari - OSX)</summary>
		public MediaPlayerEntity PlexClaireValentineSkyComPlexWebSafariOsx => new(_haContext, "media_player.plex_claire_valentine_sky_com_plex_web_safari_osx");
		///<summary>Plex (drofng@hotmail.com - Plex for PlayStation 4 - PS4-352)</summary>
		public MediaPlayerEntity PlexDrofngHotmailComPlexForPlaystation4Ps4352 => new(_haContext, "media_player.plex_drofng_hotmail_com_plex_for_playstation_4_ps4_352");
		///<summary>Plex (dro562 - Plex Web - Chrome - Windows)</summary>
		public MediaPlayerEntity PlexDrofngHotmailComPlexWebChromeWindows => new(_haContext, "media_player.plex_drofng_hotmail_com_plex_web_chrome_windows");
		///<summary>Plex (drofng@hotmail.com - Plex Web - Firefox - Windows)</summary>
		public MediaPlayerEntity PlexDrofngHotmailComPlexWebFirefoxWindows => new(_haContext, "media_player.plex_drofng_hotmail_com_plex_web_firefox_windows");
		///<summary>Plex (jackhammertechno@gmail.com - Plex for Kodi - Kodi)</summary>
		public MediaPlayerEntity PlexJackhammertechnoGmailComPlexForKodiKodiAddOnSquiggleyvision => new(_haContext, "media_player.plex_jackhammertechno_gmail_com_plex_for_kodi_kodi_add_on_squiggleyvision");
		///<summary>Plex (jackhammertechno@gmail.com - Plex Web - Chrome - OSX)</summary>
		public MediaPlayerEntity PlexJackhammertechnoGmailComPlexWebChromeOsx => new(_haContext, "media_player.plex_jackhammertechno_gmail_com_plex_web_chrome_osx");
		///<summary>Plex (jackhamm2 - Plex Web - Microsoft Edge - Windows)</summary>
		public MediaPlayerEntity PlexJackhammertechnoGmailComPlexWebMicrosoftEdgeWindows => new(_haContext, "media_player.plex_jackhammertechno_gmail_com_plex_web_microsoft_edge_windows");
		///<summary>Plex (katrindrafnar - Plex for Android (TV) - TPM171E)</summary>
		public MediaPlayerEntity PlexKatrindrafnarPlexForAndroidTvTpm171e => new(_haContext, "media_player.plex_katrindrafnar_plex_for_android_tv_tpm171e");
		///<summary>Plex (llaineyln@gmail.com - Plex Cast - Chromecast)</summary>
		public MediaPlayerEntity PlexLlaineylnGmailComPlexCastChromecast => new(_haContext, "media_player.plex_llaineyln_gmail_com_plex_cast_chromecast");
		///<summary>Plex (llaineyln@gmail.com - Plex Web - Chrome - Windows)</summary>
		public MediaPlayerEntity PlexLlaineylnGmailComPlexWebChromeWindows => new(_haContext, "media_player.plex_llaineyln_gmail_com_plex_web_chrome_windows");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux10 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_10");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux100 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_100");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux101 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_101");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux102 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_102");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux11 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_11");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux12 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_12");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux13 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_13");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux14 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_14");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux15 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_15");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux16 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_16");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux17 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_17");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux18 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_18");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux19 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_19");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux2 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_2");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux20 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_20");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux21 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_21");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux22 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_22");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux23 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_23");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux24 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_24");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux25 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_25");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux26 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_26");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux27 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_27");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux28 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_28");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux29 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_29");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux3 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_3");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux30 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_30");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux31 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_31");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux32 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_32");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux33 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_33");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux34 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_34");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux35 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_35");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux36 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_36");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux37 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_37");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux38 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_38");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux39 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_39");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux4 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_4");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux40 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_40");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux41 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_41");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux42 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_42");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux43 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_43");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux44 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_44");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux45 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_45");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux46 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_46");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux47 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_47");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux48 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_48");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux49 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_49");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux5 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_5");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux50 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_50");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux51 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_51");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux52 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_52");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux53 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_53");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux54 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_54");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux55 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_55");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux56 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_56");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux57 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_57");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux58 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_58");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux59 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_59");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux6 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_6");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux60 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_60");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux61 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_61");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux62 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_62");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux63 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_63");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux64 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_64");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux65 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_65");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux66 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_66");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux67 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_67");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux68 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_68");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux69 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_69");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux7 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_7");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux70 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_70");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux71 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_71");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux72 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_72");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux73 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_73");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux74 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_74");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux75 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_75");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux76 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_76");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux77 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_77");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux78 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_78");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux79 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_79");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux8 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_8");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux80 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_80");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux81 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_81");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux82 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_82");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux83 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_83");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux84 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_84");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux85 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_85");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux86 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_86");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux87 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_87");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux88 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_88");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux89 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_89");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux9 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_9");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux90 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_90");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux91 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_91");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux92 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_92");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux93 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_93");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux94 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_94");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux95 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_95");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux96 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_96");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux97 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_97");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux98 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_98");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeLinux99 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_linux_99");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Chrome - Windows)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebChromeWindows => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_chrome_windows");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Firefox - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebFirefoxLinux => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_firefox_linux");
		///<summary>Plex (mark3104 - Plex Web - Firefox - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebFirefoxLinux2 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_firefox_linux_2");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Firefox - Linux)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebFirefoxLinux3 => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_firefox_linux_3");
		///<summary>Plex (mark+plex@scottishclimbs.com - Plex Web - Firefox - Windows)</summary>
		public MediaPlayerEntity PlexMarkPlexScottishclimbsComPlexWebFirefoxWindows => new(_haContext, "media_player.plex_mark_plex_scottishclimbs_com_plex_web_firefox_windows");
		///<summary>Plex (Plex Cast - Chromecast)</summary>
		public MediaPlayerEntity PlexPlexCastChromecast => new(_haContext, "media_player.plex_plex_cast_chromecast");
		///<summary>Plex (Squiggley - Plex for Android (Mobile) - Galaxy Tab S7)</summary>
		public MediaPlayerEntity PlexPlexForAndroidMobileGalaxyTabS7 => new(_haContext, "media_player.plex_plex_for_android_mobile_galaxy_tab_s7");
		///<summary>Plex (Plex for Android (Mobile) - HUAWEI MediaPad M5 8.4)</summary>
		public MediaPlayerEntity PlexPlexForAndroidMobileHuaweiMediapadM584 => new(_haContext, "media_player.plex_plex_for_android_mobile_huawei_mediapad_m5_8_4");
		///<summary>Plex (Plex for Android (Mobile) - Pixel 4a)</summary>
		public MediaPlayerEntity PlexPlexForAndroidMobilePixel4a => new(_haContext, "media_player.plex_plex_for_android_mobile_pixel_4a");
		///<summary>Plex (Plex for Android (Mobile) - SquigglePad)</summary>
		public MediaPlayerEntity PlexPlexForAndroidMobileSmT870 => new(_haContext, "media_player.plex_plex_for_android_mobile_sm_t870");
		///<summary>Plex (Plex for Android (TV) - Squiggle vision     )</summary>
		public MediaPlayerEntity PlexPlexForAndroidTvChromecast => new(_haContext, "media_player.plex_plex_for_android_tv_chromecast");
		///<summary>Plex (Plex for Android (TV) - SHIELD Android TV)</summary>
		public MediaPlayerEntity PlexPlexForAndroidTvShieldAndroidTv => new(_haContext, "media_player.plex_plex_for_android_tv_shield_android_tv");
		///<summary>Plex (Plex for Android (TV) - Marvin)</summary>
		public MediaPlayerEntity PlexPlexForAndroidTvShieldAndroidTv2 => new(_haContext, "media_player.plex_plex_for_android_tv_shield_android_tv_2");
		///<summary>Plex (Plex for Android (TV) - Zaphod)</summary>
		public MediaPlayerEntity PlexPlexForAndroidTvZaphod => new(_haContext, "media_player.plex_plex_for_android_tv_zaphod");
		///<summary>Plex (WeeBear - Plex for iOS - iPad (3))</summary>
		public MediaPlayerEntity PlexPlexForIosIpad => new(_haContext, "media_player.plex_plex_for_ios_ipad");
		///<summary>Plex (Plex Web - Chrome)</summary>
		public MediaPlayerEntity PlexPlexWebChrome => new(_haContext, "media_player.plex_plex_web_chrome");
		///<summary>Plex (Plex Web - Chrome)</summary>
		public MediaPlayerEntity PlexPlexWebChrome2 => new(_haContext, "media_player.plex_plex_web_chrome_2");
		///<summary>Plex (Plex Web - Chrome)</summary>
		public MediaPlayerEntity PlexPlexWebChrome3 => new(_haContext, "media_player.plex_plex_web_chrome_3");
		///<summary>Plex (Plex Web - Chrome)</summary>
		public MediaPlayerEntity PlexPlexWebChrome4 => new(_haContext, "media_player.plex_plex_web_chrome_4");
		///<summary>Plex (Plex Web - Chrome)</summary>
		public MediaPlayerEntity PlexPlexWebChrome5 => new(_haContext, "media_player.plex_plex_web_chrome_5");
		///<summary>Plex (Squiggley - Plex Web - Chrome - Android)</summary>
		public MediaPlayerEntity PlexPlexWebChrome6 => new(_haContext, "media_player.plex_plex_web_chrome_6");
		///<summary>Plex (Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexPlexWebChromeLinux => new(_haContext, "media_player.plex_plex_web_chrome_linux");
		///<summary>Plex (Plex Web - Chrome - Windows)</summary>
		public MediaPlayerEntity PlexPlexWebChromeWindows => new(_haContext, "media_player.plex_plex_web_chrome_windows");
		///<summary>Plex (Plex Web - Firefox)</summary>
		public MediaPlayerEntity PlexPlexWebFirefox => new(_haContext, "media_player.plex_plex_web_firefox");
		///<summary>Plex (Plex Web - Firefox)</summary>
		public MediaPlayerEntity PlexPlexWebFirefox2 => new(_haContext, "media_player.plex_plex_web_firefox_2");
		///<summary>Plex (Plex Web - Firefox - Android)</summary>
		public MediaPlayerEntity PlexPlexWebFirefoxAndroid => new(_haContext, "media_player.plex_plex_web_firefox_android");
		///<summary>Plex (Plex Web - Firefox - Android)</summary>
		public MediaPlayerEntity PlexPlexWebFirefoxAndroid2 => new(_haContext, "media_player.plex_plex_web_firefox_android_2");
		///<summary>Plex (Plex Web - Firefox - Windows)</summary>
		public MediaPlayerEntity PlexPlexWebFirefoxWindows => new(_haContext, "media_player.plex_plex_web_firefox_windows");
		///<summary>Plex (Plex Web - Firefox - Windows)</summary>
		public MediaPlayerEntity PlexPlexWebFirefoxWindows2 => new(_haContext, "media_player.plex_plex_web_firefox_windows_2");
		///<summary>Plex (Plex Web - Firefox - Windows)</summary>
		public MediaPlayerEntity PlexPlexWebFirefoxWindows3 => new(_haContext, "media_player.plex_plex_web_firefox_windows_3");
		///<summary>Plex (Plex Web - Firefox - Windows)</summary>
		public MediaPlayerEntity PlexPlexWebFirefoxWindows4 => new(_haContext, "media_player.plex_plex_web_firefox_windows_4");
		///<summary>Plex (Plex Web - Microsoft Edge)</summary>
		public MediaPlayerEntity PlexPlexWebMicrosoftEdge => new(_haContext, "media_player.plex_plex_web_microsoft_edge");
		///<summary>Plex (Plex Web - Microsoft Edge)</summary>
		public MediaPlayerEntity PlexPlexWebMicrosoftEdge2 => new(_haContext, "media_player.plex_plex_web_microsoft_edge_2");
		///<summary>Plex (Plex Web - Microsoft Edge)</summary>
		public MediaPlayerEntity PlexPlexWebMicrosoftEdge3 => new(_haContext, "media_player.plex_plex_web_microsoft_edge_3");
		///<summary>Plex (Squiggley - Plex Web - Microsoft Edge - Android)</summary>
		public MediaPlayerEntity PlexPlexWebMicrosoftEdgeAndroid => new(_haContext, "media_player.plex_plex_web_microsoft_edge_android");
		///<summary>Plex (Plex Web - Microsoft Edge - Linux)</summary>
		public MediaPlayerEntity PlexPlexWebMicrosoftEdgeLinux => new(_haContext, "media_player.plex_plex_web_microsoft_edge_linux");
		///<summary>Plex (Plex Web - Microsoft Edge)</summary>
		public MediaPlayerEntity PlexPlexWebMicrosoftEdgeWindows => new(_haContext, "media_player.plex_plex_web_microsoft_edge_windows");
		///<summary>Plex (Plex Web - Microsoft Edge)</summary>
		public MediaPlayerEntity PlexPlexWebMicrosoftEdgeWindows2 => new(_haContext, "media_player.plex_plex_web_microsoft_edge_windows_2");
		///<summary>Plex (Plex Web - Safari)</summary>
		public MediaPlayerEntity PlexPlexWebSafari => new(_haContext, "media_player.plex_plex_web_safari");
		///<summary>Plex (Plexamp - Android)</summary>
		public MediaPlayerEntity PlexPlexampAndroid => new(_haContext, "media_player.plex_plexamp_android");
		///<summary>Plex (Plexamp - SquiggleAmp)</summary>
		public MediaPlayerEntity PlexPlexampAndroid2 => new(_haContext, "media_player.plex_plexamp_android_2");
		///<summary>Plex (Plexamp - Android)</summary>
		public MediaPlayerEntity PlexPlexampAndroid3 => new(_haContext, "media_player.plex_plexamp_android_3");
		///<summary>Plex (Plexamp - Android)</summary>
		public MediaPlayerEntity PlexPlexampAndroid4 => new(_haContext, "media_player.plex_plexamp_android_4");
		///<summary>Plex (Plexamp - Golgafrincham)</summary>
		public MediaPlayerEntity PlexPlexampGolgafrincham => new(_haContext, "media_player.plex_plexamp_golgafrincham");
		///<summary>Plex (Plexamp - Golgafrincham)</summary>
		public MediaPlayerEntity PlexPlexampGolgafrincham2 => new(_haContext, "media_player.plex_plexamp_golgafrincham_2");
		///<summary>Plex (renaroomartin@yahoo.co.uk - Plex Cast - Chromecast)</summary>
		public MediaPlayerEntity PlexRenaroomartinYahooCoUkPlexCastChromecast => new(_haContext, "media_player.plex_renaroomartin_yahoo_co_uk_plex_cast_chromecast");
		///<summary>Plex (renaroomartin@yahoo.co.uk - Plex Web - Chrome - Android)</summary>
		public MediaPlayerEntity PlexRenaroomartinYahooCoUkPlexWebChromeAndroid => new(_haContext, "media_player.plex_renaroomartin_yahoo_co_uk_plex_web_chrome_android");
		///<summary>Plex (renaroomartin@yahoo.co.uk - Plex Web - Firefox - Windows)</summary>
		public MediaPlayerEntity PlexRenaroomartinYahooCoUkPlexWebFirefoxWindows => new(_haContext, "media_player.plex_renaroomartin_yahoo_co_uk_plex_web_firefox_windows");
		///<summary>Plex (renaroomartin@yahoo.co.uk - Plex Web - Firefox - Windows)</summary>
		public MediaPlayerEntity PlexRenaroomartinYahooCoUkPlexWebFirefoxWindows2 => new(_haContext, "media_player.plex_renaroomartin_yahoo_co_uk_plex_web_firefox_windows_2");
		///<summary>Plex (savage.rax@gmail.com - Plex for Android (TV) - AFTT)</summary>
		public MediaPlayerEntity PlexSavageRaxGmailComPlexForAndroidTvAftt => new(_haContext, "media_player.plex_savage_rax_gmail_com_plex_for_android_tv_aftt");
		///<summary>Plex (savage.rax@gmail.com - Plex for Android (TV) - Fire TV Stick)</summary>
		public MediaPlayerEntity PlexSavageRaxGmailComPlexForAndroidTvFireTvStick => new(_haContext, "media_player.plex_savage_rax_gmail_com_plex_for_android_tv_fire_tv_stick");
		///<summary>Plex (savage.rax@gmail.com - Plex for Samsung - TV 2016)</summary>
		public MediaPlayerEntity PlexSavageRaxGmailComPlexForSamsungTv2016 => new(_haContext, "media_player.plex_savage_rax_gmail_com_plex_for_samsung_tv_2016");
		///<summary>Plex (savage.rax@gmail.com - Plex for Samsung - TV UE49KU6400)</summary>
		public MediaPlayerEntity PlexSavageRaxGmailComPlexForSamsungTvUe49ku6400 => new(_haContext, "media_player.plex_savage_rax_gmail_com_plex_for_samsung_tv_ue49ku6400");
		///<summary>Plex (savage.rax@gmail.com - Plex Web - Chrome - Android)</summary>
		public MediaPlayerEntity PlexSavageRaxGmailComPlexWebChromeAndroid => new(_haContext, "media_player.plex_savage_rax_gmail_com_plex_web_chrome_android");
		///<summary>Plex (savage.rax@gmail.com - Plex Web - Chrome - Android)</summary>
		public MediaPlayerEntity PlexSavageRaxGmailComPlexWebChromeAndroid2 => new(_haContext, "media_player.plex_savage_rax_gmail_com_plex_web_chrome_android_2");
		///<summary>Plex (savage.rax@gmail.com - Plex Web - Chrome - Android)</summary>
		public MediaPlayerEntity PlexSavageRaxGmailComPlexWebChromeAndroid3 => new(_haContext, "media_player.plex_savage_rax_gmail_com_plex_web_chrome_android_3");
		///<summary>Plex (scomartay@hotmail.co.uk - Plex for LG - LG 43UN81006LB)</summary>
		public MediaPlayerEntity PlexScomartayHotmailCoUkPlexForLgLg43un81006lb => new(_haContext, "media_player.plex_scomartay_hotmail_co_uk_plex_for_lg_lg_43un81006lb");
		///<summary>Plex (Squiggley - Plex Cast - Chromecast)</summary>
		public MediaPlayerEntity PlexSquiggleyPlexCastChromecast => new(_haContext, "media_player.plex_squiggley_plex_cast_chromecast");
		///<summary>Plex (WeeBear - Plex Cast - Chromecast)</summary>
		public MediaPlayerEntity PlexSquiggleyPlexCastChromecast2 => new(_haContext, "media_player.plex_squiggley_plex_cast_chromecast_2");
		///<summary>Plex (Squiggley - Plex Cast - Chromecast)</summary>
		public MediaPlayerEntity PlexSquiggleyPlexCastChromecast3 => new(_haContext, "media_player.plex_squiggley_plex_cast_chromecast_3");
		///<summary>Plex (Squiggley - Plex for Android (Mobile) - SHT-W09)</summary>
		public MediaPlayerEntity PlexSquiggleyPlexForAndroidMobileShtW09 => new(_haContext, "media_player.plex_squiggley_plex_for_android_mobile_sht_w09");
		///<summary>Plex (Plex for Android (Mobile) - King Squiggle Pad)</summary>
		public MediaPlayerEntity PlexSquiggleyPlexForAndroidMobileSmT970 => new(_haContext, "media_player.plex_squiggley_plex_for_android_mobile_sm_t970");
		///<summary>Plex (Squiggley - Plex Web - Chrome - Linux)</summary>
		public MediaPlayerEntity PlexSquiggleyPlexWebChromeLinux => new(_haContext, "media_player.plex_squiggley_plex_web_chrome_linux");
		///<summary>Plex (Plex Web - Chrome)</summary>
		public MediaPlayerEntity PlexSquiggleyPlexWebChromeWindows => new(_haContext, "media_player.plex_squiggley_plex_web_chrome_windows");
		///<summary>Plex (Squiggley - Plex Web - Chrome - Windows)</summary>
		public MediaPlayerEntity PlexSquiggleyPlexWebChromeWindows2 => new(_haContext, "media_player.plex_squiggley_plex_web_chrome_windows_2");
		///<summary>Plex (Squiggley - Plex Web - Microsoft Edge - Windows)</summary>
		public MediaPlayerEntity PlexSquiggleyPlexWebMicrosoftEdgeWindows => new(_haContext, "media_player.plex_squiggley_plex_web_microsoft_edge_windows");
		///<summary>Plex (Squiggley - Plex Web - Microsoft Edge - Windows)</summary>
		public MediaPlayerEntity PlexSquiggleyPlexWebMicrosoftEdgeWindows2 => new(_haContext, "media_player.plex_squiggley_plex_web_microsoft_edge_windows_2");
		///<summary>Plex (stevoid4@gmail.com - Plex for Android (Mobile) - KFONWI)</summary>
		public MediaPlayerEntity PlexStevoid4GmailComPlexForAndroidMobileKfonwi => new(_haContext, "media_player.plex_stevoid4_gmail_com_plex_for_android_mobile_kfonwi");
		///<summary>Plex (Stevara - Plex for PlayStation 4 - PS4-061)</summary>
		public MediaPlayerEntity PlexStevoid4GmailComPlexForPlaystation4Ps4061 => new(_haContext, "media_player.plex_stevoid4_gmail_com_plex_for_playstation_4_ps4_061");
		///<summary>Plex (stevoid4@gmail.com - Plex for Roku - Bedroom)</summary>
		public MediaPlayerEntity PlexStevoid4GmailComPlexForRokuBedroom => new(_haContext, "media_player.plex_stevoid4_gmail_com_plex_for_roku_bedroom");
		///<summary>Plex (stevoid4@gmail.com - Plex for Windows - HayReyPC)</summary>
		public MediaPlayerEntity PlexStevoid4GmailComPlexForWindowsHayreypc => new(_haContext, "media_player.plex_stevoid4_gmail_com_plex_for_windows_hayreypc");
		///<summary>Plex (tamtoucan@gmail.com - Plex for Android (Mobile) - Moto G (5th Gen))</summary>
		public MediaPlayerEntity PlexTamtoucanGmailComPlexForAndroidMobileMotoG5thGen => new(_haContext, "media_player.plex_tamtoucan_gmail_com_plex_for_android_mobile_moto_g_5th_gen");
		///<summary>Plex (tamtoucan@gmail.com - Plex for Android (Mobile) - Pixel 3a)</summary>
		public MediaPlayerEntity PlexTamtoucanGmailComPlexForAndroidMobilePixel3a => new(_haContext, "media_player.plex_tamtoucan_gmail_com_plex_for_android_mobile_pixel_3a");
		///<summary>Plex (TamToucan - Plex for Samsung - TV Samsung)</summary>
		public MediaPlayerEntity PlexTamtoucanGmailComPlexForSamsungTvUe40j5510 => new(_haContext, "media_player.plex_tamtoucan_gmail_com_plex_for_samsung_tv_ue40j5510");
		///<summary>Plex (tamtoucan@gmail.com - Plex Web - Firefox - Windows)</summary>
		public MediaPlayerEntity PlexTamtoucanGmailComPlexWebFirefoxWindows => new(_haContext, "media_player.plex_tamtoucan_gmail_com_plex_web_firefox_windows");
		///<summary>Plex (tamtoucan@gmail.com - Plex Web - Firefox - Windows)</summary>
		public MediaPlayerEntity PlexTamtoucanGmailComPlexWebFirefoxWindows2 => new(_haContext, "media_player.plex_tamtoucan_gmail_com_plex_web_firefox_windows_2");
		///<summary>Plex (tamtoucan@gmail.com - Plex Web - Firefox - Windows)</summary>
		public MediaPlayerEntity PlexTamtoucanGmailComPlexWebFirefoxWindows3 => new(_haContext, "media_player.plex_tamtoucan_gmail_com_plex_web_firefox_windows_3");
		///<summary>Plex (tamtoucan@gmail.com - Plexamp - Android)</summary>
		public MediaPlayerEntity PlexTamtoucanGmailComPlexampAndroid => new(_haContext, "media_player.plex_tamtoucan_gmail_com_plexamp_android");
		///<summary>Plex (Plexamp - Android)</summary>
		public MediaPlayerEntity PlexTamtoucanGmailComPlexampAndroid2 => new(_haContext, "media_player.plex_tamtoucan_gmail_com_plexamp_android_2");
		///<summary>Plex (tamtoucan@gmail.com - Plexamp - Android)</summary>
		public MediaPlayerEntity PlexTamtoucanGmailComPlexampAndroid3 => new(_haContext, "media_player.plex_tamtoucan_gmail_com_plexamp_android_3");
		///<summary>Plex (tamtoucan@gmail.com - Plexamp - Android)</summary>
		public MediaPlayerEntity PlexTamtoucanGmailComPlexampAndroid4 => new(_haContext, "media_player.plex_tamtoucan_gmail_com_plexamp_android_4");
		///<summary>Plex (katrindrafnar - Plex for Apple TV - stofa)</summary>
		public MediaPlayerEntity PlexWeeBeardrafnarPlexForAppleTvStofa => new(_haContext, "media_player.plex_wee_beardrafnar_plex_for_apple_tv_stofa");
		///<summary>Plex (katrindrafnar - Plex for iOS - iPad (2))</summary>
		public MediaPlayerEntity PlexWeeBeardrafnarPlexForIosIpad => new(_haContext, "media_player.plex_wee_beardrafnar_plex_for_ios_ipad");
		///<summary>Plex (katrindrafnar - Plex for iOS - Katrin's iPhone)</summary>
		public MediaPlayerEntity PlexWeeBeardrafnarPlexForIosIphone => new(_haContext, "media_player.plex_wee_beardrafnar_plex_for_ios_iphone");
		///<summary>Plex (wee_beardrafnar - Plex for PlayStation 4 - PS4-113)</summary>
		public MediaPlayerEntity PlexWeeBeardrafnarPlexForPlaystation4Ps4113 => new(_haContext, "media_player.plex_wee_beardrafnar_plex_for_playstation_4_ps4_113");
		///<summary>Plex (wee_beardrafnar - Plex for PlayStation 4 - PS4-113)</summary>
		public MediaPlayerEntity PlexWeeBeardrafnarPlexForPlaystation4Ps41132 => new(_haContext, "media_player.plex_wee_beardrafnar_plex_for_playstation_4_ps4_113_2");
		///<summary>Plex (wee_beardrafnar - Plex Web - Chrome - Windows)</summary>
		public MediaPlayerEntity PlexWeeBeardrafnarPlexWebChromeWindows => new(_haContext, "media_player.plex_wee_beardrafnar_plex_web_chrome_windows");
		///<summary>Plex (wee_beardrafnar - Plex Web - Chrome - Windows)</summary>
		public MediaPlayerEntity PlexWeeBeardrafnarPlexWebChromeWindows2 => new(_haContext, "media_player.plex_wee_beardrafnar_plex_web_chrome_windows_2");
		///<summary>Plex (WeeBear - Plex Cast - Chromecast)</summary>
		public MediaPlayerEntity PlexWeebearPlexCastChromecast => new(_haContext, "media_player.plex_weebear_plex_cast_chromecast");
		///<summary>Plex (WeeBear - Plex for iOS - iPhone)</summary>
		public MediaPlayerEntity PlexWeebearPlexForIosClairesIphone => new(_haContext, "media_player.plex_weebear_plex_for_ios_claires_iphone");
		///<summary>Plex (Plex for Android (TV) - Zaphod)</summary>
		public MediaPlayerEntity PlexZaphod => new(_haContext, "media_player.plex_zaphod");
		///<summary>Plex (zerojones23@gmail.com - Plex Web - Chrome - OSX)</summary>
		public MediaPlayerEntity PlexZerojones23GmailComPlexWebChromeOsx => new(_haContext, "media_player.plex_zerojones23_gmail_com_plex_web_chrome_osx");
		///<summary>Plex (zerojones23@gmail.com - Plex Web - Chrome - OSX)</summary>
		public MediaPlayerEntity PlexZerojones23GmailComPlexWebChromeOsx2 => new(_haContext, "media_player.plex_zerojones23_gmail_com_plex_web_chrome_osx_2");
		///<summary>Quest TV</summary>
		public MediaPlayerEntity QuestTv => new(_haContext, "media_player.quest_tv");
		///<summary>Zaphod Shield</summary>
		public MediaPlayerEntity Shield => new(_haContext, "media_player.shield");
		public MediaPlayerEntity Slartibartfarst => new(_haContext, "media_player.slartibartfarst");
		///<summary>Slartibartfarst</summary>
		public MediaPlayerEntity Slartibartfarst2 => new(_haContext, "media_player.slartibartfarst_2");
		///<summary>Slartibartfarst Shield</summary>
		public MediaPlayerEntity SlartibartfarstShield => new(_haContext, "media_player.slartibartfarst_shield");
		///<summary>squiggley_amp</summary>
		public MediaPlayerEntity SquiggleyAmp => new(_haContext, "media_player.squiggley_amp");
		///<summary>squiggley_amp Zone 2</summary>
		public MediaPlayerEntity SquiggleyAmpZone2 => new(_haContext, "media_player.squiggley_amp_zone_2");
		///<summary>[TV]SquiggleyTV</summary>
		public MediaPlayerEntity TvSquiggleytv => new(_haContext, "media_player.tv_squiggleytv");
		///<summary>vroomfondel</summary>
		public MediaPlayerEntity Vroomfondel => new(_haContext, "media_player.vroomfondel");
		///<summary>Vroomfondel</summary>
		public MediaPlayerEntity Vroomfondel2 => new(_haContext, "media_player.vroomfondel_2");
		public MediaPlayerEntity Zaphod => new(_haContext, "media_player.zaphod");
		///<summary>Zaphod Shield</summary>
		public MediaPlayerEntity ZaphodShield => new(_haContext, "media_player.zaphod_shield");
	}

	public class NumberEntities
	{
		private readonly IHaContext _haContext;
		public NumberEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Back Garden Motion occupancy timeout</summary>
		public NumberEntity BackGardenMotionOccupancyTimeout => new(_haContext, "number.back_garden_motion_occupancy_timeout");
		///<summary>Castle Motion occupancy timeout</summary>
		public NumberEntity CastleMotionOccupancyTimeout => new(_haContext, "number.castle_motion_occupancy_timeout");
		///<summary>Front Gate Motion occupancy timeout</summary>
		public NumberEntity FrontGateMotionOccupancyTimeout => new(_haContext, "number.front_gate_motion_occupancy_timeout");
		///<summary>Garage Roof Motion occupancy timeout</summary>
		public NumberEntity GarageRoofMotionOccupancyTimeout => new(_haContext, "number.garage_roof_motion_occupancy_timeout");
		///<summary>Kaggi II volume</summary>
		public NumberEntity KaggiIiVolume => new(_haContext, "number.kaggi_ii_volume");
		///<summary>LivingroomWLED Intensity</summary>
		public NumberEntity LivingroomwledIntensity => new(_haContext, "number.livingroomwled_intensity");
		///<summary>LivingroomWLED Speed</summary>
		public NumberEntity LivingroomwledSpeed => new(_haContext, "number.livingroomwled_speed");
		///<summary>ZaphodWLED Intensity</summary>
		public NumberEntity ZaphodwledIntensity => new(_haContext, "number.zaphodwled_intensity");
		///<summary>ZaphodWLED Speed</summary>
		public NumberEntity ZaphodwledSpeed => new(_haContext, "number.zaphodwled_speed");
	}

	public class PersistentNotificationEntities
	{
		private readonly IHaContext _haContext;
		public PersistentNotificationEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>New devices discovered</summary>
		public PersistentNotificationEntity ConfigEntryDiscovery => new(_haContext, "persistent_notification.config_entry_discovery");
	}

	public class PersonEntities
	{
		private readonly IHaContext _haContext;
		public PersonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Squiggley Woo</summary>
		public PersonEntity SquiggleyWoo => new(_haContext, "person.squiggley_woo");
		///<summary>Wee Bear</summary>
		public PersonEntity WeeBear => new(_haContext, "person.wee_bear");
	}

	public class RemoteEntities
	{
		private readonly IHaContext _haContext;
		public RemoteEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Kitchen Spiral Lights Remote</summary>
		public RemoteEntity KitchenSpiralLightsRemote => new(_haContext, "remote.kitchen_spiral_lights_remote");
		///<summary>Livingroom TV</summary>
		public RemoteEntity LivingroomTv => new(_haContext, "remote.livingroom_tv");
	}

	public class SceneEntities
	{
		private readonly IHaContext _haContext;
		public SceneEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Alarm: Lights Blue</summary>
		public SceneEntity AlarmLightsBlue => new(_haContext, "scene.alarm_lights_blue");
		///<summary>Alarm: Lights Off</summary>
		public SceneEntity AlarmLightsOff => new(_haContext, "scene.alarm_lights_off");
		///<summary>Alarm: Lights Red</summary>
		public SceneEntity AlarmLightsRed => new(_haContext, "scene.alarm_lights_red");
		///<summary>Alarm: Lights White</summary>
		public SceneEntity AlarmLightsWhite => new(_haContext, "scene.alarm_lights_white");
		///<summary>Nap Time</summary>
		public SceneEntity NapTime => new(_haContext, "scene.nap_time");
		///<summary>Normal Livingroom</summary>
		public SceneEntity NormalLivingroom => new(_haContext, "scene.normal_livingroom");
		///<summary>Orange Livingroom</summary>
		public SceneEntity OrangeLivingroom => new(_haContext, "scene.orange_livingroom");
		///<summary>Red Livingroom </summary>
		public SceneEntity RedLivingroom => new(_haContext, "scene.red_livingroom");
		///<summary>Zoom Lighting</summary>
		public SceneEntity ZoomLighting => new(_haContext, "scene.zoom_lighting");
	}

	public class ScriptEntities
	{
		private readonly IHaContext _haContext;
		public ScriptEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Alarm: Flash Lights Script</summary>
		public ScriptEntity AlarmFlashLightsScript => new(_haContext, "script.alarm_flash_lights_script");
		///<summary>Alarm: Flash Loop</summary>
		public ScriptEntity AlarmFlashLoop => new(_haContext, "script.alarm_flash_loop");
		///<summary>Alarm: Voice Message and Siren</summary>
		public ScriptEntity AlarmVoiceMessageAndSiren => new(_haContext, "script.alarm_voice_message_and_siren");
		///<summary>Backgarden: Turn Off lights</summary>
		public ScriptEntity BackgardenTurnOffLights => new(_haContext, "script.backgarden_turn_off_lights");
		///<summary>Backgarden: Turn on lights</summary>
		public ScriptEntity BackgardenTurnOnLights => new(_haContext, "script.backgarden_turn_on_lights");
		///<summary>Deebot Clean</summary>
		public ScriptEntity DeebotClean => new(_haContext, "script.deebot_clean");
		///<summary>Deebot Room Queue</summary>
		public ScriptEntity DeebotRoomQueue => new(_haContext, "script.deebot_room_queue");
		///<summary>Doorbell: Stop Casting To Office Display After 30 Seconds</summary>
		public ScriptEntity DoorbellStopCastingToOfficeDisplayAfter30Seconds => new(_haContext, "script.doorbell_stop_casting_to_office_display_after_30_seconds");
		///<summary>Home Off</summary>
		public ScriptEntity HomeOff => new(_haContext, "script.home_off");
		///<summary>Home Off When Everyone Leaves</summary>
		public ScriptEntity HomeOffWhenEveryoneLeaves => new(_haContext, "script.home_off_when_everyone_leaves");
		///<summary>Make-up Time</summary>
		public ScriptEntity MakeupTime => new(_haContext, "script.makeup_time");
		///<summary>Marvin: Switch Profile To Squiggley</summary>
		public ScriptEntity MarvinSwitchProfileToSquiggley => new(_haContext, "script.marvin_switch_profile_to_squiggley");
		///<summary>Marvin: Switch Profile To Wee Bear</summary>
		public ScriptEntity MarvinSwitchProfileToWeeBear => new(_haContext, "script.marvin_switch_profile_to_wee_bear");
		///<summary>Pulselight</summary>
		public ScriptEntity PulselightAction => new(_haContext, "script.pulselight_action");
		///<summary>Pulse Loop</summary>
		public ScriptEntity PulselightLoop => new(_haContext, "script.pulselight_loop");
		///<summary>Pulselight Start</summary>
		public ScriptEntity PulselightStart => new(_haContext, "script.pulselight_start");
		///<summary>Pulselight Stop</summary>
		public ScriptEntity PulselightStop => new(_haContext, "script.pulselight_stop");
		///<summary>Send a message entered in the ui to the user selected in the ui</summary>
		public ScriptEntity SendMessageToUiSelectedUser => new(_haContext, "script.send_message_to_ui_selected_user");
		///<summary>Slartibartfarst: Switch Profile To Squiggley</summary>
		public ScriptEntity SlartibartfarstSwitchProfileToSquiggley => new(_haContext, "script.slartibartfarst_switch_profile_to_squiggley");
		///<summary>Slartibartfarst: Switch Profile To Wee Bear</summary>
		public ScriptEntity SlartibartfarstSwitchProfileToWeeBear => new(_haContext, "script.slartibartfarst_switch_profile_to_wee_bear");
		///<summary>Deactivate Stupid Box</summary>
		public ScriptEntity StupidBoxOff => new(_haContext, "script.stupid_box_off");
		///<summary>Activate Stupid Box</summary>
		public ScriptEntity StupidBoxOn => new(_haContext, "script.stupid_box_on");
		///<summary>Turn off all the lights</summary>
		public ScriptEntity TurnAllLightsOff => new(_haContext, "script.turn_all_lights_off");
		///<summary>Turn Off Downstair Media Players</summary>
		public ScriptEntity TurnDownstairsMediaPlayersOff => new(_haContext, "script.turn_downstairs_media_players_off");
		///<summary>Turn Heating Off</summary>
		public ScriptEntity TurnHeatingOff => new(_haContext, "script.turn_heating_off");
		///<summary>Turn Heating On</summary>
		public ScriptEntity TurnHeatingOn => new(_haContext, "script.turn_heating_on");
		///<summary>Turn off all the lights except garden</summary>
		public ScriptEntity TurnOffAllTheLightsExceptGarden => new(_haContext, "script.turn_off_all_the_lights_except_garden");
		///<summary>bring the office online</summary>
		public ScriptEntity TurnOnTheOffice => new(_haContext, "script.turn_on_the_office");
		///<summary>Turn sockets off</summary>
		public ScriptEntity TurnSocketsOff => new(_haContext, "script.turn_sockets_off");
		///<summary>Request mobile devices location update</summary>
		public ScriptEntity UpdateLocations => new(_haContext, "script.update_locations");
		///<summary>Vacuum Clean Zone</summary>
		public ScriptEntity VacuumCleanZone => new(_haContext, "script.vacuum_clean_zone");
		///<summary>Remote Back</summary>
		public ScriptEntity ZaphodBack => new(_haContext, "script.zaphod_back");
		///<summary>Remote Down</summary>
		public ScriptEntity ZaphodDown => new(_haContext, "script.zaphod_down");
		///<summary>Remote Home</summary>
		public ScriptEntity ZaphodHome => new(_haContext, "script.zaphod_home");
		///<summary>Remote Left</summary>
		public ScriptEntity ZaphodLeft => new(_haContext, "script.zaphod_left");
		///<summary>Remote Next</summary>
		public ScriptEntity ZaphodNext => new(_haContext, "script.zaphod_next");
		///<summary>Remote PlayPause</summary>
		public ScriptEntity ZaphodPlayPause => new(_haContext, "script.zaphod_play_pause");
		///<summary>Remote Playlist</summary>
		public ScriptEntity ZaphodPlaylist => new(_haContext, "script.zaphod_playlist");
		///<summary>Remote Prev</summary>
		public ScriptEntity ZaphodPrev => new(_haContext, "script.zaphod_prev");
		///<summary>Remote Right</summary>
		public ScriptEntity ZaphodRight => new(_haContext, "script.zaphod_right");
		///<summary>Remote Select</summary>
		public ScriptEntity ZaphodSelect => new(_haContext, "script.zaphod_select");
		///<summary>Remote Stop</summary>
		public ScriptEntity ZaphodStop => new(_haContext, "script.zaphod_stop");
		///<summary>Zaphod: Switch Profile To Squiggley</summary>
		public ScriptEntity ZaphodSwitchProfileToSquiggley => new(_haContext, "script.zaphod_switch_profile_to_squiggley");
		///<summary>Zaphod: Switch Profile To Wee Bear</summary>
		public ScriptEntity ZaphodSwitchProfileToWeeBear => new(_haContext, "script.zaphod_switch_profile_to_wee_bear");
		///<summary>Remote Up</summary>
		public ScriptEntity ZaphodUp => new(_haContext, "script.zaphod_up");
		///<summary>Volume Down</summary>
		public ScriptEntity ZaphodVolumeDown => new(_haContext, "script.zaphod_volume_down");
		///<summary>Volume Mute</summary>
		public ScriptEntity ZaphodVolumeMute => new(_haContext, "script.zaphod_volume_mute");
		///<summary>Volume Up</summary>
		public ScriptEntity ZaphodVolumeUp => new(_haContext, "script.zaphod_volume_up");
		///<summary>Zoom</summary>
		public ScriptEntity Zoom => new(_haContext, "script.zoom");
	}

	public class SelectEntities
	{
		private readonly IHaContext _haContext;
		public SelectEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Back Garden Motion motion sensitivity</summary>
		public SelectEntity BackGardenMotionMotionSensitivity => new(_haContext, "select.back_garden_motion_motion_sensitivity");
		///<summary>Castle Motion motion sensitivity</summary>
		public SelectEntity CastleMotionMotionSensitivity => new(_haContext, "select.castle_motion_motion_sensitivity");
		///<summary>Front Gate Motion motion sensitivity</summary>
		public SelectEntity FrontGateMotionMotionSensitivity => new(_haContext, "select.front_gate_motion_motion_sensitivity");
		///<summary>Garage Roof Motion motion sensitivity</summary>
		public SelectEntity GarageRoofMotionMotionSensitivity => new(_haContext, "select.garage_roof_motion_motion_sensitivity");
		///<summary>Kaggi II water amount</summary>
		public SelectEntity KaggiIiWaterAmount => new(_haContext, "select.kaggi_ii_water_amount");
		///<summary>LivingroomWLED Color Palette</summary>
		public SelectEntity LivingroomwledColorPalette => new(_haContext, "select.livingroomwled_color_palette");
		///<summary>LivingroomWLED Live Override</summary>
		public SelectEntity LivingroomwledLiveOverride => new(_haContext, "select.livingroomwled_live_override");
		///<summary>LivingroomWLED Playlist</summary>
		public SelectEntity LivingroomwledPlaylist => new(_haContext, "select.livingroomwled_playlist");
		///<summary>LivingroomWLED Preset</summary>
		public SelectEntity LivingroomwledPreset => new(_haContext, "select.livingroomwled_preset");
		///<summary>ZaphodWLED Color Palette</summary>
		public SelectEntity ZaphodwledColorPalette => new(_haContext, "select.zaphodwled_color_palette");
		///<summary>ZaphodWLED Live Override</summary>
		public SelectEntity ZaphodwledLiveOverride => new(_haContext, "select.zaphodwled_live_override");
		///<summary>ZaphodWLED Playlist</summary>
		public SelectEntity ZaphodwledPlaylist => new(_haContext, "select.zaphodwled_playlist");
		///<summary>ZaphodWLED Preset</summary>
		public SelectEntity ZaphodwledPreset => new(_haContext, "select.zaphodwled_preset");
	}

	public class SensorEntities
	{
		private readonly IHaContext _haContext;
		public SensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toilet Motion Sensor battery</summary>
		public NumericSensorEntity E0x00158d0001e196a4Battery => new(_haContext, "sensor.0x00158d0001e196a4_battery");
		///<summary>Toilet Motion Sensor linkquality</summary>
		public NumericSensorEntity E0x00158d0001e196a4Linkquality => new(_haContext, "sensor.0x00158d0001e196a4_linkquality");
		///<summary>Office Window Sensor One</summary>
		public NumericSensorEntity E0x00158d0002275d83Battery => new(_haContext, "sensor.0x00158d0002275d83_battery");
		///<summary>Office Window Sensor One</summary>
		public NumericSensorEntity E0x00158d0002275d83Linkquality => new(_haContext, "sensor.0x00158d0002275d83_linkquality");
		///<summary>Front Door Sensor battery</summary>
		public NumericSensorEntity E0x00158d0002275daeBattery => new(_haContext, "sensor.0x00158d0002275dae_battery");
		///<summary>Front Door Sensor linkquality</summary>
		public NumericSensorEntity E0x00158d0002275daeLinkquality => new(_haContext, "sensor.0x00158d0002275dae_linkquality");
		///<summary>Office Window Sensor Two battery</summary>
		public NumericSensorEntity E0x00158d0002277df1Battery => new(_haContext, "sensor.0x00158d0002277df1_battery");
		///<summary>Office Window Sensor Two linkquality</summary>
		public NumericSensorEntity E0x00158d0002277df1Linkquality => new(_haContext, "sensor.0x00158d0002277df1_linkquality");
		///<summary>Wee Bear Window Sensor One battery</summary>
		public NumericSensorEntity E0x00158d0002c62861Battery => new(_haContext, "sensor.0x00158d0002c62861_battery");
		///<summary>Wee Bear Window Sensor One linkquality</summary>
		public NumericSensorEntity E0x00158d0002c62861Linkquality => new(_haContext, "sensor.0x00158d0002c62861_linkquality");
		///<summary>Bedroom Window One linkquality</summary>
		public NumericSensorEntity E0x00158d000309bfdcLinkquality => new(_haContext, "sensor.0x00158d000309bfdc_linkquality");
		///<summary>0x00158d000431d9a1 battery</summary>
		public NumericSensorEntity E0x00158d000431d9a1Battery => new(_haContext, "sensor.0x00158d000431d9a1_battery");
		///<summary>0x00158d000431d9a1 linkquality</summary>
		public NumericSensorEntity E0x00158d000431d9a1Linkquality => new(_haContext, "sensor.0x00158d000431d9a1_linkquality");
		///<summary>0x00158d000431d9a1 voltage</summary>
		public NumericSensorEntity E0x00158d000431d9a1Voltage => new(_haContext, "sensor.0x00158d000431d9a1_voltage");
		///<summary>Back Door Sensor_battery</summary>
		public NumericSensorEntity BackDoorSensorBattery => new(_haContext, "sensor.back_door_sensor_battery");
		///<summary>Back Door Sensor_linkquality</summary>
		public NumericSensorEntity BackDoorSensorLinkquality => new(_haContext, "sensor.back_door_sensor_linkquality");
		///<summary>Back Door Sensor voltage</summary>
		public NumericSensorEntity BackDoorSensorVoltage => new(_haContext, "sensor.back_door_sensor_voltage");
		///<summary>Back Garden Motion battery</summary>
		public NumericSensorEntity BackGardenMotionBattery => new(_haContext, "sensor.back_garden_motion_battery");
		///<summary>Back Garden Motion illuminance lux</summary>
		public NumericSensorEntity BackGardenMotionIlluminanceLux => new(_haContext, "sensor.back_garden_motion_illuminance_lux");
		///<summary>Back Garden Motion temperature</summary>
		public NumericSensorEntity BackGardenMotionTemperature => new(_haContext, "sensor.back_garden_motion_temperature");
		///<summary>Back Garden Thermometer_battery</summary>
		public NumericSensorEntity BackGardenThermometerBattery => new(_haContext, "sensor.back_garden_thermometer_battery");
		///<summary>Back Garden Thermometer_humidity</summary>
		public NumericSensorEntity BackGardenThermometerHumidity => new(_haContext, "sensor.back_garden_thermometer_humidity");
		///<summary>Back Garden Thermometer_linkquality</summary>
		public NumericSensorEntity BackGardenThermometerLinkquality => new(_haContext, "sensor.back_garden_thermometer_linkquality");
		///<summary>Back Garden</summary>
		public NumericSensorEntity BackGardenThermometerTemperature => new(_haContext, "sensor.back_garden_thermometer_temperature");
		///<summary>Back Garden Thermometer voltage</summary>
		public NumericSensorEntity BackGardenThermometerVoltage => new(_haContext, "sensor.back_garden_thermometer_voltage");
		///<summary>Back Nut Hut</summary>
		public NumericSensorEntity BackNutHut => new(_haContext, "sensor.back_nut_hut");
		///<summary>Back Nut Hut Lid_battery</summary>
		public NumericSensorEntity BackNutHutLidBattery => new(_haContext, "sensor.back_nut_hut_lid_battery");
		///<summary>Back Nut Hut Lid_linkquality</summary>
		public NumericSensorEntity BackNutHutLidLinkquality => new(_haContext, "sensor.back_nut_hut_lid_linkquality");
		///<summary>Back Nut Hut Lid voltage</summary>
		public NumericSensorEntity BackNutHutLidVoltage => new(_haContext, "sensor.back_nut_hut_lid_voltage");
		///<summary>back_wall_ceiling_three Wifi</summary>
		public NumericSensorEntity BackWallCeilingThreeWifi => new(_haContext, "sensor.back_wall_ceiling_three_wifi");
		///<summary>back_wall_ceiling_two Wifi</summary>
		public NumericSensorEntity BackWallCeilingTwoWifi2 => new(_haContext, "sensor.back_wall_ceiling_two_wifi_2");
		///<summary>bathroom_ceiling_one Wifi</summary>
		public NumericSensorEntity BathroomCeilingOneWifi => new(_haContext, "sensor.bathroom_ceiling_one_wifi");
		///<summary>bathroom_ceiling_two Wifi</summary>
		public NumericSensorEntity BathroomCeilingTwoWifi => new(_haContext, "sensor.bathroom_ceiling_two_wifi");
		///<summary>Bathroom Colour Light Switch battery</summary>
		public NumericSensorEntity BathroomColourLightSwitchBattery => new(_haContext, "sensor.bathroom_colour_light_switch_battery");
		///<summary>Bathroom Colour Light Switch linkquality</summary>
		public NumericSensorEntity BathroomColourLightSwitchLinkquality => new(_haContext, "sensor.bathroom_colour_light_switch_linkquality");
		///<summary>Bathroom Colour Light Switch voltage</summary>
		public NumericSensorEntity BathroomColourLightSwitchVoltage => new(_haContext, "sensor.bathroom_colour_light_switch_voltage");
		///<summary>Bathroom Wall Switch battery</summary>
		public NumericSensorEntity BathroomWallSwitchBattery => new(_haContext, "sensor.bathroom_wall_switch_battery");
		///<summary>Bathroom Window Sensor_battery</summary>
		public NumericSensorEntity BathroomWindowSensorBattery => new(_haContext, "sensor.bathroom_window_sensor_battery");
		///<summary>Bathroom Window Sensor_linkquality</summary>
		public NumericSensorEntity BathroomWindowSensorLinkquality => new(_haContext, "sensor.bathroom_window_sensor_linkquality");
		///<summary>Bathroom Window Sensor temperature</summary>
		public NumericSensorEntity BathroomWindowSensorTemperature => new(_haContext, "sensor.bathroom_window_sensor_temperature");
		///<summary>Bathroom Window Sensor voltage</summary>
		public NumericSensorEntity BathroomWindowSensorVoltage => new(_haContext, "sensor.bathroom_window_sensor_voltage");
		///<summary>SquigglePad Battery Level</summary>
		public NumericSensorEntity BatteryLevel2 => new(_haContext, "sensor.battery_level_2");
		///<summary>bear_stripper Wifi</summary>
		public NumericSensorEntity BearStripperWifi => new(_haContext, "sensor.bear_stripper_wifi");
		///<summary>bed_sensor Wifi</summary>
		public NumericSensorEntity BedSensorWifi => new(_haContext, "sensor.bed_sensor_wifi");
		///<summary>Current Temperature</summary>
		public NumericSensorEntity BedroomCurrentTemperature => new(_haContext, "sensor.bedroom_current_temperature");
		///<summary>Target Temperature</summary>
		public NumericSensorEntity BedroomTargetTemperature => new(_haContext, "sensor.bedroom_target_temperature");
		///<summary>Bedroom Wall Switch battery</summary>
		public NumericSensorEntity BedroomWallSwitchBattery => new(_haContext, "sensor.bedroom_wall_switch_battery");
		///<summary>Bedroom Window One temperature</summary>
		public NumericSensorEntity BedroomWindowOneTemperature => new(_haContext, "sensor.bedroom_window_one_temperature");
		///<summary>Bedroom Window One voltage</summary>
		public NumericSensorEntity BedroomWindowOneVoltage => new(_haContext, "sensor.bedroom_window_one_voltage");
		///<summary>Bedroom Window Sensor One_battery</summary>
		public NumericSensorEntity BedroomWindowSensorOneBattery => new(_haContext, "sensor.bedroom_window_sensor_one_battery");
		///<summary>Bedroom Window Sensor Two_battery</summary>
		public NumericSensorEntity BedroomWindowSensorTwoBattery => new(_haContext, "sensor.bedroom_window_sensor_two_battery");
		///<summary>Bedroom Window Sensor Two_linkquality</summary>
		public NumericSensorEntity BedroomWindowSensorTwoLinkquality => new(_haContext, "sensor.bedroom_window_sensor_two_linkquality");
		///<summary>Bedroom Window Two temperature</summary>
		public NumericSensorEntity BedroomWindowTwoTemperature => new(_haContext, "sensor.bedroom_window_two_temperature");
		///<summary>Bedroom Window Two voltage</summary>
		public NumericSensorEntity BedroomWindowTwoVoltage => new(_haContext, "sensor.bedroom_window_two_voltage");
		///<summary>BigSquigglePad Battery Temperature</summary>
		public NumericSensorEntity BigsquigglepadBatteryTemperature => new(_haContext, "sensor.bigsquigglepad_battery_temperature");
		///<summary>BigSquigglePad RX</summary>
		public NumericSensorEntity BigsquigglepadRx => new(_haContext, "sensor.bigsquigglepad_rx");
		///<summary>BigSquigglePad TX</summary>
		public NumericSensorEntity BigsquigglepadTx => new(_haContext, "sensor.bigsquigglepad_tx");
		///<summary>Bridge Crossings</summary>
		public NumericSensorEntity BridgeCrossings => new(_haContext, "sensor.bridge_crossings");
		///<summary>Castle Motion battery</summary>
		public NumericSensorEntity CastleMotionBattery => new(_haContext, "sensor.castle_motion_battery");
		///<summary>Castle Motion illuminance lux</summary>
		public NumericSensorEntity CastleMotionIlluminanceLux => new(_haContext, "sensor.castle_motion_illuminance_lux");
		///<summary>Castle Motion temperature</summary>
		public NumericSensorEntity CastleMotionTemperature => new(_haContext, "sensor.castle_motion_temperature");
		///<summary>christmas_tree Apparent Power</summary>
		public NumericSensorEntity ChristmasTreeApparentPower => new(_haContext, "sensor.christmas_tree_apparent_power");
		///<summary>christmas_tree Current</summary>
		public NumericSensorEntity ChristmasTreeCurrent => new(_haContext, "sensor.christmas_tree_current");
		///<summary>christmas_tree Power</summary>
		public NumericSensorEntity ChristmasTreePower => new(_haContext, "sensor.christmas_tree_power");
		///<summary>christmas_tree Total Daily Energy</summary>
		public NumericSensorEntity ChristmasTreeTotalDailyEnergy => new(_haContext, "sensor.christmas_tree_total_daily_energy");
		///<summary>christmas_tree Voltage</summary>
		public NumericSensorEntity ChristmasTreeVoltage => new(_haContext, "sensor.christmas_tree_voltage");
		///<summary>Claire’s iPhone Average Active Pace</summary>
		public NumericSensorEntity ClairesIphoneAverageActivePace => new(_haContext, "sensor.claires_iphone_average_active_pace");
		///<summary>Claire’s iPhone level</summary>
		public NumericSensorEntity ClairesIphoneBatteryLevel => new(_haContext, "sensor.claires_iphone_battery_level");
		///<summary>Claire’s iPhone Battery Level</summary>
		public NumericSensorEntity ClairesIphoneBatteryLevel2 => new(_haContext, "sensor.claires_iphone_battery_level_2");
		///<summary>Claire’s iPhone Distance</summary>
		public NumericSensorEntity ClairesIphoneDistance => new(_haContext, "sensor.claires_iphone_distance");
		///<summary>Claire’s iPhone Floors Ascended</summary>
		public NumericSensorEntity ClairesIphoneFloorsAscended => new(_haContext, "sensor.claires_iphone_floors_ascended");
		///<summary>Claire’s iPhone Floors Descended</summary>
		public NumericSensorEntity ClairesIphoneFloorsDescended => new(_haContext, "sensor.claires_iphone_floors_descended");
		///<summary>Claire’s iPhone Steps</summary>
		public NumericSensorEntity ClairesIphoneSteps => new(_haContext, "sensor.claires_iphone_steps");
		///<summary>Claire’s iPhone Storage</summary>
		public NumericSensorEntity ClairesIphoneStorage => new(_haContext, "sensor.claires_iphone_storage");
		///<summary>cooking_ceiling_one RX</summary>
		public NumericSensorEntity CookingCeilingOneRx2 => new(_haContext, "sensor.cooking_ceiling_one_rx_2");
		///<summary>cooking_ceiling_one TX</summary>
		public NumericSensorEntity CookingCeilingOneTx2 => new(_haContext, "sensor.cooking_ceiling_one_tx_2");
		///<summary>Corstorphine Probability of Precipitation 3-Hourly</summary>
		public NumericSensorEntity CorstorphineProbabilityOfPrecipitation => new(_haContext, "sensor.corstorphine_probability_of_precipitation");
		///<summary>Corstorphine Temperature 3-Hourly</summary>
		public NumericSensorEntity CorstorphineTemperature => new(_haContext, "sensor.corstorphine_temperature");
		///<summary>Corstorphine UV Index 3-Hourly</summary>
		public NumericSensorEntity CorstorphineUvIndex => new(_haContext, "sensor.corstorphine_uv_index");
		///<summary>Corstorphine Wind Speed 3-Hourly</summary>
		public NumericSensorEntity CorstorphineWindSpeed => new(_haContext, "sensor.corstorphine_wind_speed");
		///<summary>Cricket-One CPU Frequency Current</summary>
		public NumericSensorEntity CricketOneCpuFrequencyCurrent => new(_haContext, "sensor.cricket_one_cpu_frequency_current");
		///<summary>Cricket-One CPU Load Average Fifteen Minute</summary>
		public NumericSensorEntity CricketOneCpuLoadAverageFifteenMinute => new(_haContext, "sensor.cricket_one_cpu_load_average_fifteen_minute");
		///<summary>Cricket-One CPU Load Average Five Minute</summary>
		public NumericSensorEntity CricketOneCpuLoadAverageFiveMinute => new(_haContext, "sensor.cricket_one_cpu_load_average_five_minute");
		///<summary>Cricket-One CPU Load Average One Minute</summary>
		public NumericSensorEntity CricketOneCpuLoadAverageOneMinute => new(_haContext, "sensor.cricket_one_cpu_load_average_one_minute");
		///<summary>Cricket-One CPU Usage</summary>
		public NumericSensorEntity CricketOneCpuUsage => new(_haContext, "sensor.cricket_one_cpu_usage");
		///<summary>Cricket-One DHCP Leases Online</summary>
		public NumericSensorEntity CricketOneDhcpLeasesOnline => new(_haContext, "sensor.cricket_one_dhcp_leases_online");
		///<summary>Cricket-One Filesystem Used Percentage slash</summary>
		public NumericSensorEntity CricketOneFilesystemUsedPercentageSlash => new(_haContext, "sensor.cricket_one_filesystem_used_percentage_slash");
		///<summary>Cricket-One Filesystem Used Percentage slash_var_slash_run</summary>
		public NumericSensorEntity CricketOneFilesystemUsedPercentageSlashVarSlashRun => new(_haContext, "sensor.cricket_one_filesystem_used_percentage_slash_var_slash_run");
		///<summary>Cricket-One Gateway PIASWEDENGATEWAY_VPNV4 delay</summary>
		public NumericSensorEntity CricketOneGatewayPiaswedengatewayVpnv4Delay => new(_haContext, "sensor.cricket_one_gateway_piaswedengateway_vpnv4_delay");
		///<summary>Cricket-One Gateway PIASWEDENGATEWAY_VPNV4 loss</summary>
		public NumericSensorEntity CricketOneGatewayPiaswedengatewayVpnv4Loss => new(_haContext, "sensor.cricket_one_gateway_piaswedengateway_vpnv4_loss");
		///<summary>Cricket-One Gateway PIASWEDENGATEWAY_VPNV4 stddev</summary>
		public NumericSensorEntity CricketOneGatewayPiaswedengatewayVpnv4Stddev => new(_haContext, "sensor.cricket_one_gateway_piaswedengateway_vpnv4_stddev");
		///<summary>Cricket-One Gateway WAN_DHCP delay</summary>
		public NumericSensorEntity CricketOneGatewayWanDhcpDelay => new(_haContext, "sensor.cricket_one_gateway_wan_dhcp_delay");
		///<summary>Cricket-One Gateway WAN_DHCP loss</summary>
		public NumericSensorEntity CricketOneGatewayWanDhcpLoss => new(_haContext, "sensor.cricket_one_gateway_wan_dhcp_loss");
		///<summary>Cricket-One Gateway WAN_DHCP stddev</summary>
		public NumericSensorEntity CricketOneGatewayWanDhcpStddev => new(_haContext, "sensor.cricket_one_gateway_wan_dhcp_stddev");
		///<summary>Cricket-One Interface LAN inbytes_kilobytes_per_second</summary>
		public NumericSensorEntity CricketOneInterfaceLanInbytesKilobytesPerSecond => new(_haContext, "sensor.cricket_one_interface_lan_inbytes_kilobytes_per_second");
		///<summary>Cricket-One Interface LAN inpkts_packets_per_second</summary>
		public NumericSensorEntity CricketOneInterfaceLanInpktsPacketsPerSecond => new(_haContext, "sensor.cricket_one_interface_lan_inpkts_packets_per_second");
		///<summary>Cricket-One Interface LAN outbytes_kilobytes_per_second</summary>
		public NumericSensorEntity CricketOneInterfaceLanOutbytesKilobytesPerSecond => new(_haContext, "sensor.cricket_one_interface_lan_outbytes_kilobytes_per_second");
		///<summary>Cricket-One Interface LAN outpkts_packets_per_second</summary>
		public NumericSensorEntity CricketOneInterfaceLanOutpktsPacketsPerSecond => new(_haContext, "sensor.cricket_one_interface_lan_outpkts_packets_per_second");
		///<summary>Cricket-One Interface PIANETHERLANDS inbytes_kilobytes_per_second</summary>
		public NumericSensorEntity CricketOneInterfacePianetherlandsInbytesKilobytesPerSecond => new(_haContext, "sensor.cricket_one_interface_pianetherlands_inbytes_kilobytes_per_second");
		///<summary>Cricket-One Interface PIANETHERLANDS inpkts_packets_per_second</summary>
		public NumericSensorEntity CricketOneInterfacePianetherlandsInpktsPacketsPerSecond => new(_haContext, "sensor.cricket_one_interface_pianetherlands_inpkts_packets_per_second");
		///<summary>Cricket-One Interface PIANETHERLANDS outbytes_kilobytes_per_second</summary>
		public NumericSensorEntity CricketOneInterfacePianetherlandsOutbytesKilobytesPerSecond => new(_haContext, "sensor.cricket_one_interface_pianetherlands_outbytes_kilobytes_per_second");
		///<summary>Cricket-One Interface PIANETHERLANDS outpkts_packets_per_second</summary>
		public NumericSensorEntity CricketOneInterfacePianetherlandsOutpktsPacketsPerSecond => new(_haContext, "sensor.cricket_one_interface_pianetherlands_outpkts_packets_per_second");
		///<summary>Cricket-One Interface SQUIGGLEYWORK inbytes_kilobytes_per_second</summary>
		public NumericSensorEntity CricketOneInterfaceSquiggleyworkInbytesKilobytesPerSecond => new(_haContext, "sensor.cricket_one_interface_squiggleywork_inbytes_kilobytes_per_second");
		///<summary>Cricket-One Interface SQUIGGLEYWORK inpkts_packets_per_second</summary>
		public NumericSensorEntity CricketOneInterfaceSquiggleyworkInpktsPacketsPerSecond => new(_haContext, "sensor.cricket_one_interface_squiggleywork_inpkts_packets_per_second");
		///<summary>Cricket-One Interface SQUIGGLEYWORK outbytes_kilobytes_per_second</summary>
		public NumericSensorEntity CricketOneInterfaceSquiggleyworkOutbytesKilobytesPerSecond => new(_haContext, "sensor.cricket_one_interface_squiggleywork_outbytes_kilobytes_per_second");
		///<summary>Cricket-One Interface SQUIGGLEYWORK outpkts_packets_per_second</summary>
		public NumericSensorEntity CricketOneInterfaceSquiggleyworkOutpktsPacketsPerSecond => new(_haContext, "sensor.cricket_one_interface_squiggleywork_outpkts_packets_per_second");
		///<summary>Cricket-One Interface WAN inbytes_kilobytes_per_second</summary>
		public NumericSensorEntity CricketOneInterfaceWanInbytesKilobytesPerSecond => new(_haContext, "sensor.cricket_one_interface_wan_inbytes_kilobytes_per_second");
		///<summary>Cricket-One Interface WAN inpkts_packets_per_second</summary>
		public NumericSensorEntity CricketOneInterfaceWanInpktsPacketsPerSecond => new(_haContext, "sensor.cricket_one_interface_wan_inpkts_packets_per_second");
		///<summary>Cricket-One Interface WAN outbytes_kilobytes_per_second</summary>
		public NumericSensorEntity CricketOneInterfaceWanOutbytesKilobytesPerSecond => new(_haContext, "sensor.cricket_one_interface_wan_outbytes_kilobytes_per_second");
		///<summary>Cricket-One Interface WAN outpkts_packets_per_second</summary>
		public NumericSensorEntity CricketOneInterfaceWanOutpktsPacketsPerSecond => new(_haContext, "sensor.cricket_one_interface_wan_outpkts_packets_per_second");
		///<summary>Wee Bear In</summary>
		public NumericSensorEntity CricketOneInterfaceWeebearworkInbytesKilobytesPerSecond => new(_haContext, "sensor.cricket_one_interface_weebearwork_inbytes_kilobytes_per_second");
		///<summary>Cricket-One Interface WEEBEARWORK inpkts_packets_per_second</summary>
		public NumericSensorEntity CricketOneInterfaceWeebearworkInpktsPacketsPerSecond => new(_haContext, "sensor.cricket_one_interface_weebearwork_inpkts_packets_per_second");
		///<summary>Wee Bear Out KB</summary>
		public NumericSensorEntity CricketOneInterfaceWeebearworkOutbytesKilobytesPerSecond => new(_haContext, "sensor.cricket_one_interface_weebearwork_outbytes_kilobytes_per_second");
		///<summary>Cricket-One Interface WEEBEARWORK outpkts_packets_per_second</summary>
		public NumericSensorEntity CricketOneInterfaceWeebearworkOutpktsPacketsPerSecond => new(_haContext, "sensor.cricket_one_interface_weebearwork_outpkts_packets_per_second");
		///<summary>Cricket-One Memory Buffers Used Percentage</summary>
		public NumericSensorEntity CricketOneMemoryBuffersUsedPercentage => new(_haContext, "sensor.cricket_one_memory_buffers_used_percentage");
		///<summary>Cricket-One Memory Swap Used Percentage</summary>
		public NumericSensorEntity CricketOneMemorySwapUsedPercentage => new(_haContext, "sensor.cricket_one_memory_swap_used_percentage");
		///<summary>Cricket-One Memory Used Percentage</summary>
		public NumericSensorEntity CricketOneMemoryUsedPercentage => new(_haContext, "sensor.cricket_one_memory_used_percentage");
		///<summary>Cricket-One pf State Table Used Percentage</summary>
		public NumericSensorEntity CricketOnePfStateTableUsedPercentage => new(_haContext, "sensor.cricket_one_pf_state_table_used_percentage");
		///<summary>Cricket-One System Boottime</summary>
		public NumericSensorEntity CricketOneSystemBoottime => new(_haContext, "sensor.cricket_one_system_boottime");
		///<summary>Cricket-One System Temperature</summary>
		public NumericSensorEntity CricketOneSystemTemperature => new(_haContext, "sensor.cricket_one_system_temperature");
		///<summary>Battery Level</summary>
		public NumericSensorEntity DeebotBatteryLevel => new(_haContext, "sensor.deebot_battery_level");
		///<summary>Last Clean Image</summary>
		public NumericSensorEntity DeebotLastCleanImage => new(_haContext, "sensor.deebot_last_clean_image");
		///<summary>Current State</summary>
		public NumericSensorEntity DeebotState => new(_haContext, "sensor.deebot_state");
		///<summary>Deep Sleep Yesterday</summary>
		public NumericSensorEntity DeepSleepYesterday => new(_haContext, "sensor.deep_sleep_yesterday");
		///<summary>Disk free /</summary>
		public NumericSensorEntity DiskFree => new(_haContext, "sensor.disk_free");
		///<summary>Disk use /</summary>
		public NumericSensorEntity DiskUse => new(_haContext, "sensor.disk_use");
		///<summary>Disk use (percent) /</summary>
		public NumericSensorEntity DiskUsePercent => new(_haContext, "sensor.disk_use_percent");
		///<summary>Disk use (percent) /home</summary>
		public NumericSensorEntity DiskUsePercentHome => new(_haContext, "sensor.disk_use_percent_home");
		///<summary>ESP_A3C825 RX</summary>
		public NumericSensorEntity EspA3c825Rx => new(_haContext, "sensor.esp_a3c825_rx");
		///<summary>ESP_A3C825 TX</summary>
		public NumericSensorEntity EspA3c825Tx => new(_haContext, "sensor.esp_a3c825_tx");
		///<summary>Fairy Lights ENERGY ApparentPower</summary>
		public NumericSensorEntity FairyLightsEnergyApparentpower => new(_haContext, "sensor.fairy_lights_energy_apparentpower");
		///<summary>Fairy Lights ENERGY Current</summary>
		public NumericSensorEntity FairyLightsEnergyCurrent => new(_haContext, "sensor.fairy_lights_energy_current");
		///<summary>Fairy Lights ENERGY Factor</summary>
		public NumericSensorEntity FairyLightsEnergyFactor => new(_haContext, "sensor.fairy_lights_energy_factor");
		///<summary>Fairy Lights ENERGY Power</summary>
		public NumericSensorEntity FairyLightsEnergyPower => new(_haContext, "sensor.fairy_lights_energy_power");
		///<summary>Fairy Lights ENERGY ReactivePower</summary>
		public NumericSensorEntity FairyLightsEnergyReactivepower => new(_haContext, "sensor.fairy_lights_energy_reactivepower");
		///<summary>Fairy Lights ENERGY Today</summary>
		public NumericSensorEntity FairyLightsEnergyToday => new(_haContext, "sensor.fairy_lights_energy_today");
		///<summary>Fairy Lights ENERGY Total</summary>
		public NumericSensorEntity FairyLightsEnergyTotal => new(_haContext, "sensor.fairy_lights_energy_total");
		///<summary>Fairy Lights ENERGY TotalStartTime</summary>
		public NumericSensorEntity FairyLightsEnergyTotalstarttime => new(_haContext, "sensor.fairy_lights_energy_totalstarttime");
		///<summary>Fairy Lights ENERGY Voltage</summary>
		public NumericSensorEntity FairyLightsEnergyVoltage => new(_haContext, "sensor.fairy_lights_energy_voltage");
		///<summary>Fairy Lights ENERGY Yesterday</summary>
		public NumericSensorEntity FairyLightsEnergyYesterday => new(_haContext, "sensor.fairy_lights_energy_yesterday");
		///<summary>Firework Lights ENERGY ApparentPower</summary>
		public NumericSensorEntity FireworkLightsEnergyApparentpower => new(_haContext, "sensor.firework_lights_energy_apparentpower");
		///<summary>Firework Lights ENERGY Current</summary>
		public NumericSensorEntity FireworkLightsEnergyCurrent => new(_haContext, "sensor.firework_lights_energy_current");
		///<summary>Firework Lights ENERGY Factor</summary>
		public NumericSensorEntity FireworkLightsEnergyFactor => new(_haContext, "sensor.firework_lights_energy_factor");
		///<summary>Firework Lights ENERGY Power</summary>
		public NumericSensorEntity FireworkLightsEnergyPower => new(_haContext, "sensor.firework_lights_energy_power");
		///<summary>Firework Lights ENERGY ReactivePower</summary>
		public NumericSensorEntity FireworkLightsEnergyReactivepower => new(_haContext, "sensor.firework_lights_energy_reactivepower");
		///<summary>Firework Lights ENERGY Today</summary>
		public NumericSensorEntity FireworkLightsEnergyToday => new(_haContext, "sensor.firework_lights_energy_today");
		///<summary>Firework Lights ENERGY Total</summary>
		public NumericSensorEntity FireworkLightsEnergyTotal => new(_haContext, "sensor.firework_lights_energy_total");
		///<summary>Firework Lights ENERGY TotalStartTime</summary>
		public NumericSensorEntity FireworkLightsEnergyTotalstarttime => new(_haContext, "sensor.firework_lights_energy_totalstarttime");
		///<summary>Firework Lights ENERGY Voltage</summary>
		public NumericSensorEntity FireworkLightsEnergyVoltage => new(_haContext, "sensor.firework_lights_energy_voltage");
		///<summary>Firework Lights ENERGY Yesterday</summary>
		public NumericSensorEntity FireworkLightsEnergyYesterday => new(_haContext, "sensor.firework_lights_energy_yesterday");
		///<summary>First Floor</summary>
		public NumericSensorEntity FirstFloor => new(_haContext, "sensor.first_floor");
		///<summary>Front Door Sensor voltage</summary>
		public NumericSensorEntity FrontDoorSensorVoltage => new(_haContext, "sensor.front_door_sensor_voltage");
		///<summary>Front Garden Thermometer_battery</summary>
		public NumericSensorEntity FrontGardenThermometerBattery => new(_haContext, "sensor.front_garden_thermometer_battery");
		///<summary>Front Garden Thermometer_humidity</summary>
		public NumericSensorEntity FrontGardenThermometerHumidity => new(_haContext, "sensor.front_garden_thermometer_humidity");
		///<summary>Front Garden Thermometer_linkquality</summary>
		public NumericSensorEntity FrontGardenThermometerLinkquality => new(_haContext, "sensor.front_garden_thermometer_linkquality");
		///<summary>Front Garden</summary>
		public NumericSensorEntity FrontGardenThermometerTemperature => new(_haContext, "sensor.front_garden_thermometer_temperature");
		///<summary>Front Garden Thermometer voltage</summary>
		public NumericSensorEntity FrontGardenThermometerVoltage => new(_haContext, "sensor.front_garden_thermometer_voltage");
		///<summary>Front Gate Motion battery</summary>
		public NumericSensorEntity FrontGateMotionBattery => new(_haContext, "sensor.front_gate_motion_battery");
		///<summary>Front Gate Motion illuminance lux</summary>
		public NumericSensorEntity FrontGateMotionIlluminanceLux => new(_haContext, "sensor.front_gate_motion_illuminance_lux");
		///<summary>Front Gate Motion temperature</summary>
		public NumericSensorEntity FrontGateMotionTemperature => new(_haContext, "sensor.front_gate_motion_temperature");
		///<summary>Front Nut Hut</summary>
		public NumericSensorEntity FrontNutHut => new(_haContext, "sensor.front_nut_hut");
		///<summary>Front Nut Hut Lid_battery</summary>
		public NumericSensorEntity FrontNutHutLidBattery => new(_haContext, "sensor.front_nut_hut_lid_battery");
		///<summary>Front Nut Hut Lid_linkquality</summary>
		public NumericSensorEntity FrontNutHutLidLinkquality => new(_haContext, "sensor.front_nut_hut_lid_linkquality");
		///<summary>Front Nut Hut Lid voltage</summary>
		public NumericSensorEntity FrontNutHutLidVoltage => new(_haContext, "sensor.front_nut_hut_lid_voltage");
		///<summary>Garage Door Sensor battery</summary>
		public NumericSensorEntity GarageDoorSensorBattery => new(_haContext, "sensor.garage_door_sensor_battery");
		///<summary>Garage Door Sensor linkquality</summary>
		public NumericSensorEntity GarageDoorSensorLinkquality => new(_haContext, "sensor.garage_door_sensor_linkquality");
		///<summary>Garage Door Sensor voltage</summary>
		public NumericSensorEntity GarageDoorSensorVoltage => new(_haContext, "sensor.garage_door_sensor_voltage");
		///<summary>Garage Roof Motion battery</summary>
		public NumericSensorEntity GarageRoofMotionBattery => new(_haContext, "sensor.garage_roof_motion_battery");
		///<summary>Garage Roof Motion illuminance lux</summary>
		public NumericSensorEntity GarageRoofMotionIlluminanceLux => new(_haContext, "sensor.garage_roof_motion_illuminance_lux");
		///<summary>Garage Roof Motion temperature</summary>
		public NumericSensorEntity GarageRoofMotionTemperature => new(_haContext, "sensor.garage_roof_motion_temperature");
		///<summary>hacs</summary>
		public NumericSensorEntity Hacs => new(_haContext, "sensor.hacs");
		///<summary>hall_ceiling_three Wifi</summary>
		public NumericSensorEntity HallCeilingThreeWifi => new(_haContext, "sensor.hall_ceiling_three_wifi");
		///<summary>hall_ceiling_two Wifi</summary>
		public NumericSensorEntity HallCeilingTwoWifi => new(_haContext, "sensor.hall_ceiling_two_wifi");
		///<summary>Hallway Light Switch One_battery</summary>
		public NumericSensorEntity HallwayLightSwitchOneBattery => new(_haContext, "sensor.hallway_light_switch_one_battery");
		///<summary>Hallway Light Switch One_linkquality</summary>
		public NumericSensorEntity HallwayLightSwitchOneLinkquality => new(_haContext, "sensor.hallway_light_switch_one_linkquality");
		///<summary>Hallway Light Switch One voltage</summary>
		public NumericSensorEntity HallwayLightSwitchOneVoltage => new(_haContext, "sensor.hallway_light_switch_one_voltage");
		///<summary>Home Off Switch_battery</summary>
		public NumericSensorEntity HomeOffSwitchBattery => new(_haContext, "sensor.home_off_switch_battery");
		///<summary>Home Off Switch_linkquality</summary>
		public NumericSensorEntity HomeOffSwitchLinkquality => new(_haContext, "sensor.home_off_switch_linkquality");
		///<summary>Home Off Switch voltage</summary>
		public NumericSensorEntity HomeOffSwitchVoltage => new(_haContext, "sensor.home_off_switch_voltage");
		///<summary>icicles Apparent Power</summary>
		public NumericSensorEntity IciclesApparentPower => new(_haContext, "sensor.icicles_apparent_power");
		///<summary>icicles Current</summary>
		public NumericSensorEntity IciclesCurrent => new(_haContext, "sensor.icicles_current");
		///<summary>icicles Power</summary>
		public NumericSensorEntity IciclesPower => new(_haContext, "sensor.icicles_power");
		///<summary>icicles Total Daily Energy</summary>
		public NumericSensorEntity IciclesTotalDailyEnergy => new(_haContext, "sensor.icicles_total_daily_energy");
		///<summary>icicles Voltage</summary>
		public NumericSensorEntity IciclesVoltage => new(_haContext, "sensor.icicles_voltage");
		///<summary>iPad Battery Level</summary>
		public NumericSensorEntity IpadBatteryLevel => new(_haContext, "sensor.ipad_battery_level");
		///<summary>iPad Storage</summary>
		public NumericSensorEntity IpadStorage => new(_haContext, "sensor.ipad_storage");
		///<summary>Kaggi II life span brush</summary>
		public NumericSensorEntity KaggiIiLifeSpanBrush => new(_haContext, "sensor.kaggi_ii_life_span_brush");
		///<summary>Kaggi II life span filter</summary>
		public NumericSensorEntity KaggiIiLifeSpanFilter => new(_haContext, "sensor.kaggi_ii_life_span_filter");
		///<summary>Kaggi II life span side brush</summary>
		public NumericSensorEntity KaggiIiLifeSpanSideBrush => new(_haContext, "sensor.kaggi_ii_life_span_side_brush");
		///<summary>Kaggi II stats area</summary>
		public NumericSensorEntity KaggiIiStatsArea => new(_haContext, "sensor.kaggi_ii_stats_area");
		///<summary>Kaggi II stats time</summary>
		public NumericSensorEntity KaggiIiStatsTime => new(_haContext, "sensor.kaggi_ii_stats_time");
		///<summary>Kaggi II stats total area</summary>
		public NumericSensorEntity KaggiIiStatsTotalArea => new(_haContext, "sensor.kaggi_ii_stats_total_area");
		///<summary>Kaggi II stats total time</summary>
		public NumericSensorEntity KaggiIiStatsTotalTime => new(_haContext, "sensor.kaggi_ii_stats_total_time");
		///<summary>Kettle ENERGY ApparentPower</summary>
		public NumericSensorEntity KettleEnergyApparentpower => new(_haContext, "sensor.kettle_energy_apparentpower");
		///<summary>Kettle ENERGY Current</summary>
		public NumericSensorEntity KettleEnergyCurrent => new(_haContext, "sensor.kettle_energy_current");
		///<summary>Kettle ENERGY Factor</summary>
		public NumericSensorEntity KettleEnergyFactor => new(_haContext, "sensor.kettle_energy_factor");
		///<summary>Kettle ENERGY Power</summary>
		public NumericSensorEntity KettleEnergyPower => new(_haContext, "sensor.kettle_energy_power");
		///<summary>Kettle ENERGY ReactivePower</summary>
		public NumericSensorEntity KettleEnergyReactivepower => new(_haContext, "sensor.kettle_energy_reactivepower");
		///<summary>Kettle ENERGY Today</summary>
		public NumericSensorEntity KettleEnergyToday => new(_haContext, "sensor.kettle_energy_today");
		///<summary>Kettle ENERGY Total</summary>
		public NumericSensorEntity KettleEnergyTotal => new(_haContext, "sensor.kettle_energy_total");
		///<summary>Kettle ENERGY TotalStartTime</summary>
		public NumericSensorEntity KettleEnergyTotalstarttime => new(_haContext, "sensor.kettle_energy_totalstarttime");
		///<summary>Kettle ENERGY Voltage</summary>
		public NumericSensorEntity KettleEnergyVoltage => new(_haContext, "sensor.kettle_energy_voltage");
		///<summary>Kettle ENERGY Yesterday</summary>
		public NumericSensorEntity KettleEnergyYesterday => new(_haContext, "sensor.kettle_energy_yesterday");
		///<summary>KingSquigglePad App Memory</summary>
		public NumericSensorEntity KingsquigglepadAppMemory => new(_haContext, "sensor.kingsquigglepad_app_memory");
		///<summary>KingSquigglePad App Rx GB</summary>
		public NumericSensorEntity KingsquigglepadAppRxGb => new(_haContext, "sensor.kingsquigglepad_app_rx_gb");
		///<summary>KingSquigglePad App Tx GB</summary>
		public NumericSensorEntity KingsquigglepadAppTxGb => new(_haContext, "sensor.kingsquigglepad_app_tx_gb");
		///<summary>KingSquigglePad Battery Level</summary>
		public NumericSensorEntity KingsquigglepadBatteryLevel => new(_haContext, "sensor.kingsquigglepad_battery_level");
		///<summary>KingSquigglePad Battery Temperature</summary>
		public NumericSensorEntity KingsquigglepadBatteryTemperature => new(_haContext, "sensor.kingsquigglepad_battery_temperature");
		///<summary>KingSquigglePad Bluetooth Connection</summary>
		public NumericSensorEntity KingsquigglepadBluetoothConnection => new(_haContext, "sensor.kingsquigglepad_bluetooth_connection");
		///<summary>KingSquigglePad External Storage</summary>
		public NumericSensorEntity KingsquigglepadExternalStorage => new(_haContext, "sensor.kingsquigglepad_external_storage");
		///<summary>KingSquigglePad Internal Storage</summary>
		public NumericSensorEntity KingsquigglepadInternalStorage => new(_haContext, "sensor.kingsquigglepad_internal_storage");
		///<summary>KingSquigglePad Light Sensor</summary>
		public NumericSensorEntity KingsquigglepadLightSensor => new(_haContext, "sensor.kingsquigglepad_light_sensor");
		///<summary>KingSquigglePad Sleep Confidence</summary>
		public NumericSensorEntity KingsquigglepadSleepConfidence => new(_haContext, "sensor.kingsquigglepad_sleep_confidence");
		///<summary>KingSquigglePad Sleep Segment</summary>
		public NumericSensorEntity KingsquigglepadSleepSegment => new(_haContext, "sensor.kingsquigglepad_sleep_segment");
		///<summary>KingSquigglePad Steps Sensor</summary>
		public NumericSensorEntity KingsquigglepadStepsSensor => new(_haContext, "sensor.kingsquigglepad_steps_sensor");
		///<summary>KingSquigglePad Total Rx GB</summary>
		public NumericSensorEntity KingsquigglepadTotalRxGb => new(_haContext, "sensor.kingsquigglepad_total_rx_gb");
		///<summary>KingSquigglePad Total Tx GB</summary>
		public NumericSensorEntity KingsquigglepadTotalTxGb => new(_haContext, "sensor.kingsquigglepad_total_tx_gb");
		///<summary>KingSquigglePad WiFi Frequency</summary>
		public NumericSensorEntity KingsquigglepadWifiFrequency => new(_haContext, "sensor.kingsquigglepad_wifi_frequency");
		///<summary>KingSquigglePad WiFi Link Speed</summary>
		public NumericSensorEntity KingsquigglepadWifiLinkSpeed => new(_haContext, "sensor.kingsquigglepad_wifi_link_speed");
		///<summary>KingSquigglePad WiFi Signal Strength</summary>
		public NumericSensorEntity KingsquigglepadWifiSignalStrength => new(_haContext, "sensor.kingsquigglepad_wifi_signal_strength");
		///<summary>Current Temperature</summary>
		public NumericSensorEntity KitchenCurrentTemperature => new(_haContext, "sensor.kitchen_current_temperature");
		///<summary>Kitchen Fairy Lights ENERGY ApparentPower</summary>
		public NumericSensorEntity KitchenFairyLightsEnergyApparentpower => new(_haContext, "sensor.kitchen_fairy_lights_energy_apparentpower");
		///<summary>Kitchen Fairy Lights ENERGY Current</summary>
		public NumericSensorEntity KitchenFairyLightsEnergyCurrent => new(_haContext, "sensor.kitchen_fairy_lights_energy_current");
		///<summary>Kitchen Fairy Lights ENERGY Factor</summary>
		public NumericSensorEntity KitchenFairyLightsEnergyFactor => new(_haContext, "sensor.kitchen_fairy_lights_energy_factor");
		///<summary>Kitchen Fairy Lights ENERGY Power</summary>
		public NumericSensorEntity KitchenFairyLightsEnergyPower => new(_haContext, "sensor.kitchen_fairy_lights_energy_power");
		///<summary>Kitchen Fairy Lights ENERGY ReactivePower</summary>
		public NumericSensorEntity KitchenFairyLightsEnergyReactivepower => new(_haContext, "sensor.kitchen_fairy_lights_energy_reactivepower");
		///<summary>Kitchen Fairy Lights ENERGY Today</summary>
		public NumericSensorEntity KitchenFairyLightsEnergyToday => new(_haContext, "sensor.kitchen_fairy_lights_energy_today");
		///<summary>Kitchen Fairy Lights ENERGY Total</summary>
		public NumericSensorEntity KitchenFairyLightsEnergyTotal => new(_haContext, "sensor.kitchen_fairy_lights_energy_total");
		///<summary>Kitchen Fairy Lights ENERGY TotalStartTime</summary>
		public NumericSensorEntity KitchenFairyLightsEnergyTotalstarttime => new(_haContext, "sensor.kitchen_fairy_lights_energy_totalstarttime");
		///<summary>Kitchen Fairy Lights ENERGY Voltage</summary>
		public NumericSensorEntity KitchenFairyLightsEnergyVoltage => new(_haContext, "sensor.kitchen_fairy_lights_energy_voltage");
		///<summary>Kitchen Fairy Lights ENERGY Yesterday</summary>
		public NumericSensorEntity KitchenFairyLightsEnergyYesterday => new(_haContext, "sensor.kitchen_fairy_lights_energy_yesterday");
		///<summary>Kitchen Mouse Trap_battery</summary>
		public NumericSensorEntity KitchenMouseTrapBattery => new(_haContext, "sensor.kitchen_mouse_trap_battery");
		///<summary>Kitchen Mouse Trap_linkquality</summary>
		public NumericSensorEntity KitchenMouseTrapLinkquality => new(_haContext, "sensor.kitchen_mouse_trap_linkquality");
		///<summary>Kitchen Mouse Trap temperature</summary>
		public NumericSensorEntity KitchenMouseTrapTemperature => new(_haContext, "sensor.kitchen_mouse_trap_temperature");
		///<summary>Target Temperature</summary>
		public NumericSensorEntity KitchenTargetTemperature => new(_haContext, "sensor.kitchen_target_temperature");
		///<summary>Kitchen Wall Switch battery</summary>
		public NumericSensorEntity KitchenWallSwitchBattery => new(_haContext, "sensor.kitchen_wall_switch_battery");
		///<summary>Kitchen Window Sensor battery</summary>
		public NumericSensorEntity KitchenWindowSensorBattery => new(_haContext, "sensor.kitchen_window_sensor_battery");
		///<summary>large_wardrobe_stripper Wifi</summary>
		public NumericSensorEntity LargeWardrobeWifi => new(_haContext, "sensor.large_wardrobe_wifi");
		///<summary>Light Sleep Yesterday</summary>
		public NumericSensorEntity LightSleepYesterday => new(_haContext, "sensor.light_sleep_yesterday");
		///<summary>Current Temperature</summary>
		public NumericSensorEntity LivingroomCurrentTemperature => new(_haContext, "sensor.livingroom_current_temperature");
		///<summary>Livingroom Light Switch One battery</summary>
		public NumericSensorEntity LivingroomLightSwitchOneBattery => new(_haContext, "sensor.livingroom_light_switch_one_battery");
		///<summary>Livingroom Light Switch One linkquality</summary>
		public NumericSensorEntity LivingroomLightSwitchOneLinkquality => new(_haContext, "sensor.livingroom_light_switch_one_linkquality");
		///<summary>Livingroom Light Switch One voltage</summary>
		public NumericSensorEntity LivingroomLightSwitchOneVoltage => new(_haContext, "sensor.livingroom_light_switch_one_voltage");
		///<summary>Target Temperature</summary>
		public NumericSensorEntity LivingroomTargetTemperature => new(_haContext, "sensor.livingroom_target_temperature");
		///<summary>Livingroom Wall Switch battery</summary>
		public NumericSensorEntity LivingroomWallSwitchBattery => new(_haContext, "sensor.livingroom_wall_switch_battery");
		///<summary>Livingroom Window One Sensor battery</summary>
		public NumericSensorEntity LivingroomWindowOneSensorBattery => new(_haContext, "sensor.livingroom_window_one_sensor_battery");
		///<summary>Livingroom Window Two Sensor battery</summary>
		public NumericSensorEntity LivingroomWindowTwoSensorBattery => new(_haContext, "sensor.livingroom_window_two_sensor_battery");
		///<summary>LivingroomWLED Estimated Current</summary>
		public NumericSensorEntity LivingroomwledEstimatedCurrent => new(_haContext, "sensor.livingroomwled_estimated_current");
		///<summary>LivingroomWLED Max Current</summary>
		public NumericSensorEntity LivingroomwledMaxCurrent => new(_haContext, "sensor.livingroomwled_max_current");
		///<summary>lower_cooking_stripper Wifi</summary>
		public NumericSensorEntity LowerCookingWifi => new(_haContext, "sensor.lower_cooking_wifi");
		///<summary>lower_main_stripper Wifi</summary>
		public NumericSensorEntity LowerMainWifi => new(_haContext, "sensor.lower_main_wifi");
		///<summary>Memory free</summary>
		public NumericSensorEntity MemoryFree => new(_haContext, "sensor.memory_free");
		///<summary>Memory use</summary>
		public NumericSensorEntity MemoryUse => new(_haContext, "sensor.memory_use");
		///<summary>Memory use (percent)</summary>
		public NumericSensorEntity MemoryUsePercent => new(_haContext, "sensor.memory_use_percent");
		///<summary>Mouse Trap One voltage</summary>
		public NumericSensorEntity MouseTrapOneVoltage => new(_haContext, "sensor.mouse_trap_one_voltage");
		///<summary>Mouse Trap Two voltage</summary>
		public NumericSensorEntity MouseTrapTwoVoltage => new(_haContext, "sensor.mouse_trap_two_voltage");
		///<summary>MultiSensor 6: Air temperature</summary>
		public NumericSensorEntity Multisensor6AirTemperature => new(_haContext, "sensor.multisensor_6_air_temperature");
		///<summary>MultiSensor 6: Battery level</summary>
		public NumericSensorEntity Multisensor6BatteryLevel => new(_haContext, "sensor.multisensor_6_battery_level");
		///<summary>MultiSensor 6: Humidity</summary>
		public NumericSensorEntity Multisensor6Humidity => new(_haContext, "sensor.multisensor_6_humidity");
		///<summary>MultiSensor 6: Illuminance</summary>
		public NumericSensorEntity Multisensor6Illuminance => new(_haContext, "sensor.multisensor_6_illuminance");
		///<summary>mural_ceiling_one Wifi</summary>
		public NumericSensorEntity MuralCeilingOneWifi => new(_haContext, "sensor.mural_ceiling_one_wifi");
		///<summary>mural_ceiling_two Wifi</summary>
		public NumericSensorEntity MuralCeilingTwoWifi => new(_haContext, "sensor.mural_ceiling_two_wifi");
		///<summary>Network in eth0</summary>
		public NumericSensorEntity NetworkInEth0 => new(_haContext, "sensor.network_in_eth0");
		///<summary>Network out eth0</summary>
		public NumericSensorEntity NetworkOutEth0 => new(_haContext, "sensor.network_out_eth0");
		///<summary>Network throughput in eth0</summary>
		public NumericSensorEntity NetworkThroughputInEth0 => new(_haContext, "sensor.network_throughput_in_eth0");
		///<summary>Network throughput out eth0</summary>
		public NumericSensorEntity NetworkThroughputOutEth0 => new(_haContext, "sensor.network_throughput_out_eth0");
		///<summary>office_ceiling_four RX</summary>
		public NumericSensorEntity OfficeCeilingFourRx => new(_haContext, "sensor.office_ceiling_four_rx");
		///<summary>office_ceiling_four TX</summary>
		public NumericSensorEntity OfficeCeilingFourTx => new(_haContext, "sensor.office_ceiling_four_tx");
		///<summary>office_ceiling_one Wifi</summary>
		public NumericSensorEntity OfficeCeilingOneWifi => new(_haContext, "sensor.office_ceiling_one_wifi");
		///<summary>Office Control Switch battery</summary>
		public NumericSensorEntity OfficeControlSwitchBattery => new(_haContext, "sensor.office_control_switch_battery");
		///<summary>Current Temperature</summary>
		public NumericSensorEntity OfficeCurrentTemperature => new(_haContext, "sensor.office_current_temperature");
		///<summary>office_lamp Wifi</summary>
		public NumericSensorEntity OfficeLampWifi => new(_haContext, "sensor.office_lamp_wifi");
		///<summary>Office Mouse Trap battery</summary>
		public NumericSensorEntity OfficeMouseTrapBattery => new(_haContext, "sensor.office_mouse_trap_battery");
		///<summary>office_speakers Wifi</summary>
		public NumericSensorEntity OfficeSpeakersWifi => new(_haContext, "sensor.office_speakers_wifi");
		///<summary>Office Switch One_battery</summary>
		public NumericSensorEntity OfficeSwitchOneBattery => new(_haContext, "sensor.office_switch_one_battery");
		///<summary>Office Switch One_linkquality</summary>
		public NumericSensorEntity OfficeSwitchOneLinkquality => new(_haContext, "sensor.office_switch_one_linkquality");
		///<summary>Office Switch One voltage</summary>
		public NumericSensorEntity OfficeSwitchOneVoltage => new(_haContext, "sensor.office_switch_one_voltage");
		///<summary>Office Switch Two_battery</summary>
		public NumericSensorEntity OfficeSwitchTwoBattery => new(_haContext, "sensor.office_switch_two_battery");
		///<summary>Office Switch Two_linkquality</summary>
		public NumericSensorEntity OfficeSwitchTwoLinkquality => new(_haContext, "sensor.office_switch_two_linkquality");
		///<summary>Office Switch Two voltage</summary>
		public NumericSensorEntity OfficeSwitchTwoVoltage => new(_haContext, "sensor.office_switch_two_voltage");
		///<summary>Target Temperature</summary>
		public NumericSensorEntity OfficeTargetTemperature => new(_haContext, "sensor.office_target_temperature");
		///<summary>Office Wall Switch battery</summary>
		public NumericSensorEntity OfficeWallSwitchBattery => new(_haContext, "sensor.office_wall_switch_battery");
		///<summary>Office Window Sensor One voltage</summary>
		public NumericSensorEntity OfficeWindowSensorOneVoltage => new(_haContext, "sensor.office_window_sensor_one_voltage");
		///<summary>Office Window Sensor Two voltage</summary>
		public NumericSensorEntity OfficeWindowSensorTwoVoltage => new(_haContext, "sensor.office_window_sensor_two_voltage");
		///<summary>Palace Front Door battery</summary>
		public NumericSensorEntity PalaceFrontDoorBattery => new(_haContext, "sensor.palace_front_door_battery");
		///<summary>Palace Front Door linkquality</summary>
		public NumericSensorEntity PalaceFrontDoorLinkquality => new(_haContext, "sensor.palace_front_door_linkquality");
		///<summary>Palace Front Door voltage</summary>
		public NumericSensorEntity PalaceFrontDoorVoltage => new(_haContext, "sensor.palace_front_door_voltage");
		///<summary>Palace Visits</summary>
		public NumericSensorEntity PalaceVisits => new(_haContext, "sensor.palace_visits");
		///<summary>Plex (Squiggle Vision)</summary>
		public NumericSensorEntity PlexHeartOfGold => new(_haContext, "sensor.plex_heart_of_gold");
		///<summary>Processor use</summary>
		public NumericSensorEntity ProcessorUse => new(_haContext, "sensor.processor_use");
		///<summary>reindeer Apparent Power</summary>
		public NumericSensorEntity ReindeerApparentPower => new(_haContext, "sensor.reindeer_apparent_power");
		///<summary>reindeer Apparent Power</summary>
		public NumericSensorEntity ReindeerApparentPower2 => new(_haContext, "sensor.reindeer_apparent_power_2");
		///<summary>reindeer Apparent Power</summary>
		public NumericSensorEntity ReindeerApparentPower3 => new(_haContext, "sensor.reindeer_apparent_power_3");
		///<summary>reindeer Current</summary>
		public NumericSensorEntity ReindeerCurrent => new(_haContext, "sensor.reindeer_current");
		///<summary>reindeer Current</summary>
		public NumericSensorEntity ReindeerCurrent2 => new(_haContext, "sensor.reindeer_current_2");
		///<summary>reindeer Current</summary>
		public NumericSensorEntity ReindeerCurrent3 => new(_haContext, "sensor.reindeer_current_3");
		///<summary>reindeer Power</summary>
		public NumericSensorEntity ReindeerPower => new(_haContext, "sensor.reindeer_power");
		///<summary>reindeer Power</summary>
		public NumericSensorEntity ReindeerPower2 => new(_haContext, "sensor.reindeer_power_2");
		///<summary>reindeer Power</summary>
		public NumericSensorEntity ReindeerPower3 => new(_haContext, "sensor.reindeer_power_3");
		///<summary>reindeer Power Factor</summary>
		public NumericSensorEntity ReindeerPowerFactor2 => new(_haContext, "sensor.reindeer_power_factor_2");
		///<summary>reindeer Power Factor</summary>
		public NumericSensorEntity ReindeerPowerFactor3 => new(_haContext, "sensor.reindeer_power_factor_3");
		///<summary>reindeer Total Daily Energy</summary>
		public NumericSensorEntity ReindeerTotalDailyEnergy => new(_haContext, "sensor.reindeer_total_daily_energy");
		///<summary>reindeer Total Daily Energy</summary>
		public NumericSensorEntity ReindeerTotalDailyEnergy2 => new(_haContext, "sensor.reindeer_total_daily_energy_2");
		///<summary>reindeer Total Daily Energy</summary>
		public NumericSensorEntity ReindeerTotalDailyEnergy3 => new(_haContext, "sensor.reindeer_total_daily_energy_3");
		///<summary>reindeer Voltage</summary>
		public NumericSensorEntity ReindeerVoltage => new(_haContext, "sensor.reindeer_voltage");
		///<summary>reindeer Voltage</summary>
		public NumericSensorEntity ReindeerVoltage2 => new(_haContext, "sensor.reindeer_voltage_2");
		///<summary>reindeer Voltage</summary>
		public NumericSensorEntity ReindeerVoltage3 => new(_haContext, "sensor.reindeer_voltage_3");
		///<summary>Rem Sleep Yesterday</summary>
		public NumericSensorEntity RemSleepYesterday => new(_haContext, "sensor.rem_sleep_yesterday");
		///<summary>Average Heart Rate Yesterday</summary>
		public NumericSensorEntity RestingHeartRateAverageYesterday => new(_haContext, "sensor.resting_heart_rate_average_yesterday");
		///<summary>Samsung CLX-3300 Series Black Toner_S/N_:CRUM-19010244823</summary>
		public NumericSensorEntity SamsungClx3300SeriesBlackTonerSNCrum19010244823 => new(_haContext, "sensor.samsung_clx_3300_series_black_toner_s_n_crum_19010244823");
		///<summary>Samsung CLX-3300 Series Cyan Toner_S/N_:CRUM-19010247360</summary>
		public NumericSensorEntity SamsungClx3300SeriesCyanTonerSNCrum19010247360 => new(_haContext, "sensor.samsung_clx_3300_series_cyan_toner_s_n_crum_19010247360");
		///<summary>Samsung CLX-3300 Series Magenta Toner_S/N_:CRUM-19010341217</summary>
		public NumericSensorEntity SamsungClx3300SeriesMagentaTonerSNCrum19010341217 => new(_haContext, "sensor.samsung_clx_3300_series_magenta_toner_s_n_crum_19010341217");
		///<summary>Samsung CLX-3300 Series Toner black</summary>
		public NumericSensorEntity SamsungClx3300SeriesTonerBlack => new(_haContext, "sensor.samsung_clx_3300_series_toner_black");
		///<summary>Samsung CLX-3300 Series Toner cyan</summary>
		public NumericSensorEntity SamsungClx3300SeriesTonerCyan => new(_haContext, "sensor.samsung_clx_3300_series_toner_cyan");
		///<summary>Samsung CLX-3300 Series Toner magenta</summary>
		public NumericSensorEntity SamsungClx3300SeriesTonerMagenta => new(_haContext, "sensor.samsung_clx_3300_series_toner_magenta");
		///<summary>Samsung CLX-3300 Series Toner yellow</summary>
		public NumericSensorEntity SamsungClx3300SeriesTonerYellow => new(_haContext, "sensor.samsung_clx_3300_series_toner_yellow");
		///<summary>Samsung CLX-3300 Series Yellow Toner_S/N_:CRUM-19010243716</summary>
		public NumericSensorEntity SamsungClx3300SeriesYellowTonerSNCrum19010243716 => new(_haContext, "sensor.samsung_clx_3300_series_yellow_toner_s_n_crum_19010243716");
		///<summary>Second Floor</summary>
		public NumericSensorEntity SecondFloor => new(_haContext, "sensor.second_floor");
		///<summary>Server Fan Current</summary>
		public NumericSensorEntity ServerFanCurrent => new(_haContext, "sensor.server_fan_current");
		///<summary>Server Fan POW Current</summary>
		public NumericSensorEntity ServerFanPowCurrent => new(_haContext, "sensor.server_fan_pow_current");
		///<summary>Server Fan POW Power</summary>
		public NumericSensorEntity ServerFanPowPower => new(_haContext, "sensor.server_fan_pow_power");
		///<summary>Server Fan POW Voltage</summary>
		public NumericSensorEntity ServerFanPowVoltage => new(_haContext, "sensor.server_fan_pow_voltage");
		///<summary>Server Fan Power</summary>
		public NumericSensorEntity ServerFanPower => new(_haContext, "sensor.server_fan_power");
		///<summary>Server Fan Uptime</summary>
		public NumericSensorEntity ServerFanUptime => new(_haContext, "sensor.server_fan_uptime");
		///<summary>Server Fan Voltage</summary>
		public NumericSensorEntity ServerFanVoltage => new(_haContext, "sensor.server_fan_voltage");
		///<summary>Server Fan WiFi Signal</summary>
		public NumericSensorEntity ServerFanWifiSignal => new(_haContext, "sensor.server_fan_wifi_signal");
		///<summary>Server Plug ENERGY ApparentPower</summary>
		public NumericSensorEntity ServerPlugEnergyApparentpower => new(_haContext, "sensor.server_plug_energy_apparentpower");
		///<summary>Server Plug ENERGY Current</summary>
		public NumericSensorEntity ServerPlugEnergyCurrent => new(_haContext, "sensor.server_plug_energy_current");
		///<summary>Server Plug ENERGY Factor</summary>
		public NumericSensorEntity ServerPlugEnergyFactor => new(_haContext, "sensor.server_plug_energy_factor");
		///<summary>Server Plug ENERGY Power</summary>
		public NumericSensorEntity ServerPlugEnergyPower => new(_haContext, "sensor.server_plug_energy_power");
		///<summary>Server Plug ENERGY ReactivePower</summary>
		public NumericSensorEntity ServerPlugEnergyReactivepower => new(_haContext, "sensor.server_plug_energy_reactivepower");
		///<summary>Server Plug ENERGY Today</summary>
		public NumericSensorEntity ServerPlugEnergyToday => new(_haContext, "sensor.server_plug_energy_today");
		///<summary>Server Plug ENERGY Total</summary>
		public NumericSensorEntity ServerPlugEnergyTotal => new(_haContext, "sensor.server_plug_energy_total");
		///<summary>Server Plug ENERGY TotalStartTime</summary>
		public NumericSensorEntity ServerPlugEnergyTotalstarttime => new(_haContext, "sensor.server_plug_energy_totalstarttime");
		///<summary>Server Plug ENERGY Voltage</summary>
		public NumericSensorEntity ServerPlugEnergyVoltage => new(_haContext, "sensor.server_plug_energy_voltage");
		///<summary>Server Plug ENERGY Yesterday</summary>
		public NumericSensorEntity ServerPlugEnergyYesterday => new(_haContext, "sensor.server_plug_energy_yesterday");
		///<summary>Server Room Thermometer_battery</summary>
		public NumericSensorEntity ServerRoomThermometerBattery => new(_haContext, "sensor.server_room_thermometer_battery");
		///<summary>Server Room Thermometer_humidity</summary>
		public NumericSensorEntity ServerRoomThermometerHumidity => new(_haContext, "sensor.server_room_thermometer_humidity");
		///<summary>Server Room Thermometer_linkquality</summary>
		public NumericSensorEntity ServerRoomThermometerLinkquality => new(_haContext, "sensor.server_room_thermometer_linkquality");
		///<summary>Server Room Thermometer</summary>
		public NumericSensorEntity ServerRoomThermometerTemperature => new(_haContext, "sensor.server_room_thermometer_temperature");
		///<summary>Server Room Thermometer voltage</summary>
		public NumericSensorEntity ServerRoomThermometerVoltage => new(_haContext, "sensor.server_room_thermometer_voltage");
		///<summary>Skylight Window Contact battery</summary>
		public NumericSensorEntity SkylightWindowContactBattery => new(_haContext, "sensor.skylight_window_contact_battery");
		///<summary>Skylight Window Contact linkquality</summary>
		public NumericSensorEntity SkylightWindowContactLinkquality => new(_haContext, "sensor.skylight_window_contact_linkquality");
		///<summary>Skylight Window Contact voltage</summary>
		public NumericSensorEntity SkylightWindowContactVoltage => new(_haContext, "sensor.skylight_window_contact_voltage");
		///<summary>Sleep Breath Average Yesterday</summary>
		public NumericSensorEntity SleepBreathAverageYesterday => new(_haContext, "sensor.sleep_breath_average_yesterday");
		///<summary>Resting Heart Rate Yesterday</summary>
		public NumericSensorEntity SleepRestingHeartRateYesterday => new(_haContext, "sensor.sleep_resting_heart_rate_yesterday");
		///<summary>Sleep Temperature Delta Yesterday</summary>
		public NumericSensorEntity SleepTemperatureDeltaYesterday => new(_haContext, "sensor.sleep_temperature_delta_yesterday");
		///<summary>BigSquigglePad Battery Level</summary>
		public NumericSensorEntity SmT870BatteryLevel => new(_haContext, "sensor.sm_t870_battery_level");
		///<summary>Small Squiggle Pad Battery Level</summary>
		public NumericSensorEntity SmallSquigglePadBatteryLevel => new(_haContext, "sensor.small_squiggle_pad_battery_level");
		///<summary>Small Squiggle Pad Battery Temperature</summary>
		public NumericSensorEntity SmallSquigglePadBatteryTemperature => new(_haContext, "sensor.small_squiggle_pad_battery_temperature");
		///<summary>small_wardrobe_stripper Wifi</summary>
		public NumericSensorEntity SmallWardrobeWifi => new(_haContext, "sensor.small_wardrobe_wifi");
		///<summary>small_wardrobe Wifi</summary>
		public NumericSensorEntity SmallWardrobeWifi2 => new(_haContext, "sensor.small_wardrobe_wifi_2");
		///<summary>SmallSquigglePad Battery Level</summary>
		public NumericSensorEntity SmallsquigglepadBatteryLevel => new(_haContext, "sensor.smallsquigglepad_battery_level");
		///<summary>SmallSquigglePad Battery Temperature</summary>
		public NumericSensorEntity SmallsquigglepadBatteryTemperature => new(_haContext, "sensor.smallsquigglepad_battery_temperature");
		///<summary>spare_one RX</summary>
		public NumericSensorEntity SpareOneRx => new(_haContext, "sensor.spare_one_rx");
		///<summary>spare_one TX</summary>
		public NumericSensorEntity SpareOneTx => new(_haContext, "sensor.spare_one_tx");
		///<summary>SquigglePad Battery Temperature</summary>
		public NumericSensorEntity SquigglepadBatteryTemperature => new(_haContext, "sensor.squigglepad_battery_temperature");
		///<summary>SquigglePad Bluetooth Connection</summary>
		public NumericSensorEntity SquigglepadBluetoothConnection => new(_haContext, "sensor.squigglepad_bluetooth_connection");
		///<summary>SquigglePad Light Sensor</summary>
		public NumericSensorEntity SquigglepadLightSensor => new(_haContext, "sensor.squigglepad_light_sensor");
		///<summary>SquigglePad Storage Sensor</summary>
		public NumericSensorEntity SquigglepadStorageSensor => new(_haContext, "sensor.squigglepad_storage_sensor");
		///<summary>SquigglePhone Battery Level</summary>
		public NumericSensorEntity SquigglephoneBatteryLevel => new(_haContext, "sensor.squigglephone_battery_level");
		///<summary>SquigglePhone Battery Temperature</summary>
		public NumericSensorEntity SquigglephoneBatteryTemperature => new(_haContext, "sensor.squigglephone_battery_temperature");
		///<summary>Squiggley 4 Button Remote battery</summary>
		public NumericSensorEntity Squiggley4ButtonRemoteBattery => new(_haContext, "sensor.squiggley_4_button_remote_battery");
		///<summary>Squiggley Couch battery</summary>
		public NumericSensorEntity SquiggleyCouchBattery => new(_haContext, "sensor.squiggley_couch_battery");
		///<summary>Squiggley Desktop ENERGY ApparentPower</summary>
		public NumericSensorEntity SquiggleyDesktopEnergyApparentpower => new(_haContext, "sensor.squiggley_desktop_energy_apparentpower");
		///<summary>Squiggley Desktop ENERGY Current</summary>
		public NumericSensorEntity SquiggleyDesktopEnergyCurrent => new(_haContext, "sensor.squiggley_desktop_energy_current");
		///<summary>Squiggley Desktop ENERGY Factor</summary>
		public NumericSensorEntity SquiggleyDesktopEnergyFactor => new(_haContext, "sensor.squiggley_desktop_energy_factor");
		///<summary>Squiggley Desktop ENERGY Power</summary>
		public NumericSensorEntity SquiggleyDesktopEnergyPower => new(_haContext, "sensor.squiggley_desktop_energy_power");
		///<summary>Squiggley Desktop ENERGY ReactivePower</summary>
		public NumericSensorEntity SquiggleyDesktopEnergyReactivepower => new(_haContext, "sensor.squiggley_desktop_energy_reactivepower");
		///<summary>Squiggley Desktop ENERGY Today</summary>
		public NumericSensorEntity SquiggleyDesktopEnergyToday => new(_haContext, "sensor.squiggley_desktop_energy_today");
		///<summary>Squiggley Desktop ENERGY Total</summary>
		public NumericSensorEntity SquiggleyDesktopEnergyTotal => new(_haContext, "sensor.squiggley_desktop_energy_total");
		///<summary>Squiggley Desktop ENERGY TotalStartTime</summary>
		public NumericSensorEntity SquiggleyDesktopEnergyTotalstarttime => new(_haContext, "sensor.squiggley_desktop_energy_totalstarttime");
		///<summary>Squiggley Desktop ENERGY Voltage</summary>
		public NumericSensorEntity SquiggleyDesktopEnergyVoltage => new(_haContext, "sensor.squiggley_desktop_energy_voltage");
		///<summary>Squiggley Desktop ENERGY Yesterday</summary>
		public NumericSensorEntity SquiggleyDesktopEnergyYesterday => new(_haContext, "sensor.squiggley_desktop_energy_yesterday");
		///<summary>Squiggley Nightlight Motion Sensor_battery</summary>
		public NumericSensorEntity SquiggleyNightlightMotionSensorBattery => new(_haContext, "sensor.squiggley_nightlight_motion_sensor_battery");
		///<summary>Squiggley Nightlight Motion Sensor_linkquality</summary>
		public NumericSensorEntity SquiggleyNightlightMotionSensorLinkquality => new(_haContext, "sensor.squiggley_nightlight_motion_sensor_linkquality");
		///<summary>Squiggley Nightlight Motion Sensor voltage</summary>
		public NumericSensorEntity SquiggleyNightlightMotionSensorVoltage => new(_haContext, "sensor.squiggley_nightlight_motion_sensor_voltage");
		///<summary>Squiggley Wardrobe Door Sensor battery</summary>
		public NumericSensorEntity SquiggleyWardrobeDoorSensorBattery => new(_haContext, "sensor.squiggley_wardrobe_door_sensor_battery");
		///<summary>Squiggley Wardrobe Door Sensor linkquality</summary>
		public NumericSensorEntity SquiggleyWardrobeDoorSensorLinkquality => new(_haContext, "sensor.squiggley_wardrobe_door_sensor_linkquality");
		///<summary>Squiggley Wardrobe Door Sensor temperature</summary>
		public NumericSensorEntity SquiggleyWardrobeDoorSensorTemperature => new(_haContext, "sensor.squiggley_wardrobe_door_sensor_temperature");
		///<summary>Squiggley Wardrobe Door Sensor voltage</summary>
		public NumericSensorEntity SquiggleyWardrobeDoorSensorVoltage => new(_haContext, "sensor.squiggley_wardrobe_door_sensor_voltage");
		///<summary>stag Apparent Power</summary>
		public NumericSensorEntity StagApparentPower => new(_haContext, "sensor.stag_apparent_power");
		///<summary>stag Current</summary>
		public NumericSensorEntity StagCurrent => new(_haContext, "sensor.stag_current");
		///<summary>stag Power</summary>
		public NumericSensorEntity StagPower => new(_haContext, "sensor.stag_power");
		///<summary>stag Total Daily Energy</summary>
		public NumericSensorEntity StagTotalDailyEnergy => new(_haContext, "sensor.stag_total_daily_energy");
		///<summary>stag Voltage</summary>
		public NumericSensorEntity StagVoltage => new(_haContext, "sensor.stag_voltage");
		///<summary>stair_ceiling_three Wifi</summary>
		public NumericSensorEntity StairCeilingThreeWifi => new(_haContext, "sensor.stair_ceiling_three_wifi");
		///<summary>stair_ceiling_two Wifi</summary>
		public NumericSensorEntity StairCeilingTwoWifi => new(_haContext, "sensor.stair_ceiling_two_wifi");
		///<summary>Stair Light Switch One_battery</summary>
		public NumericSensorEntity StairLightSwitchOneBattery => new(_haContext, "sensor.stair_light_switch_one_battery");
		///<summary>Stair Light Switch One_linkquality</summary>
		public NumericSensorEntity StairLightSwitchOneLinkquality => new(_haContext, "sensor.stair_light_switch_one_linkquality");
		///<summary>Stair Light Switch One voltage</summary>
		public NumericSensorEntity StairLightSwitchOneVoltage => new(_haContext, "sensor.stair_light_switch_one_voltage");
		///<summary>Stair Light Switch Two_battery</summary>
		public NumericSensorEntity StairLightSwitchTwoBattery => new(_haContext, "sensor.stair_light_switch_two_battery");
		///<summary>Stair Light Switch Two_linkquality</summary>
		public NumericSensorEntity StairLightSwitchTwoLinkquality => new(_haContext, "sensor.stair_light_switch_two_linkquality");
		///<summary>Stair Light Switch Two voltage</summary>
		public NumericSensorEntity StairLightSwitchTwoVoltage => new(_haContext, "sensor.stair_light_switch_two_voltage");
		///<summary>Stairs Window Sensor battery</summary>
		public NumericSensorEntity StairsWindowSensorBattery => new(_haContext, "sensor.stairs_window_sensor_battery");
		///<summary>Sun elevation</summary>
		public NumericSensorEntity SunElevation => new(_haContext, "sensor.sun_elevation");
		///<summary>Swap free</summary>
		public NumericSensorEntity SwapFree => new(_haContext, "sensor.swap_free");
		///<summary>Swap use</summary>
		public NumericSensorEntity SwapUse => new(_haContext, "sensor.swap_use");
		///<summary>Swap use (percent)</summary>
		public NumericSensorEntity SwapUsePercent => new(_haContext, "sensor.swap_use_percent");
		///<summary>Time Awake Yesterday</summary>
		public NumericSensorEntity TimeAwakeYesterday => new(_haContext, "sensor.time_awake_yesterday");
		///<summary>Time In Bed Yesterday</summary>
		public NumericSensorEntity TimeInBedYesterday => new(_haContext, "sensor.time_in_bed_yesterday");
		///<summary>Toilet Door Sensor_battery</summary>
		public NumericSensorEntity ToiletDoorSensorBattery => new(_haContext, "sensor.toilet_door_sensor_battery");
		///<summary>Toilet Door Sensor_linkquality</summary>
		public NumericSensorEntity ToiletDoorSensorLinkquality => new(_haContext, "sensor.toilet_door_sensor_linkquality");
		///<summary>Toilet Door Sensor temperature</summary>
		public NumericSensorEntity ToiletDoorSensorTemperature => new(_haContext, "sensor.toilet_door_sensor_temperature");
		///<summary>Toilet Door Sensor voltage</summary>
		public NumericSensorEntity ToiletDoorSensorVoltage => new(_haContext, "sensor.toilet_door_sensor_voltage");
		///<summary>Toilet Light Switch_battery</summary>
		public NumericSensorEntity ToiletLightSwitchBattery => new(_haContext, "sensor.toilet_light_switch_battery");
		///<summary>Toilet Light Switch_linkquality</summary>
		public NumericSensorEntity ToiletLightSwitchLinkquality => new(_haContext, "sensor.toilet_light_switch_linkquality");
		///<summary>Toilet Light Switch voltage</summary>
		public NumericSensorEntity ToiletLightSwitchVoltage => new(_haContext, "sensor.toilet_light_switch_voltage");
		///<summary>Toilet Motion Sensor voltage</summary>
		public NumericSensorEntity ToiletMotionSensorVoltage => new(_haContext, "sensor.toilet_motion_sensor_voltage");
		///<summary>Toilet Mouse Trap_battery</summary>
		public NumericSensorEntity ToiletMouseTrapBattery => new(_haContext, "sensor.toilet_mouse_trap_battery");
		///<summary>Toilet Mouse Trap_linkquality</summary>
		public NumericSensorEntity ToiletMouseTrapLinkquality => new(_haContext, "sensor.toilet_mouse_trap_linkquality");
		///<summary>Toilet Mouse Trap temperature</summary>
		public NumericSensorEntity ToiletMouseTrapTemperature => new(_haContext, "sensor.toilet_mouse_trap_temperature");
		///<summary>Toilet Window Sensor_battery</summary>
		public NumericSensorEntity ToiletWindowSensorBattery => new(_haContext, "sensor.toilet_window_sensor_battery");
		///<summary>Toilet Window Sensor_linkquality</summary>
		public NumericSensorEntity ToiletWindowSensorLinkquality => new(_haContext, "sensor.toilet_window_sensor_linkquality");
		///<summary>Toilet Window Sensor voltage</summary>
		public NumericSensorEntity ToiletWindowSensorVoltage => new(_haContext, "sensor.toilet_window_sensor_voltage");
		///<summary>Total Sleep Yesterday</summary>
		public NumericSensorEntity TotalSleepYesterday => new(_haContext, "sensor.total_sleep_yesterday");
		///<summary>tv_ceiling_one Wifi</summary>
		public NumericSensorEntity TvCeilingOneWifi => new(_haContext, "sensor.tv_ceiling_one_wifi");
		///<summary>upper_cooking_stripper Wifi</summary>
		public NumericSensorEntity UpperCookingWifi => new(_haContext, "sensor.upper_cooking_wifi");
		///<summary>upper_main_stripper Wifi</summary>
		public NumericSensorEntity UpperMainWifi => new(_haContext, "sensor.upper_main_wifi");
		///<summary>Current Temperature</summary>
		public NumericSensorEntity VestibuleCurrentTemperature => new(_haContext, "sensor.vestibule_current_temperature");
		///<summary>vestibule_four Wifi</summary>
		public NumericSensorEntity VestibuleFourWifi => new(_haContext, "sensor.vestibule_four_wifi");
		///<summary>Vestibule Light Switch One_battery</summary>
		public NumericSensorEntity VestibuleLightSwitchOneBattery => new(_haContext, "sensor.vestibule_light_switch_one_battery");
		///<summary>Vestibule Light Switch One_linkquality</summary>
		public NumericSensorEntity VestibuleLightSwitchOneLinkquality => new(_haContext, "sensor.vestibule_light_switch_one_linkquality");
		///<summary>Vestibule Light Switch One voltage</summary>
		public NumericSensorEntity VestibuleLightSwitchOneVoltage => new(_haContext, "sensor.vestibule_light_switch_one_voltage");
		///<summary>Vestibule Motion Sensor_battery</summary>
		public NumericSensorEntity VestibuleMotionSensorBattery => new(_haContext, "sensor.vestibule_motion_sensor_battery");
		///<summary>Vestibule Motion Sensor_linkquality</summary>
		public NumericSensorEntity VestibuleMotionSensorLinkquality => new(_haContext, "sensor.vestibule_motion_sensor_linkquality");
		///<summary>Vestibule Motion Sensor voltage</summary>
		public NumericSensorEntity VestibuleMotionSensorVoltage => new(_haContext, "sensor.vestibule_motion_sensor_voltage");
		///<summary>vestibule_one Wifi</summary>
		public NumericSensorEntity VestibuleOneWifi => new(_haContext, "sensor.vestibule_one_wifi");
		///<summary>Target Temperature</summary>
		public NumericSensorEntity VestibuleTargetTemperature => new(_haContext, "sensor.vestibule_target_temperature");
		///<summary>vestibule_three Wifi</summary>
		public NumericSensorEntity VestibuleThreeWifi => new(_haContext, "sensor.vestibule_three_wifi");
		///<summary>vestibule_two Wifi</summary>
		public NumericSensorEntity VestibuleTwoWifi => new(_haContext, "sensor.vestibule_two_wifi");
		///<summary>Curry</summary>
		public NumericSensorEntity WaqiEdinburghCurrieUnitedKingdom => new(_haContext, "sensor.waqi_edinburgh_currie_united_kingdom");
		///<summary>WAQI Edinburgh Glasgow Road, United Kingdom</summary>
		public NumericSensorEntity WaqiEdinburghGlasgowRoadUnitedKingdom => new(_haContext, "sensor.waqi_edinburgh_glasgow_road_united_kingdom");
		///<summary>Queen Street</summary>
		public NumericSensorEntity WaqiEdinburghQueenStreetUnitedKingdom => new(_haContext, "sensor.waqi_edinburgh_queen_street_united_kingdom");
		///<summary>WAQI Edinburgh Queensferry Road, United Kingdom</summary>
		public NumericSensorEntity WaqiEdinburghQueensferryRoadUnitedKingdom => new(_haContext, "sensor.waqi_edinburgh_queensferry_road_united_kingdom");
		///<summary>WAQI Edinburgh Salamander St, United Kingdom</summary>
		public NumericSensorEntity WaqiEdinburghSalamanderStUnitedKingdom => new(_haContext, "sensor.waqi_edinburgh_salamander_st_united_kingdom");
		///<summary>St Johns Road</summary>
		public NumericSensorEntity WaqiEdinburghStJohnSRoadUnitedKingdom => new(_haContext, "sensor.waqi_edinburgh_st_john_s_road_united_kingdom");
		///<summary>WAQI Edinburgh St Leonards, United Kingdom</summary>
		public NumericSensorEntity WaqiEdinburghStLeonardsUnitedKingdom => new(_haContext, "sensor.waqi_edinburgh_st_leonards_united_kingdom");
		///<summary>WAQI Edinburgh St Leonards, United Kingdom</summary>
		public NumericSensorEntity WaqiEdinburghStLeonardsUnitedKingdom2 => new(_haContext, "sensor.waqi_edinburgh_st_leonards_united_kingdom_2");
		///<summary>WAQI Edinburgh Tower Street, United Kingdom</summary>
		public NumericSensorEntity WaqiEdinburghTowerStreetUnitedKingdom => new(_haContext, "sensor.waqi_edinburgh_tower_street_united_kingdom");
		///<summary>Wee Bear 4 Button Remote battery</summary>
		public NumericSensorEntity WeeBear4ButtonRemoteBattery => new(_haContext, "sensor.wee_bear_4_button_remote_battery");
		///<summary>Wee Bear Couch battery</summary>
		public NumericSensorEntity WeeBearCouchBattery => new(_haContext, "sensor.wee_bear_couch_battery");
		///<summary>Current Temperature</summary>
		public NumericSensorEntity WeeBearCurrentTemperature => new(_haContext, "sensor.wee_bear_current_temperature");
		///<summary>Wee Bear Nightlight Motion Sensor_battery</summary>
		public NumericSensorEntity WeeBearNightlightMotionSensorBattery => new(_haContext, "sensor.wee_bear_nightlight_motion_sensor_battery");
		///<summary>Wee Bear Nightlight Motion Sensor_linkquality</summary>
		public NumericSensorEntity WeeBearNightlightMotionSensorLinkquality => new(_haContext, "sensor.wee_bear_nightlight_motion_sensor_linkquality");
		///<summary>Wee Bear Nightlight Motion Sensor voltage</summary>
		public NumericSensorEntity WeeBearNightlightMotionSensorVoltage => new(_haContext, "sensor.wee_bear_nightlight_motion_sensor_voltage");
		///<summary>Target Temperature</summary>
		public NumericSensorEntity WeeBearTargetTemperature => new(_haContext, "sensor.wee_bear_target_temperature");
		///<summary>Wee Bear Wall Switch battery</summary>
		public NumericSensorEntity WeeBearWallSwitchBattery => new(_haContext, "sensor.wee_bear_wall_switch_battery");
		///<summary>wee bear wardrobe door one_battery</summary>
		public NumericSensorEntity WeeBearWardrobeDoorOneBattery => new(_haContext, "sensor.wee_bear_wardrobe_door_one_battery");
		///<summary>wee bear wardrobe door one linkquality</summary>
		public NumericSensorEntity WeeBearWardrobeDoorOneLinkquality => new(_haContext, "sensor.wee_bear_wardrobe_door_one_linkquality");
		///<summary>Wee Bear Wardrobe Door One Sensor temperature</summary>
		public NumericSensorEntity WeeBearWardrobeDoorOneSensorTemperature => new(_haContext, "sensor.wee_bear_wardrobe_door_one_sensor_temperature");
		///<summary>Wee Bear Wardrobe Door One Sensor voltage</summary>
		public NumericSensorEntity WeeBearWardrobeDoorOneSensorVoltage => new(_haContext, "sensor.wee_bear_wardrobe_door_one_sensor_voltage");
		///<summary>wee bear wardrobe door three battery</summary>
		public NumericSensorEntity WeeBearWardrobeDoorThreeBattery => new(_haContext, "sensor.wee_bear_wardrobe_door_three_battery");
		///<summary>wee bear wardrobe door three linkquality</summary>
		public NumericSensorEntity WeeBearWardrobeDoorThreeLinkquality => new(_haContext, "sensor.wee_bear_wardrobe_door_three_linkquality");
		///<summary>wee bear wardrobe door three temperature</summary>
		public NumericSensorEntity WeeBearWardrobeDoorThreeTemperature => new(_haContext, "sensor.wee_bear_wardrobe_door_three_temperature");
		///<summary>wee bear wardrobe door three voltage</summary>
		public NumericSensorEntity WeeBearWardrobeDoorThreeVoltage => new(_haContext, "sensor.wee_bear_wardrobe_door_three_voltage");
		///<summary>wee bear wardrobe door two battery</summary>
		public NumericSensorEntity WeeBearWardrobeDoorTwoBattery => new(_haContext, "sensor.wee_bear_wardrobe_door_two_battery");
		///<summary>wee bear wardrobe door two linkquality</summary>
		public NumericSensorEntity WeeBearWardrobeDoorTwoLinkquality => new(_haContext, "sensor.wee_bear_wardrobe_door_two_linkquality");
		///<summary>Wee Bear Wardrobe Door Two Sensor temperature</summary>
		public NumericSensorEntity WeeBearWardrobeDoorTwoSensorTemperature => new(_haContext, "sensor.wee_bear_wardrobe_door_two_sensor_temperature");
		///<summary>Wee Bear Wardrobe Door Two Sensor voltage</summary>
		public NumericSensorEntity WeeBearWardrobeDoorTwoSensorVoltage => new(_haContext, "sensor.wee_bear_wardrobe_door_two_sensor_voltage");
		///<summary>Wee Bear Window Sensor One voltage</summary>
		public NumericSensorEntity WeeBearWindowSensorOneVoltage => new(_haContext, "sensor.wee_bear_window_sensor_one_voltage");
		///<summary>Wee Bear Window Sensor Two_battery</summary>
		public NumericSensorEntity WeeBearWindowSensorTwoBattery => new(_haContext, "sensor.wee_bear_window_sensor_two_battery");
		///<summary>Wee Bear Window Sensor Two_linkquality</summary>
		public NumericSensorEntity WeeBearWindowSensorTwoLinkquality => new(_haContext, "sensor.wee_bear_window_sensor_two_linkquality");
		///<summary>Wee Bear Window Sensor Two voltage</summary>
		public NumericSensorEntity WeeBearWindowSensorTwoVoltage => new(_haContext, "sensor.wee_bear_window_sensor_two_voltage");
		///<summary>What button are you? battery</summary>
		public NumericSensorEntity WhatButtonAreYouBattery => new(_haContext, "sensor.what_button_are_you_battery");
		///<summary>What button are you? linkquality</summary>
		public NumericSensorEntity WhatButtonAreYouLinkquality => new(_haContext, "sensor.what_button_are_you_linkquality");
		///<summary>What button are you? voltage</summary>
		public NumericSensorEntity WhatButtonAreYouVoltage => new(_haContext, "sensor.what_button_are_you_voltage");
		///<summary>nightlight_stripper Wifi</summary>
		public NumericSensorEntity WifiSignalH801light => new(_haContext, "sensor.wifi_signal_h801light");
		///<summary>window_ceiling_four Wifi</summary>
		public NumericSensorEntity WindowCeilingFourWifi => new(_haContext, "sensor.window_ceiling_four_wifi");
		///<summary>window_ceiling_one Wifi</summary>
		public NumericSensorEntity WindowCeilingOneWifi => new(_haContext, "sensor.window_ceiling_one_wifi");
		///<summary>window_ceiling_three Wifi</summary>
		public NumericSensorEntity WindowCeilingThreeWifi => new(_haContext, "sensor.window_ceiling_three_wifi");
		///<summary>window_ceiling_two Wifi</summary>
		public NumericSensorEntity WindowCeilingTwoWifi => new(_haContext, "sensor.window_ceiling_two_wifi");
		///<summary>ZaphodWLED Estimated Current</summary>
		public NumericSensorEntity ZaphodwledEstimatedCurrent => new(_haContext, "sensor.zaphodwled_estimated_current");
		///<summary>ZaphodWLED Max Current</summary>
		public NumericSensorEntity ZaphodwledMaxCurrent => new(_haContext, "sensor.zaphodwled_max_current");
		///<summary>Zigdown Router_linkquality</summary>
		public NumericSensorEntity ZigdownRouterLinkquality => new(_haContext, "sensor.zigdown_router_linkquality");
		///<summary>Zigup Router_linkquality</summary>
		public NumericSensorEntity ZigupRouterLinkquality => new(_haContext, "sensor.zigup_router_linkquality");
		///<summary>Home Off Switch action</summary>
		public SensorEntity E0x00158d0002f99a9fAction => new(_haContext, "sensor.0x00158d0002f99a9f_action");
		///<summary>A special kind of sensor</summary>
		public SensorEntity ASpecialKindOfSensor => new(_haContext, "sensor.a_special_kind_of_sensor");
		///<summary>basic_sensor</summary>
		public SensorEntity BasicSensor => new(_haContext, "sensor.basic_sensor");
		///<summary>Bathroom Wall Switch action</summary>
		public SensorEntity BathroomWallSwitchAction => new(_haContext, "sensor.bathroom_wall_switch_action");
		///<summary>Bedroom Wall Switch action</summary>
		public SensorEntity BedroomWallSwitchAction => new(_haContext, "sensor.bedroom_wall_switch_action");
		///<summary>Wake Time Yesterday</summary>
		public SensorEntity BedtimeEndHourYesterday => new(_haContext, "sensor.bedtime_end_hour_yesterday");
		///<summary>Bed Time Yesterday</summary>
		public SensorEntity BedtimeStartHourYesterday => new(_haContext, "sensor.bedtime_start_hour_yesterday");
		///<summary>BigSquigglePad Uptime</summary>
		public SensorEntity BigsquigglepadUptime => new(_haContext, "sensor.bigsquigglepad_uptime");
		///<summary>christmas_tree Power Factor</summary>
		public SensorEntity ChristmasTreePowerFactor => new(_haContext, "sensor.christmas_tree_power_factor");
		///<summary>Claire’s iPhone Activity</summary>
		public SensorEntity ClairesIphoneActivity => new(_haContext, "sensor.claires_iphone_activity");
		///<summary>Claire’s iPhone state</summary>
		public SensorEntity ClairesIphoneBatteryState => new(_haContext, "sensor.claires_iphone_battery_state");
		///<summary>Claire’s iPhone Battery State</summary>
		public SensorEntity ClairesIphoneBatteryState2 => new(_haContext, "sensor.claires_iphone_battery_state_2");
		///<summary>Claire’s iPhone BSSID</summary>
		public SensorEntity ClairesIphoneBssid => new(_haContext, "sensor.claires_iphone_bssid");
		///<summary>Claire’s iPhone Connection Type</summary>
		public SensorEntity ClairesIphoneConnectionType => new(_haContext, "sensor.claires_iphone_connection_type");
		///<summary>Claire’s iPhone Geocoded Location</summary>
		public SensorEntity ClairesIphoneGeocodedLocation => new(_haContext, "sensor.claires_iphone_geocoded_location");
		///<summary>Claire’s iPhone Last Update Trigger</summary>
		public SensorEntity ClairesIphoneLastUpdateTrigger => new(_haContext, "sensor.claires_iphone_last_update_trigger");
		///<summary>Claire’s iPhone SIM 1</summary>
		public SensorEntity ClairesIphoneSim1 => new(_haContext, "sensor.claires_iphone_sim_1");
		///<summary>Claire’s iPhone SIM 2</summary>
		public SensorEntity ClairesIphoneSim2 => new(_haContext, "sensor.claires_iphone_sim_2");
		///<summary>Claire’s iPhone SSID</summary>
		public SensorEntity ClairesIphoneSsid => new(_haContext, "sensor.claires_iphone_ssid");
		///<summary>cooking_ceiling_one Uptime</summary>
		public SensorEntity CookingCeilingOneUptime2 => new(_haContext, "sensor.cooking_ceiling_one_uptime_2");
		///<summary>Corstorphine Weather 3-Hourly</summary>
		public SensorEntity CorstorphineWeather => new(_haContext, "sensor.corstorphine_weather");
		///<summary>Cricket-One Gateway PIASWEDENGATEWAY_VPNV4 status</summary>
		public SensorEntity CricketOneGatewayPiaswedengatewayVpnv4Status => new(_haContext, "sensor.cricket_one_gateway_piaswedengateway_vpnv4_status");
		///<summary>Cricket-One Gateway WAN_DHCP status</summary>
		public SensorEntity CricketOneGatewayWanDhcpStatus => new(_haContext, "sensor.cricket_one_gateway_wan_dhcp_status");
		///<summary>Cricket-One Interface LAN status</summary>
		public SensorEntity CricketOneInterfaceLanStatus => new(_haContext, "sensor.cricket_one_interface_lan_status");
		///<summary>Cricket-One Interface PIANETHERLANDS status</summary>
		public SensorEntity CricketOneInterfacePianetherlandsStatus => new(_haContext, "sensor.cricket_one_interface_pianetherlands_status");
		///<summary>Cricket-One Interface SQUIGGLEYWORK status</summary>
		public SensorEntity CricketOneInterfaceSquiggleyworkStatus => new(_haContext, "sensor.cricket_one_interface_squiggleywork_status");
		///<summary>Cricket-One Interface WAN status</summary>
		public SensorEntity CricketOneInterfaceWanStatus => new(_haContext, "sensor.cricket_one_interface_wan_status");
		///<summary>Cricket-One Interface WEEBEARWORK status</summary>
		public SensorEntity CricketOneInterfaceWeebearworkStatus => new(_haContext, "sensor.cricket_one_interface_weebearwork_status");
		///<summary>Date</summary>
		public SensorEntity Date => new(_haContext, "sensor.date");
		///<summary>Date & Time</summary>
		public SensorEntity DateTime => new(_haContext, "sensor.date_time");
		///<summary>Date & Time (ISO)</summary>
		public SensorEntity DateTimeIso => new(_haContext, "sensor.date_time_iso");
		///<summary>fan speed</summary>
		public SensorEntity DeebotFanSpeed => new(_haContext, "sensor.deebot_fan_speed");
		///<summary>deebot_kaggi_ii_queue_bedroom_room</summary>
		public SensorEntity DeebotKaggiIiQueueBedroomRoom => new(_haContext, "sensor.deebot_kaggi_ii_queue_bedroom_room");
		///<summary>deebot_kaggi_ii_queue_hallway_room</summary>
		public SensorEntity DeebotKaggiIiQueueHallwayRoom => new(_haContext, "sensor.deebot_kaggi_ii_queue_hallway_room");
		///<summary>deebot_kaggi_ii_queue_kitchen_room</summary>
		public SensorEntity DeebotKaggiIiQueueKitchenRoom => new(_haContext, "sensor.deebot_kaggi_ii_queue_kitchen_room");
		///<summary>deebot_kaggi_ii_queue_living_room</summary>
		public SensorEntity DeebotKaggiIiQueueLivingRoom => new(_haContext, "sensor.deebot_kaggi_ii_queue_living_room");
		///<summary>deebot_kaggi_ii_queue_office_room</summary>
		public SensorEntity DeebotKaggiIiQueueOfficeRoom => new(_haContext, "sensor.deebot_kaggi_ii_queue_office_room");
		///<summary>deebot_kaggi_ii_queue_vestibule_room</summary>
		public SensorEntity DeebotKaggiIiQueueVestibuleRoom => new(_haContext, "sensor.deebot_kaggi_ii_queue_vestibule_room");
		///<summary>deebot_kaggi_ii_queue_wee_bear_room</summary>
		public SensorEntity DeebotKaggiIiQueueWeeBearRoom => new(_haContext, "sensor.deebot_kaggi_ii_queue_wee_bear_room");
		///<summary>water level</summary>
		public SensorEntity DeebotWaterLevel => new(_haContext, "sensor.deebot_water_level");
		///<summary>ESP_A3C825 Uptime</summary>
		public SensorEntity EspA3c825Uptime => new(_haContext, "sensor.esp_a3c825_uptime");
		///<summary>Fairy Lights Last Restart Time</summary>
		public SensorEntity FairyLightsLastRestartTime => new(_haContext, "sensor.fairy_lights_last_restart_time");
		///<summary>Fairy Lights MQTT Connect Count</summary>
		public SensorEntity FairyLightsMqttConnectCount => new(_haContext, "sensor.fairy_lights_mqtt_connect_count");
		///<summary>Fairy Lights Restart Reason</summary>
		public SensorEntity FairyLightsRestartReason => new(_haContext, "sensor.fairy_lights_restart_reason");
		///<summary>Fairy Lights SSID</summary>
		public SensorEntity FairyLightsSsid => new(_haContext, "sensor.fairy_lights_ssid");
		///<summary>Fairy Lights WiFi Connect Count</summary>
		public SensorEntity FairyLightsWifiConnectCount => new(_haContext, "sensor.fairy_lights_wifi_connect_count");
		///<summary>Firework Lights Last Restart Time</summary>
		public SensorEntity FireworkLightsLastRestartTime => new(_haContext, "sensor.firework_lights_last_restart_time");
		///<summary>Firework Lights MQTT Connect Count</summary>
		public SensorEntity FireworkLightsMqttConnectCount => new(_haContext, "sensor.firework_lights_mqtt_connect_count");
		///<summary>Firework Lights Restart Reason</summary>
		public SensorEntity FireworkLightsRestartReason => new(_haContext, "sensor.firework_lights_restart_reason");
		///<summary>Firework Lights SSID</summary>
		public SensorEntity FireworkLightsSsid => new(_haContext, "sensor.firework_lights_ssid");
		///<summary>Firework Lights WiFi Connect Count</summary>
		public SensorEntity FireworkLightsWifiConnectCount => new(_haContext, "sensor.firework_lights_wifi_connect_count");
		///<summary>Food Bin</summary>
		public SensorEntity FoodBin => new(_haContext, "sensor.food_bin");
		///<summary>Garden</summary>
		public SensorEntity Garden => new(_haContext, "sensor.garden");
		///<summary>heart-of-gold_VM_blazor_dev_environment_status</summary>
		public SensorEntity HeartOfGoldVmBlazorDevEnvironmentStatus => new(_haContext, "sensor.heart_of_gold_vm_blazor_dev_environment_status");
		///<summary>heart-of-gold_VM_ubuntu_status</summary>
		public SensorEntity HeartOfGoldVmUbuntuStatus => new(_haContext, "sensor.heart_of_gold_vm_ubuntu_status");
		///<summary>Home Occupancy Confidence</summary>
		public SensorEntity HomeOccupancyConfidence => new(_haContext, "sensor.home_occupancy_confidence");
		///<summary>Home Off Switch_click</summary>
		public SensorEntity HomeOffSwitchClick => new(_haContext, "sensor.home_off_switch_click");
		///<summary>House Occupancy Status</summary>
		public SensorEntity HouseOccupancyStatus => new(_haContext, "sensor.house_occupancy_status");
		///<summary>icicles Power Factor</summary>
		public SensorEntity IciclesPowerFactor => new(_haContext, "sensor.icicles_power_factor");
		///<summary>Internet Time</summary>
		public SensorEntity InternetTime => new(_haContext, "sensor.internet_time");
		///<summary>iPad Activity</summary>
		public SensorEntity IpadActivity => new(_haContext, "sensor.ipad_activity");
		///<summary>iPad Battery State</summary>
		public SensorEntity IpadBatteryState => new(_haContext, "sensor.ipad_battery_state");
		///<summary>iPad BSSID</summary>
		public SensorEntity IpadBssid => new(_haContext, "sensor.ipad_bssid");
		///<summary>iPad Connection Type</summary>
		public SensorEntity IpadConnectionType => new(_haContext, "sensor.ipad_connection_type");
		///<summary>iPad Geocoded Location</summary>
		public SensorEntity IpadGeocodedLocation => new(_haContext, "sensor.ipad_geocoded_location");
		///<summary>iPad Last Update Trigger</summary>
		public SensorEntity IpadLastUpdateTrigger => new(_haContext, "sensor.ipad_last_update_trigger");
		///<summary>iPad SSID</summary>
		public SensorEntity IpadSsid => new(_haContext, "sensor.ipad_ssid");
		///<summary>IPv4 address eth0</summary>
		public SensorEntity Ipv4AddressEth0 => new(_haContext, "sensor.ipv4_address_eth0");
		///<summary>IPv6 address eth0</summary>
		public SensorEntity Ipv6AddressEth0 => new(_haContext, "sensor.ipv6_address_eth0");
		///<summary>ISS Current Location</summary>
		public SensorEntity IssCurrentLocation => new(_haContext, "sensor.iss_current_location");
		///<summary>iss_next_rise</summary>
		public SensorEntity IssNextRise => new(_haContext, "sensor.iss_next_rise");
		///<summary>ISS Pass Times</summary>
		public SensorEntity IssPassTimes => new(_haContext, "sensor.iss_pass_times");
		///<summary>Kaggi II last cleaning</summary>
		public SensorEntity KaggiIiLastCleaning => new(_haContext, "sensor.kaggi_ii_last_cleaning");
		///<summary>Kaggi II last error</summary>
		public SensorEntity KaggiIiLastError => new(_haContext, "sensor.kaggi_ii_last_error");
		///<summary>Kaggi II stats total cleanings</summary>
		public SensorEntity KaggiIiStatsTotalCleanings => new(_haContext, "sensor.kaggi_ii_stats_total_cleanings");
		///<summary>Kaggi II stats type</summary>
		public SensorEntity KaggiIiStatsType => new(_haContext, "sensor.kaggi_ii_stats_type");
		///<summary>Kettle Last Restart Time</summary>
		public SensorEntity KettleLastRestartTime => new(_haContext, "sensor.kettle_last_restart_time");
		///<summary>Kettle MQTT Connect Count</summary>
		public SensorEntity KettleMqttConnectCount => new(_haContext, "sensor.kettle_mqtt_connect_count");
		///<summary>Kettle Restart Reason</summary>
		public SensorEntity KettleRestartReason => new(_haContext, "sensor.kettle_restart_reason");
		///<summary>Kettle SSID</summary>
		public SensorEntity KettleSsid => new(_haContext, "sensor.kettle_ssid");
		///<summary>Kettle WiFi Connect Count</summary>
		public SensorEntity KettleWifiConnectCount => new(_haContext, "sensor.kettle_wifi_connect_count");
		///<summary>KingSquigglePad App Importance</summary>
		public SensorEntity KingsquigglepadAppImportance => new(_haContext, "sensor.kingsquigglepad_app_importance");
		///<summary>KingSquigglePad App Standby Bucket</summary>
		public SensorEntity KingsquigglepadAppStandbyBucket => new(_haContext, "sensor.kingsquigglepad_app_standby_bucket");
		///<summary>KingSquigglePad Audio Mode</summary>
		public SensorEntity KingsquigglepadAudioMode => new(_haContext, "sensor.kingsquigglepad_audio_mode");
		///<summary>KingSquigglePad Battery Health</summary>
		public SensorEntity KingsquigglepadBatteryHealth => new(_haContext, "sensor.kingsquigglepad_battery_health");
		///<summary>KingSquigglePad Battery State</summary>
		public SensorEntity KingsquigglepadBatteryState => new(_haContext, "sensor.kingsquigglepad_battery_state");
		///<summary>KingSquigglePad Charger Type</summary>
		public SensorEntity KingsquigglepadChargerType => new(_haContext, "sensor.kingsquigglepad_charger_type");
		///<summary>KingSquigglePad Current Time Zone</summary>
		public SensorEntity KingsquigglepadCurrentTimeZone => new(_haContext, "sensor.kingsquigglepad_current_time_zone");
		///<summary>KingSquigglePad Current Version</summary>
		public SensorEntity KingsquigglepadCurrentVersion => new(_haContext, "sensor.kingsquigglepad_current_version");
		///<summary>KingSquigglePad Detected Activity</summary>
		public SensorEntity KingsquigglepadDetectedActivity => new(_haContext, "sensor.kingsquigglepad_detected_activity");
		///<summary>KingSquigglePad Do Not Disturb Sensor</summary>
		public SensorEntity KingsquigglepadDoNotDisturbSensor => new(_haContext, "sensor.kingsquigglepad_do_not_disturb_sensor");
		///<summary>KingSquigglePad Geocoded Location</summary>
		public SensorEntity KingsquigglepadGeocodedLocation => new(_haContext, "sensor.kingsquigglepad_geocoded_location");
		///<summary>KingSquigglePad Last Reboot</summary>
		public SensorEntity KingsquigglepadLastReboot => new(_haContext, "sensor.kingsquigglepad_last_reboot");
		///<summary>KingSquigglePad Last Update Trigger</summary>
		public SensorEntity KingsquigglepadLastUpdateTrigger => new(_haContext, "sensor.kingsquigglepad_last_update_trigger");
		///<summary>KingSquigglePad Media Session</summary>
		public SensorEntity KingsquigglepadMediaSession => new(_haContext, "sensor.kingsquigglepad_media_session");
		///<summary>KingSquigglePad Next Alarm</summary>
		public SensorEntity KingsquigglepadNextAlarm => new(_haContext, "sensor.kingsquigglepad_next_alarm");
		///<summary>KingSquigglePad Phone State</summary>
		public SensorEntity KingsquigglepadPhoneState => new(_haContext, "sensor.kingsquigglepad_phone_state");
		///<summary>KingSquigglePad Public IP Address</summary>
		public SensorEntity KingsquigglepadPublicIpAddress => new(_haContext, "sensor.kingsquigglepad_public_ip_address");
		///<summary>KingSquigglePad Ringer Mode</summary>
		public SensorEntity KingsquigglepadRingerMode => new(_haContext, "sensor.kingsquigglepad_ringer_mode");
		///<summary>KingSquigglePad SIM 1</summary>
		public SensorEntity KingsquigglepadSim1 => new(_haContext, "sensor.kingsquigglepad_sim_1");
		///<summary>KingSquigglePad SIM 2</summary>
		public SensorEntity KingsquigglepadSim2 => new(_haContext, "sensor.kingsquigglepad_sim_2");
		///<summary>KingSquigglePad Volume Level Alarm</summary>
		public SensorEntity KingsquigglepadVolumeLevelAlarm => new(_haContext, "sensor.kingsquigglepad_volume_level_alarm");
		///<summary>KingSquigglePad Volume Level Call</summary>
		public SensorEntity KingsquigglepadVolumeLevelCall => new(_haContext, "sensor.kingsquigglepad_volume_level_call");
		///<summary>KingSquigglePad Volume Level Music</summary>
		public SensorEntity KingsquigglepadVolumeLevelMusic => new(_haContext, "sensor.kingsquigglepad_volume_level_music");
		///<summary>KingSquigglePad Volume Level Ringer</summary>
		public SensorEntity KingsquigglepadVolumeLevelRinger => new(_haContext, "sensor.kingsquigglepad_volume_level_ringer");
		///<summary>KingSquigglePad WiFi BSSID</summary>
		public SensorEntity KingsquigglepadWifiBssid => new(_haContext, "sensor.kingsquigglepad_wifi_bssid");
		///<summary>KingSquigglePad WiFi Connection</summary>
		public SensorEntity KingsquigglepadWifiConnection => new(_haContext, "sensor.kingsquigglepad_wifi_connection");
		///<summary>KingSquigglePad WiFi IP Address</summary>
		public SensorEntity KingsquigglepadWifiIpAddress => new(_haContext, "sensor.kingsquigglepad_wifi_ip_address");
		///<summary>Kitchen Fairy Lights Last Restart Time</summary>
		public SensorEntity KitchenFairyLightsLastRestartTime => new(_haContext, "sensor.kitchen_fairy_lights_last_restart_time");
		///<summary>Kitchen Fairy Lights MQTT Connect Count</summary>
		public SensorEntity KitchenFairyLightsMqttConnectCount => new(_haContext, "sensor.kitchen_fairy_lights_mqtt_connect_count");
		///<summary>Kitchen Fairy Lights Restart Reason</summary>
		public SensorEntity KitchenFairyLightsRestartReason => new(_haContext, "sensor.kitchen_fairy_lights_restart_reason");
		///<summary>Kitchen Fairy Lights SSID</summary>
		public SensorEntity KitchenFairyLightsSsid => new(_haContext, "sensor.kitchen_fairy_lights_ssid");
		///<summary>Kitchen Fairy Lights WiFi Connect Count</summary>
		public SensorEntity KitchenFairyLightsWifiConnectCount => new(_haContext, "sensor.kitchen_fairy_lights_wifi_connect_count");
		///<summary>Kitchen Wall Switch action</summary>
		public SensorEntity KitchenWallSwitchAction => new(_haContext, "sensor.kitchen_wall_switch_action");
		///<summary>Landfill</summary>
		public SensorEntity Landfill => new(_haContext, "sensor.landfill");
		///<summary>Last boot</summary>
		public SensorEntity LastBoot => new(_haContext, "sensor.last_boot");
		///<summary>Livingroom Wall Switch action</summary>
		public SensorEntity LivingroomWallSwitchAction => new(_haContext, "sensor.livingroom_wall_switch_action");
		///<summary>LivingroomWLED LED Count</summary>
		public SensorEntity LivingroomwledLedCount => new(_haContext, "sensor.livingroomwled_led_count");
		///<summary>Load (15m)</summary>
		public SensorEntity Load15m => new(_haContext, "sensor.load_15m");
		///<summary>Load (1m)</summary>
		public SensorEntity Load1m => new(_haContext, "sensor.load_1m");
		///<summary>Load (5m)</summary>
		public SensorEntity Load5m => new(_haContext, "sensor.load_5m");
		///<summary>Marvin Currently Playing</summary>
		public SensorEntity MarvinCurrentlyPlaying => new(_haContext, "sensor.marvin_currently_playing");
		///<summary>Kitchen Mouse Killer</summary>
		public SensorEntity MouseTrapOneStatus => new(_haContext, "sensor.mouse_trap_one_status");
		///<summary>Office Mouse Killer</summary>
		public SensorEntity MouseTrapThreeStatus => new(_haContext, "sensor.mouse_trap_three_status");
		///<summary>Toilet Mouse Killer</summary>
		public SensorEntity MouseTrapTwoStatus => new(_haContext, "sensor.mouse_trap_two_status");
		///<summary>MultiSensor 6: Node Status</summary>
		public SensorEntity Multisensor6NodeStatus => new(_haContext, "sensor.multisensor_6_node_status");
		///<summary>MultiSensor 6: Ultraviolet</summary>
		public SensorEntity Multisensor6Ultraviolet => new(_haContext, "sensor.multisensor_6_ultraviolet");
		///<summary>office_ceiling_four Uptime</summary>
		public SensorEntity OfficeCeilingFourUptime => new(_haContext, "sensor.office_ceiling_four_uptime");
		///<summary>Office Control Switch action</summary>
		public SensorEntity OfficeControlSwitchAction => new(_haContext, "sensor.office_control_switch_action");
		///<summary>Office Control Switch click</summary>
		public SensorEntity OfficeControlSwitchClick => new(_haContext, "sensor.office_control_switch_click");
		///<summary>Office Wall Switch action</summary>
		public SensorEntity OfficeWallSwitchAction => new(_haContext, "sensor.office_wall_switch_action");
		///<summary>Packets in eth0</summary>
		public SensorEntity PacketsInEth0 => new(_haContext, "sensor.packets_in_eth0");
		///<summary>Packets out eth0</summary>
		public SensorEntity PacketsOutEth0 => new(_haContext, "sensor.packets_out_eth0");
		///<summary>Potential breaking changes</summary>
		public SensorEntity PotentialBreakingChanges => new(_haContext, "sensor.potential_breaking_changes");
		///<summary>Process octave-cli</summary>
		public SensorEntity ProcessOctaveCli => new(_haContext, "sensor.process_octave_cli");
		///<summary>Recycling</summary>
		public SensorEntity Recycling => new(_haContext, "sensor.recycling");
		///<summary>reindeer Power Factor</summary>
		public SensorEntity ReindeerPowerFactor => new(_haContext, "sensor.reindeer_power_factor");
		///<summary>Samsung CLX-3300 Series</summary>
		public SensorEntity SamsungClx3300Series => new(_haContext, "sensor.samsung_clx_3300_series");
		///<summary>Samsung CLX-3300 Series Tray tray_1</summary>
		public SensorEntity SamsungClx3300SeriesTrayTray1 => new(_haContext, "sensor.samsung_clx_3300_series_tray_tray_1");
		///<summary>Server Fan ESPHome Version</summary>
		public SensorEntity ServerFanEsphomeVersion => new(_haContext, "sensor.server_fan_esphome_version");
		///<summary>Server Plug Last Restart Time</summary>
		public SensorEntity ServerPlugLastRestartTime => new(_haContext, "sensor.server_plug_last_restart_time");
		///<summary>Server Plug MQTT Connect Count</summary>
		public SensorEntity ServerPlugMqttConnectCount => new(_haContext, "sensor.server_plug_mqtt_connect_count");
		///<summary>Server Plug Restart Reason</summary>
		public SensorEntity ServerPlugRestartReason => new(_haContext, "sensor.server_plug_restart_reason");
		///<summary>Server Plug SSID</summary>
		public SensorEntity ServerPlugSsid => new(_haContext, "sensor.server_plug_ssid");
		///<summary>Server Plug WiFi Connect Count</summary>
		public SensorEntity ServerPlugWifiConnectCount => new(_haContext, "sensor.server_plug_wifi_connect_count");
		///<summary>Slartibartfarst Currently Playing</summary>
		public SensorEntity SlartibartfarstCurrentlyPlaying => new(_haContext, "sensor.slartibartfarst_currently_playing");
		///<summary>sleep_quality</summary>
		public SensorEntity SleepQuality => new(_haContext, "sensor.sleep_quality");
		///<summary>BigSquigglePad Battery Health</summary>
		public SensorEntity SmT870BatteryHealth => new(_haContext, "sensor.sm_t870_battery_health");
		///<summary>BigSquigglePad Battery State</summary>
		public SensorEntity SmT870BatteryState => new(_haContext, "sensor.sm_t870_battery_state");
		///<summary>BigSquigglePad Chjarger Type</summary>
		public SensorEntity SmT870ChargerType => new(_haContext, "sensor.sm_t870_charger_type");
		///<summary>BigSquigglePad Geocoded Location</summary>
		public SensorEntity SmT870GeocodedLocation => new(_haContext, "sensor.sm_t870_geocoded_location");
		///<summary>BigSquigglePad Phone State</summary>
		public SensorEntity SmT870PhoneState => new(_haContext, "sensor.sm_t870_phone_state");
		///<summary>BigSquigglePad Wifi Connection</summary>
		public SensorEntity SmT870WifiConnection => new(_haContext, "sensor.sm_t870_wifi_connection");
		///<summary>Small Squiggle Pad Battery Health</summary>
		public SensorEntity SmallSquigglePadBatteryHealth => new(_haContext, "sensor.small_squiggle_pad_battery_health");
		///<summary>Small Squiggle Pad Battery State</summary>
		public SensorEntity SmallSquigglePadBatteryState => new(_haContext, "sensor.small_squiggle_pad_battery_state");
		///<summary>Small Squiggle Pad Charger Type</summary>
		public SensorEntity SmallSquigglePadChargerType => new(_haContext, "sensor.small_squiggle_pad_charger_type");
		///<summary>SmallSquigglePad Battery Health</summary>
		public SensorEntity SmallsquigglepadBatteryHealth => new(_haContext, "sensor.smallsquigglepad_battery_health");
		///<summary>SmallSquigglePad Battery State</summary>
		public SensorEntity SmallsquigglepadBatteryState => new(_haContext, "sensor.smallsquigglepad_battery_state");
		///<summary>SmallSquigglePad Charger Type</summary>
		public SensorEntity SmallsquigglepadChargerType => new(_haContext, "sensor.smallsquigglepad_charger_type");
		///<summary>Snapshot State</summary>
		public SensorEntity SnapshotBackup => new(_haContext, "sensor.snapshot_backup");
		///<summary>spare_one Uptime</summary>
		public SensorEntity SpareOneUptime => new(_haContext, "sensor.spare_one_uptime");
		///<summary>SquigglePad Audio Sensor</summary>
		public SensorEntity SquigglepadAudioSensor => new(_haContext, "sensor.squigglepad_audio_sensor");
		///<summary>SquigglePad Battery Health</summary>
		public SensorEntity SquigglepadBatteryHealth => new(_haContext, "sensor.squigglepad_battery_health");
		///<summary>SquigglePad Battery State</summary>
		public SensorEntity SquigglepadBatteryState => new(_haContext, "sensor.squigglepad_battery_state");
		///<summary>SquigglePad Charger Type</summary>
		public SensorEntity SquigglepadChargerType => new(_haContext, "sensor.squigglepad_charger_type");
		///<summary>SquigglePad Detected Activity</summary>
		public SensorEntity SquigglepadDetectedActivity => new(_haContext, "sensor.squigglepad_detected_activity");
		///<summary>SquigglePad Do Not Disturb Sensor</summary>
		public SensorEntity SquigglepadDoNotDisturbSensor => new(_haContext, "sensor.squigglepad_do_not_disturb_sensor");
		///<summary>SquigglePad Geocoded Location</summary>
		public SensorEntity SquigglepadGeocodedLocation => new(_haContext, "sensor.squigglepad_geocoded_location");
		///<summary>SquigglePad Last Reboot</summary>
		public SensorEntity SquigglepadLastReboot => new(_haContext, "sensor.squigglepad_last_reboot");
		///<summary>SquigglePad Next Alarm</summary>
		public SensorEntity SquigglepadNextAlarm => new(_haContext, "sensor.squigglepad_next_alarm");
		///<summary>SquigglePhone Battery Health</summary>
		public SensorEntity SquigglephoneBatteryHealth => new(_haContext, "sensor.squigglephone_battery_health");
		///<summary>SquigglePhone Battery State</summary>
		public SensorEntity SquigglephoneBatteryState => new(_haContext, "sensor.squigglephone_battery_state");
		///<summary>SquigglePhone Charger Type</summary>
		public SensorEntity SquigglephoneChargerType => new(_haContext, "sensor.squigglephone_charger_type");
		///<summary>Squiggley 4 Button Remote action</summary>
		public SensorEntity Squiggley4ButtonRemoteAction => new(_haContext, "sensor.squiggley_4_button_remote_action");
		///<summary>Squiggley Asleep</summary>
		public SensorEntity SquiggleyAsleep => new(_haContext, "sensor.squiggley_asleep");
		///<summary>Squiggley Bed Status</summary>
		public SensorEntity SquiggleyBedStatus => new(_haContext, "sensor.squiggley_bed_status");
		///<summary>Squiggley couch</summary>
		public SensorEntity SquiggleyCouch => new(_haContext, "sensor.squiggley_couch");
		///<summary>Squiggley Heart Rate</summary>
		public SensorEntity SquiggleyHeartRate => new(_haContext, "sensor.squiggley_heart_rate");
		///<summary>Squiggley Location</summary>
		public SensorEntity SquiggleyLocation => new(_haContext, "sensor.squiggley_location");
		///<summary>Squiggley oan da couch</summary>
		public SensorEntity SquiggleyOanDaCouch => new(_haContext, "sensor.squiggley_oan_da_couch");
		///<summary>Squiggley Sleep Status</summary>
		public SensorEntity SquiggleySleepStatus => new(_haContext, "sensor.squiggley_sleep_status");
		///<summary>stag Power Factor</summary>
		public SensorEntity StagPowerFactor => new(_haContext, "sensor.stag_power_factor");
		///<summary>Stupid Box Status</summary>
		public SensorEntity StupidBoxStatus => new(_haContext, "sensor.stupid_box_status");
		///<summary>Time</summary>
		public SensorEntity Time => new(_haContext, "sensor.time");
		///<summary>Time & Date</summary>
		public SensorEntity TimeDate => new(_haContext, "sensor.time_date");
		///<summary>Time (UTC)</summary>
		public SensorEntity TimeUtc => new(_haContext, "sensor.time_utc");
		///<summary>weather_summary</summary>
		public SensorEntity WeatherSummary => new(_haContext, "sensor.weather_summary");
		///<summary>weather_temperature</summary>
		public SensorEntity WeatherTemperature => new(_haContext, "sensor.weather_temperature");
		///<summary>Wee Bear 4 Button Remote action</summary>
		public SensorEntity WeeBear4ButtonRemoteAction => new(_haContext, "sensor.wee_bear_4_button_remote_action");
		///<summary>Wee Bear Bed Status</summary>
		public SensorEntity WeeBearBedStatus => new(_haContext, "sensor.wee_bear_bed_status");
		///<summary>Wee Bear couch</summary>
		public SensorEntity WeeBearCouch => new(_haContext, "sensor.wee_bear_couch");
		///<summary>Wee Bear Location</summary>
		public SensorEntity WeeBearLocation => new(_haContext, "sensor.wee_bear_location");
		///<summary>Wee Bear oan da couch</summary>
		public SensorEntity WeeBearOanDaCouch => new(_haContext, "sensor.wee_bear_oan_da_couch");
		///<summary>Wee Bear Wall Switch action</summary>
		public SensorEntity WeeBearWallSwitchAction => new(_haContext, "sensor.wee_bear_wall_switch_action");
		///<summary>What button are you? action</summary>
		public SensorEntity WhatButtonAreYouAction => new(_haContext, "sensor.what_button_are_you_action");
		///<summary>What button are you? click</summary>
		public SensorEntity WhatButtonAreYouClick => new(_haContext, "sensor.what_button_are_you_click");
		///<summary>SquigglePad Wifi Connection</summary>
		public SensorEntity WifiConnection => new(_haContext, "sensor.wifi_connection");
		///<summary>Z‐Stick Gen5 USB Controller: Node Status</summary>
		public SensorEntity ZStickGen5UsbControllerNodeStatus => new(_haContext, "sensor.z_stick_gen5_usb_controller_node_status");
		///<summary>Zaphod Currently Playing</summary>
		public SensorEntity ZaphodCurrentlyPlaying => new(_haContext, "sensor.zaphod_currently_playing");
		///<summary>ZaphodWLED LED Count</summary>
		public SensorEntity ZaphodwledLedCount => new(_haContext, "sensor.zaphodwled_led_count");
	}

	public class SunEntities
	{
		private readonly IHaContext _haContext;
		public SunEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sun</summary>
		public SunEntity Sun => new(_haContext, "sun.sun");
	}

	public class SwitchEntities
	{
		private readonly IHaContext _haContext;
		public SwitchEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Ambilight Relay</summary>
		public SwitchEntity AmbilightRelay => new(_haContext, "switch.ambilight_relay");
		///<summary>back_garden_lights</summary>
		public SwitchEntity BackGardenLights => new(_haContext, "switch.back_garden_lights");
		///<summary>Back Garden Motion led_indication</summary>
		public SwitchEntity BackGardenMotionLedIndication => new(_haContext, "switch.back_garden_motion_led_indication");
		///<summary>Castle Motion led_indication</summary>
		public SwitchEntity CastleMotionLedIndication => new(_haContext, "switch.castle_motion_led_indication");
		///<summary>christmas_tree Relay</summary>
		public SwitchEntity ChristmasTreeRelay => new(_haContext, "switch.christmas_tree_relay");
		///<summary>christmas_tree Restart</summary>
		public SwitchEntity ChristmasTreeRestart => new(_haContext, "switch.christmas_tree_restart");
		///<summary>Tasmota</summary>
		public SwitchEntity FairyLights => new(_haContext, "switch.fairy_lights");
		///<summary>Firework Lights</summary>
		public SwitchEntity FireworkLights => new(_haContext, "switch.firework_lights");
		///<summary>Front Garden</summary>
		public SwitchEntity FrontGarden => new(_haContext, "switch.front_garden");
		///<summary>Front Gate Motion led_indication</summary>
		public SwitchEntity FrontGateMotionLedIndication => new(_haContext, "switch.front_gate_motion_led_indication");
		///<summary>Garage Roof Motion led_indication</summary>
		public SwitchEntity GarageRoofMotionLedIndication => new(_haContext, "switch.garage_roof_motion_led_indication");
		///<summary>Hall Fairy Lights LED</summary>
		public SwitchEntity HallFairyLightsLed => new(_haContext, "switch.hall_fairy_lights_led");
		///<summary>heart-of-gold_array</summary>
		public SwitchEntity HeartOfGoldArray => new(_haContext, "switch.heart_of_gold_array");
		///<summary>heart-of-gold_docker_adminer</summary>
		public SwitchEntity HeartOfGoldDockerAdminer => new(_haContext, "switch.heart_of_gold_docker_adminer");
		///<summary>heart-of-gold_docker_agent</summary>
		public SwitchEntity HeartOfGoldDockerAgent => new(_haContext, "switch.heart_of_gold_docker_agent");
		///<summary>heart-of-gold_docker_airsonic</summary>
		public SwitchEntity HeartOfGoldDockerAirsonic => new(_haContext, "switch.heart_of_gold_docker_airsonic");
		///<summary>heart-of-gold_docker_amtd</summary>
		public SwitchEntity HeartOfGoldDockerAmtd => new(_haContext, "switch.heart_of_gold_docker_amtd");
		///<summary>heart-of-gold_docker_apacheguacamole</summary>
		public SwitchEntity HeartOfGoldDockerApacheguacamole => new(_haContext, "switch.heart_of_gold_docker_apacheguacamole");
		///<summary>heart-of-gold_docker_backupsql</summary>
		public SwitchEntity HeartOfGoldDockerBackupsql => new(_haContext, "switch.heart_of_gold_docker_backupsql");
		///<summary>heart-of-gold_docker_bazarr</summary>
		public SwitchEntity HeartOfGoldDockerBazarr => new(_haContext, "switch.heart_of_gold_docker_bazarr");
		///<summary>heart-of-gold_docker_beets</summary>
		public SwitchEntity HeartOfGoldDockerBeets => new(_haContext, "switch.heart_of_gold_docker_beets");
		///<summary>heart-of-gold_docker_binhex-deluge</summary>
		public SwitchEntity HeartOfGoldDockerBinhexDeluge => new(_haContext, "switch.heart_of_gold_docker_binhex_deluge");
		///<summary>heart-of-gold_docker_binhex-get-iplayer</summary>
		public SwitchEntity HeartOfGoldDockerBinhexGetIplayer => new(_haContext, "switch.heart_of_gold_docker_binhex_get_iplayer");
		///<summary>heart-of-gold_docker_binhex-jackett</summary>
		public SwitchEntity HeartOfGoldDockerBinhexJackett => new(_haContext, "switch.heart_of_gold_docker_binhex_jackett");
		///<summary>heart-of-gold_docker_binhex-lidarr</summary>
		public SwitchEntity HeartOfGoldDockerBinhexLidarr => new(_haContext, "switch.heart_of_gold_docker_binhex_lidarr");
		///<summary>heart-of-gold_docker_binhex-sabnzbd</summary>
		public SwitchEntity HeartOfGoldDockerBinhexSabnzbd => new(_haContext, "switch.heart_of_gold_docker_binhex_sabnzbd");
		///<summary>heart-of-gold_docker_bitwardenrs</summary>
		public SwitchEntity HeartOfGoldDockerBitwardenrs => new(_haContext, "switch.heart_of_gold_docker_bitwardenrs");
		///<summary>heart-of-gold_docker_bookstack</summary>
		public SwitchEntity HeartOfGoldDockerBookstack => new(_haContext, "switch.heart_of_gold_docker_bookstack");
		///<summary>heart-of-gold_docker_chevereto</summary>
		public SwitchEntity HeartOfGoldDockerChevereto => new(_haContext, "switch.heart_of_gold_docker_chevereto");
		///<summary>heart-of-gold_docker_chowdown</summary>
		public SwitchEntity HeartOfGoldDockerChowdown => new(_haContext, "switch.heart_of_gold_docker_chowdown");
		///<summary>heart-of-gold_docker_chronograf</summary>
		public SwitchEntity HeartOfGoldDockerChronograf => new(_haContext, "switch.heart_of_gold_docker_chronograf");
		///<summary>heart-of-gold_docker_chronos</summary>
		public SwitchEntity HeartOfGoldDockerChronos => new(_haContext, "switch.heart_of_gold_docker_chronos");
		///<summary>heart-of-gold_docker_clamav</summary>
		public SwitchEntity HeartOfGoldDockerClamav => new(_haContext, "switch.heart_of_gold_docker_clamav");
		///<summary>heart-of-gold_docker_deepstack</summary>
		public SwitchEntity HeartOfGoldDockerDeepstack => new(_haContext, "switch.heart_of_gold_docker_deepstack");
		///<summary>heart-of-gold_docker_deepstack-ui</summary>
		public SwitchEntity HeartOfGoldDockerDeepstackUi => new(_haContext, "switch.heart_of_gold_docker_deepstack_ui");
		///<summary>heart-of-gold_docker_diskspeed</summary>
		public SwitchEntity HeartOfGoldDockerDiskspeed => new(_haContext, "switch.heart_of_gold_docker_diskspeed");
		///<summary>heart-of-gold_docker_docker-webui</summary>
		public SwitchEntity HeartOfGoldDockerDockerWebui => new(_haContext, "switch.heart_of_gold_docker_docker_webui");
		///<summary>heart-of-gold_docker_dolphin</summary>
		public SwitchEntity HeartOfGoldDockerDolphin => new(_haContext, "switch.heart_of_gold_docker_dolphin");
		///<summary>heart-of-gold_docker_dupeguru</summary>
		public SwitchEntity HeartOfGoldDockerDupeguru => new(_haContext, "switch.heart_of_gold_docker_dupeguru");
		///<summary>heart-of-gold_docker_elasticsearch</summary>
		public SwitchEntity HeartOfGoldDockerElasticsearch => new(_haContext, "switch.heart_of_gold_docker_elasticsearch");
		///<summary>heart-of-gold_docker_filebrowser</summary>
		public SwitchEntity HeartOfGoldDockerFilebrowser => new(_haContext, "switch.heart_of_gold_docker_filebrowser");
		///<summary>heart-of-gold_docker_firefly-iii</summary>
		public SwitchEntity HeartOfGoldDockerFireflyIii => new(_haContext, "switch.heart_of_gold_docker_firefly_iii");
		///<summary>heart-of-gold_docker_firefox</summary>
		public SwitchEntity HeartOfGoldDockerFirefox => new(_haContext, "switch.heart_of_gold_docker_firefox");
		///<summary>heart-of-gold_docker_flame</summary>
		public SwitchEntity HeartOfGoldDockerFlame => new(_haContext, "switch.heart_of_gold_docker_flame");
		///<summary>heart-of-gold_docker_fluentd</summary>
		public SwitchEntity HeartOfGoldDockerFluentd => new(_haContext, "switch.heart_of_gold_docker_fluentd");
		///<summary>heart-of-gold_docker_funkwhale</summary>
		public SwitchEntity HeartOfGoldDockerFunkwhale => new(_haContext, "switch.heart_of_gold_docker_funkwhale");
		///<summary>heart-of-gold_docker_get_iplayer</summary>
		public SwitchEntity HeartOfGoldDockerGetIplayer => new(_haContext, "switch.heart_of_gold_docker_get_iplayer");
		///<summary>heart-of-gold_docker_get-iplayer</summary>
		public SwitchEntity HeartOfGoldDockerGetIplayer2 => new(_haContext, "switch.heart_of_gold_docker_get_iplayer_2");
		///<summary>heart-of-gold_docker_glances</summary>
		public SwitchEntity HeartOfGoldDockerGlances => new(_haContext, "switch.heart_of_gold_docker_glances");
		///<summary>heart-of-gold_docker_goaccess</summary>
		public SwitchEntity HeartOfGoldDockerGoaccess => new(_haContext, "switch.heart_of_gold_docker_goaccess");
		///<summary>heart-of-gold_docker_gogs</summary>
		public SwitchEntity HeartOfGoldDockerGogs => new(_haContext, "switch.heart_of_gold_docker_gogs");
		///<summary>heart-of-gold_docker_googlephotossync</summary>
		public SwitchEntity HeartOfGoldDockerGooglephotossync => new(_haContext, "switch.heart_of_gold_docker_googlephotossync");
		///<summary>heart-of-gold_docker_grafana</summary>
		public SwitchEntity HeartOfGoldDockerGrafana => new(_haContext, "switch.heart_of_gold_docker_grafana");
		///<summary>heart-of-gold_docker_graylog</summary>
		public SwitchEntity HeartOfGoldDockerGraylog => new(_haContext, "switch.heart_of_gold_docker_graylog");
		///<summary>heart-of-gold_docker_hddtemp</summary>
		public SwitchEntity HeartOfGoldDockerHddtemp => new(_haContext, "switch.heart_of_gold_docker_hddtemp");
		///<summary>heart-of-gold_docker_hydra2</summary>
		public SwitchEntity HeartOfGoldDockerHydra2 => new(_haContext, "switch.heart_of_gold_docker_hydra2");
		///<summary>heart-of-gold_docker_influxdb</summary>
		public SwitchEntity HeartOfGoldDockerInfluxdb => new(_haContext, "switch.heart_of_gold_docker_influxdb");
		///<summary>heart-of-gold_docker_jackett</summary>
		public SwitchEntity HeartOfGoldDockerJackett => new(_haContext, "switch.heart_of_gold_docker_jackett");
		///<summary>heart-of-gold_docker_jbreed-nessus</summary>
		public SwitchEntity HeartOfGoldDockerJbreedNessus => new(_haContext, "switch.heart_of_gold_docker_jbreed_nessus");
		///<summary>heart-of-gold_docker_kapacitor</summary>
		public SwitchEntity HeartOfGoldDockerKapacitor => new(_haContext, "switch.heart_of_gold_docker_kapacitor");
		///<summary>heart-of-gold_docker_kibana</summary>
		public SwitchEntity HeartOfGoldDockerKibana => new(_haContext, "switch.heart_of_gold_docker_kibana");
		///<summary>heart-of-gold_docker_label-studio</summary>
		public SwitchEntity HeartOfGoldDockerLabelStudio => new(_haContext, "switch.heart_of_gold_docker_label_studio");
		///<summary>heart-of-gold_docker_leantime</summary>
		public SwitchEntity HeartOfGoldDockerLeantime => new(_haContext, "switch.heart_of_gold_docker_leantime");
		///<summary>heart-of-gold_docker_lidarr</summary>
		public SwitchEntity HeartOfGoldDockerLidarr => new(_haContext, "switch.heart_of_gold_docker_lidarr");
		///<summary>heart-of-gold_docker_listarr</summary>
		public SwitchEntity HeartOfGoldDockerListarr => new(_haContext, "switch.heart_of_gold_docker_listarr");
		///<summary>heart-of-gold_docker_logitechmediaserver</summary>
		public SwitchEntity HeartOfGoldDockerLogitechmediaserver => new(_haContext, "switch.heart_of_gold_docker_logitechmediaserver");
		///<summary>heart-of-gold_docker_lychee</summary>
		public SwitchEntity HeartOfGoldDockerLychee => new(_haContext, "switch.heart_of_gold_docker_lychee");
		///<summary>heart-of-gold_docker_maltrail</summary>
		public SwitchEntity HeartOfGoldDockerMaltrail => new(_haContext, "switch.heart_of_gold_docker_maltrail");
		///<summary>heart-of-gold_docker_mariadb</summary>
		public SwitchEntity HeartOfGoldDockerMariadb => new(_haContext, "switch.heart_of_gold_docker_mariadb");
		///<summary>heart-of-gold_docker_mongodb</summary>
		public SwitchEntity HeartOfGoldDockerMongodb => new(_haContext, "switch.heart_of_gold_docker_mongodb");
		///<summary>heart-of-gold_docker_monitorr</summary>
		public SwitchEntity HeartOfGoldDockerMonitorr => new(_haContext, "switch.heart_of_gold_docker_monitorr");
		///<summary>heart-of-gold_docker_moviematch</summary>
		public SwitchEntity HeartOfGoldDockerMoviematch => new(_haContext, "switch.heart_of_gold_docker_moviematch");
		///<summary>heart-of-gold_docker_netbootxyz</summary>
		public SwitchEntity HeartOfGoldDockerNetbootxyz => new(_haContext, "switch.heart_of_gold_docker_netbootxyz");
		///<summary>heart-of-gold_docker_netdata</summary>
		public SwitchEntity HeartOfGoldDockerNetdata => new(_haContext, "switch.heart_of_gold_docker_netdata");
		///<summary>heart-of-gold_docker_nextcloud</summary>
		public SwitchEntity HeartOfGoldDockerNextcloud => new(_haContext, "switch.heart_of_gold_docker_nextcloud");
		///<summary>heart-of-gold_docker_nginxproxymanager</summary>
		public SwitchEntity HeartOfGoldDockerNginxproxymanager => new(_haContext, "switch.heart_of_gold_docker_nginxproxymanager");
		///<summary>heart-of-gold_docker_node-deepstackai-trigger</summary>
		public SwitchEntity HeartOfGoldDockerNodeDeepstackaiTrigger => new(_haContext, "switch.heart_of_gold_docker_node_deepstackai_trigger");
		///<summary>heart-of-gold_docker_nosqlclient</summary>
		public SwitchEntity HeartOfGoldDockerNosqlclient => new(_haContext, "switch.heart_of_gold_docker_nosqlclient");
		///<summary>heart-of-gold_docker_nowshowingv2</summary>
		public SwitchEntity HeartOfGoldDockerNowshowingv2 => new(_haContext, "switch.heart_of_gold_docker_nowshowingv2");
		///<summary>heart-of-gold_docker_nzbget</summary>
		public SwitchEntity HeartOfGoldDockerNzbget => new(_haContext, "switch.heart_of_gold_docker_nzbget");
		///<summary>heart-of-gold_docker_nzbhydra2</summary>
		public SwitchEntity HeartOfGoldDockerNzbhydra2 => new(_haContext, "switch.heart_of_gold_docker_nzbhydra2");
		///<summary>heart-of-gold_docker_ombi</summary>
		public SwitchEntity HeartOfGoldDockerOmbi => new(_haContext, "switch.heart_of_gold_docker_ombi");
		///<summary>heart-of-gold_docker_openbudgeteer</summary>
		public SwitchEntity HeartOfGoldDockerOpenbudgeteer => new(_haContext, "switch.heart_of_gold_docker_openbudgeteer");
		///<summary>heart-of-gold_docker_organizrv2</summary>
		public SwitchEntity HeartOfGoldDockerOrganizrv2 => new(_haContext, "switch.heart_of_gold_docker_organizrv2");
		///<summary>heart-of-gold_docker_overseerr</summary>
		public SwitchEntity HeartOfGoldDockerOverseerr => new(_haContext, "switch.heart_of_gold_docker_overseerr");
		///<summary>heart-of-gold_docker_p3r-openrgb</summary>
		public SwitchEntity HeartOfGoldDockerP3rOpenrgb => new(_haContext, "switch.heart_of_gold_docker_p3r_openrgb");
		///<summary>heart-of-gold_docker_pgadmin4</summary>
		public SwitchEntity HeartOfGoldDockerPgadmin4 => new(_haContext, "switch.heart_of_gold_docker_pgadmin4");
		///<summary>heart-of-gold_docker_phlex</summary>
		public SwitchEntity HeartOfGoldDockerPhlex => new(_haContext, "switch.heart_of_gold_docker_phlex");
		///<summary>heart-of-gold_docker_photoprism</summary>
		public SwitchEntity HeartOfGoldDockerPhotoprism => new(_haContext, "switch.heart_of_gold_docker_photoprism");
		///<summary>heart-of-gold_docker_photostructure</summary>
		public SwitchEntity HeartOfGoldDockerPhotostructure => new(_haContext, "switch.heart_of_gold_docker_photostructure");
		///<summary>heart-of-gold_docker_phpmyadmin</summary>
		public SwitchEntity HeartOfGoldDockerPhpmyadmin => new(_haContext, "switch.heart_of_gold_docker_phpmyadmin");
		///<summary>heart-of-gold_docker_piwigo</summary>
		public SwitchEntity HeartOfGoldDockerPiwigo => new(_haContext, "switch.heart_of_gold_docker_piwigo");
		///<summary>heart-of-gold_docker_plex</summary>
		public SwitchEntity HeartOfGoldDockerPlex => new(_haContext, "switch.heart_of_gold_docker_plex");
		///<summary>heart-of-gold_docker_plex-meta-manager</summary>
		public SwitchEntity HeartOfGoldDockerPlexMetaManager => new(_haContext, "switch.heart_of_gold_docker_plex_meta_manager");
		///<summary>heart-of-gold_docker_plexmediaserver</summary>
		public SwitchEntity HeartOfGoldDockerPlexmediaserver => new(_haContext, "switch.heart_of_gold_docker_plexmediaserver");
		///<summary>heart-of-gold_docker_poste</summary>
		public SwitchEntity HeartOfGoldDockerPoste => new(_haContext, "switch.heart_of_gold_docker_poste");
		///<summary>heart-of-gold_docker_postgres11</summary>
		public SwitchEntity HeartOfGoldDockerPostgres11 => new(_haContext, "switch.heart_of_gold_docker_postgres11");
		///<summary>heart-of-gold_docker_ptsync</summary>
		public SwitchEntity HeartOfGoldDockerPtsync => new(_haContext, "switch.heart_of_gold_docker_ptsync");
		///<summary>heart-of-gold_docker_qbittorrent</summary>
		public SwitchEntity HeartOfGoldDockerQbittorrent => new(_haContext, "switch.heart_of_gold_docker_qbittorrent");
		///<summary>heart-of-gold_docker_radarr</summary>
		public SwitchEntity HeartOfGoldDockerRadarr => new(_haContext, "switch.heart_of_gold_docker_radarr");
		///<summary>heart-of-gold_docker_raneto</summary>
		public SwitchEntity HeartOfGoldDockerRaneto => new(_haContext, "switch.heart_of_gold_docker_raneto");
		///<summary>heart-of-gold_docker_rebuild-dndc</summary>
		public SwitchEntity HeartOfGoldDockerRebuildDndc => new(_haContext, "switch.heart_of_gold_docker_rebuild_dndc");
		///<summary>heart-of-gold_docker_redmine</summary>
		public SwitchEntity HeartOfGoldDockerRedmine => new(_haContext, "switch.heart_of_gold_docker_redmine");
		///<summary>heart-of-gold_docker_sabnzbd</summary>
		public SwitchEntity HeartOfGoldDockerSabnzbd => new(_haContext, "switch.heart_of_gold_docker_sabnzbd");
		///<summary>heart-of-gold_docker_scrutiny</summary>
		public SwitchEntity HeartOfGoldDockerScrutiny => new(_haContext, "switch.heart_of_gold_docker_scrutiny");
		///<summary>heart-of-gold_docker_shoginn-dump1090</summary>
		public SwitchEntity HeartOfGoldDockerShoginnDump1090 => new(_haContext, "switch.heart_of_gold_docker_shoginn_dump1090");
		///<summary>heart-of-gold_docker_shoginn-vrs</summary>
		public SwitchEntity HeartOfGoldDockerShoginnVrs => new(_haContext, "switch.heart_of_gold_docker_shoginn_vrs");
		///<summary>heart-of-gold_docker_skydive-ui</summary>
		public SwitchEntity HeartOfGoldDockerSkydiveUi => new(_haContext, "switch.heart_of_gold_docker_skydive_ui");
		///<summary>heart-of-gold_docker_snipe-it</summary>
		public SwitchEntity HeartOfGoldDockerSnipeIt => new(_haContext, "switch.heart_of_gold_docker_snipe_it");
		///<summary>heart-of-gold_docker_sonarr</summary>
		public SwitchEntity HeartOfGoldDockerSonarr => new(_haContext, "switch.heart_of_gold_docker_sonarr");
		///<summary>heart-of-gold_docker_soulseek</summary>
		public SwitchEntity HeartOfGoldDockerSoulseek => new(_haContext, "switch.heart_of_gold_docker_soulseek");
		///<summary>heart-of-gold_docker_splunk</summary>
		public SwitchEntity HeartOfGoldDockerSplunk => new(_haContext, "switch.heart_of_gold_docker_splunk");
		///<summary>heart-of-gold_docker_statping</summary>
		public SwitchEntity HeartOfGoldDockerStatping => new(_haContext, "switch.heart_of_gold_docker_statping");
		///<summary>heart-of-gold_docker_stun-turn-server</summary>
		public SwitchEntity HeartOfGoldDockerStunTurnServer => new(_haContext, "switch.heart_of_gold_docker_stun_turn_server");
		///<summary>heart-of-gold_docker_syncthing</summary>
		public SwitchEntity HeartOfGoldDockerSyncthing => new(_haContext, "switch.heart_of_gold_docker_syncthing");
		///<summary>heart-of-gold_docker_taskcafe</summary>
		public SwitchEntity HeartOfGoldDockerTaskcafe => new(_haContext, "switch.heart_of_gold_docker_taskcafe");
		///<summary>heart-of-gold_docker_tautulli</summary>
		public SwitchEntity HeartOfGoldDockerTautulli => new(_haContext, "switch.heart_of_gold_docker_tautulli");
		///<summary>heart-of-gold_docker_telegraf</summary>
		public SwitchEntity HeartOfGoldDockerTelegraf => new(_haContext, "switch.heart_of_gold_docker_telegraf");
		///<summary>heart-of-gold_docker_unifi-controller</summary>
		public SwitchEntity HeartOfGoldDockerUnifiController => new(_haContext, "switch.heart_of_gold_docker_unifi_controller");
		///<summary>heart-of-gold_docker_unifibrowser</summary>
		public SwitchEntity HeartOfGoldDockerUnifibrowser => new(_haContext, "switch.heart_of_gold_docker_unifibrowser");
		///<summary>heart-of-gold_docker_unraid-api</summary>
		public SwitchEntity HeartOfGoldDockerUnraidApi => new(_haContext, "switch.heart_of_gold_docker_unraid_api");
		///<summary>heart-of-gold_docker_varken</summary>
		public SwitchEntity HeartOfGoldDockerVarken => new(_haContext, "switch.heart_of_gold_docker_varken");
		///<summary>heart-of-gold_docker_wekan</summary>
		public SwitchEntity HeartOfGoldDockerWekan => new(_haContext, "switch.heart_of_gold_docker_wekan");
		///<summary>heart-of-gold_docker_wger-unraid</summary>
		public SwitchEntity HeartOfGoldDockerWgerUnraid => new(_haContext, "switch.heart_of_gold_docker_wger_unraid");
		///<summary>heart-of-gold_docker_whoami</summary>
		public SwitchEntity HeartOfGoldDockerWhoami => new(_haContext, "switch.heart_of_gold_docker_whoami");
		///<summary>heart-of-gold_docker_youtube-dl-server</summary>
		public SwitchEntity HeartOfGoldDockerYoutubeDlServer => new(_haContext, "switch.heart_of_gold_docker_youtube_dl_server");
		///<summary>heart-of-gold_mover</summary>
		public SwitchEntity HeartOfGoldMover => new(_haContext, "switch.heart_of_gold_mover");
		///<summary>heart-of-gold_partityCheck</summary>
		public SwitchEntity HeartOfGoldPartitycheck => new(_haContext, "switch.heart_of_gold_partitycheck");
		///<summary>heart-of-gold_power_off</summary>
		public SwitchEntity HeartOfGoldPowerOff => new(_haContext, "switch.heart_of_gold_power_off");
		///<summary>heart-of-gold_reboot</summary>
		public SwitchEntity HeartOfGoldReboot => new(_haContext, "switch.heart_of_gold_reboot");
		///<summary>heart-of-gold_VM_blazor_dev_environment</summary>
		public SwitchEntity HeartOfGoldVmBlazorDevEnvironment => new(_haContext, "switch.heart_of_gold_vm_blazor_dev_environment");
		///<summary>heart-of-gold_VM_blazor_dev_environment_USB_asustek_computer_aura_led_controller</summary>
		public SwitchEntity HeartOfGoldVmBlazorDevEnvironmentUsbAsustekComputerAuraLedController => new(_haContext, "switch.heart_of_gold_vm_blazor_dev_environment_usb_asustek_computer_aura_led_controller");
		///<summary>heart-of-gold_VM_blazor_dev_environment_USB_cooler_master_technology_inc_amd_sr4_lamplight_control</summary>
		public SwitchEntity HeartOfGoldVmBlazorDevEnvironmentUsbCoolerMasterTechnologyIncAmdSr4LamplightControl => new(_haContext, "switch.heart_of_gold_vm_blazor_dev_environment_usb_cooler_master_technology_inc_amd_sr4_lamplight_control");
		///<summary>heart-of-gold_VM_blazor_dev_environment_USB_intel_corp</summary>
		public SwitchEntity HeartOfGoldVmBlazorDevEnvironmentUsbIntelCorp => new(_haContext, "switch.heart_of_gold_vm_blazor_dev_environment_usb_intel_corp");
		///<summary>heart-of-gold_VM_ubuntu</summary>
		public SwitchEntity HeartOfGoldVmUbuntu => new(_haContext, "switch.heart_of_gold_vm_ubuntu");
		///<summary>heart-of-gold_VM_ubuntu_USB_asustek_computer_aura_led_controller</summary>
		public SwitchEntity HeartOfGoldVmUbuntuUsbAsustekComputerAuraLedController => new(_haContext, "switch.heart_of_gold_vm_ubuntu_usb_asustek_computer_aura_led_controller");
		///<summary>heart-of-gold_VM_ubuntu_USB_cooler_master_technology_inc_amd_sr4_lamplight_control</summary>
		public SwitchEntity HeartOfGoldVmUbuntuUsbCoolerMasterTechnologyIncAmdSr4LamplightControl => new(_haContext, "switch.heart_of_gold_vm_ubuntu_usb_cooler_master_technology_inc_amd_sr4_lamplight_control");
		///<summary>heart-of-gold_VM_ubuntu_USB_intel_corp</summary>
		public SwitchEntity HeartOfGoldVmUbuntuUsbIntelCorp => new(_haContext, "switch.heart_of_gold_vm_ubuntu_usb_intel_corp");
		///<summary>Helto switch</summary>
		public SwitchEntity HeltoSwitch => new(_haContext, "switch.helto_switch");
		///<summary>icicles Relay</summary>
		public SwitchEntity IciclesRelay => new(_haContext, "switch.icicles_relay");
		///<summary>icicles Restart</summary>
		public SwitchEntity IciclesRestart => new(_haContext, "switch.icicles_restart");
		///<summary>Kaggi II advanced mode</summary>
		public SwitchEntity KaggiIiAdvancedMode => new(_haContext, "switch.kaggi_ii_advanced_mode");
		///<summary>Kaggi II carpet auto fan speed boost</summary>
		public SwitchEntity KaggiIiCarpetAutoFanSpeedBoost => new(_haContext, "switch.kaggi_ii_carpet_auto_fan_speed_boost");
		///<summary>Kaggi II continuous cleaning</summary>
		public SwitchEntity KaggiIiContinuousCleaning => new(_haContext, "switch.kaggi_ii_continuous_cleaning");
		///<summary>Kettle</summary>
		public SwitchEntity Kettle => new(_haContext, "switch.kettle");
		///<summary>Kitchen Fairy Lights</summary>
		public SwitchEntity KitchenFairyLights => new(_haContext, "switch.kitchen_fairy_lights");
		///<summary>Kitchen Spiral Lights</summary>
		public SwitchEntity KitchenSpiralLights => new(_haContext, "switch.kitchen_spiral_lights");
		///<summary>Kitchen Tree Relay</summary>
		public SwitchEntity KitchenTreeRelay => new(_haContext, "switch.kitchen_tree_relay");
		///<summary>LivingroomWLED Nightlight</summary>
		public SwitchEntity LivingroomwledNightlight => new(_haContext, "switch.livingroomwled_nightlight");
		///<summary>LivingroomWLED Reverse</summary>
		public SwitchEntity LivingroomwledReverse => new(_haContext, "switch.livingroomwled_reverse");
		///<summary>LivingroomWLED Sync Receive</summary>
		public SwitchEntity LivingroomwledSyncReceive => new(_haContext, "switch.livingroomwled_sync_receive");
		///<summary>LivingroomWLED Sync Send</summary>
		public SwitchEntity LivingroomwledSyncSend => new(_haContext, "switch.livingroomwled_sync_send");
		///<summary>Monitors</summary>
		public SwitchEntity Monitors => new(_haContext, "switch.monitors");
		///<summary>Spotlight</summary>
		public SwitchEntity OfficeSpotlight => new(_haContext, "switch.office_spotlight");
		///<summary>reindeer Relay</summary>
		public SwitchEntity ReindeerRelay => new(_haContext, "switch.reindeer_relay");
		///<summary>reindeer Relay</summary>
		public SwitchEntity ReindeerRelay2 => new(_haContext, "switch.reindeer_relay_2");
		///<summary>reindeer Relay</summary>
		public SwitchEntity ReindeerRelay3 => new(_haContext, "switch.reindeer_relay_3");
		///<summary>reindeer Restart</summary>
		public SwitchEntity ReindeerRestart => new(_haContext, "switch.reindeer_restart");
		///<summary>reindeer Restart</summary>
		public SwitchEntity ReindeerRestart2 => new(_haContext, "switch.reindeer_restart_2");
		///<summary>reindeer Restart</summary>
		public SwitchEntity ReindeerRestart3 => new(_haContext, "switch.reindeer_restart_3");
		///<summary>Server Fan POW Relay</summary>
		public SwitchEntity ServerFanPowRelay => new(_haContext, "switch.server_fan_pow_relay");
		///<summary>Server Fan Relay</summary>
		public SwitchEntity ServerFanRelay => new(_haContext, "switch.server_fan_relay");
		///<summary>Server Plug</summary>
		public SwitchEntity ServerPlug => new(_haContext, "switch.server_plug");
		///<summary>Slow Cooker</summary>
		public SwitchEntity SlowCookerRelay => new(_haContext, "switch.slow_cooker_relay");
		public SwitchEntity SonoffBasicRelay => new(_haContext, "switch.sonoff_basic_relay");
		public SwitchEntity SonoffS20Restart => new(_haContext, "switch.sonoff_s20_restart");
		///<summary>Spiral Lights Blue</summary>
		public SwitchEntity SpiralLightsBlue => new(_haContext, "switch.spiral_lights_blue");
		///<summary>Spiral Lights Brighter</summary>
		public SwitchEntity SpiralLightsBrighter => new(_haContext, "switch.spiral_lights_brighter");
		///<summary>Spiral Lights Dark Blue</summary>
		public SwitchEntity SpiralLightsDarkBlue => new(_haContext, "switch.spiral_lights_dark_blue");
		///<summary>Spiral Lights Dark Green</summary>
		public SwitchEntity SpiralLightsDarkGreen => new(_haContext, "switch.spiral_lights_dark_green");
		///<summary>Spiral Lights Dark Purple</summary>
		public SwitchEntity SpiralLightsDarkPurple => new(_haContext, "switch.spiral_lights_dark_purple");
		///<summary>Spiral Lights Dark Red</summary>
		public SwitchEntity SpiralLightsDarkRed => new(_haContext, "switch.spiral_lights_dark_red");
		///<summary>Spiral Lights Fade</summary>
		public SwitchEntity SpiralLightsFade => new(_haContext, "switch.spiral_lights_fade");
		///<summary>Spiral Lights Flash</summary>
		public SwitchEntity SpiralLightsFlash => new(_haContext, "switch.spiral_lights_flash");
		///<summary>Spiral Lights Green</summary>
		public SwitchEntity SpiralLightsGreen => new(_haContext, "switch.spiral_lights_green");
		///<summary>Spiral Lights Light Blue</summary>
		public SwitchEntity SpiralLightsLightBlue => new(_haContext, "switch.spiral_lights_light_blue");
		///<summary>Spiral Lights Light Orange</summary>
		public SwitchEntity SpiralLightsLightOrange => new(_haContext, "switch.spiral_lights_light_orange");
		///<summary>Spiral Lights Light Pink</summary>
		public SwitchEntity SpiralLightsLightPink => new(_haContext, "switch.spiral_lights_light_pink");
		///<summary>Spiral Lights Orange</summary>
		public SwitchEntity SpiralLightsOrange => new(_haContext, "switch.spiral_lights_orange");
		///<summary>Spiral Lights Pink</summary>
		public SwitchEntity SpiralLightsPink => new(_haContext, "switch.spiral_lights_pink");
		///<summary>Spiral Lights Purple</summary>
		public SwitchEntity SpiralLightsPurple => new(_haContext, "switch.spiral_lights_purple");
		///<summary>Spiral Lights Red</summary>
		public SwitchEntity SpiralLightsRed => new(_haContext, "switch.spiral_lights_red");
		///<summary>Spiral Lights Sarker</summary>
		public SwitchEntity SpiralLightsSarker => new(_haContext, "switch.spiral_lights_sarker");
		///<summary>Spiral Lights Smooth</summary>
		public SwitchEntity SpiralLightsSmooth => new(_haContext, "switch.spiral_lights_smooth");
		///<summary>Spiral Lights Strobe</summary>
		public SwitchEntity SpiralLightsStrobe => new(_haContext, "switch.spiral_lights_strobe");
		///<summary>Spiral Lights Turquoise</summary>
		public SwitchEntity SpiralLightsTurquoise => new(_haContext, "switch.spiral_lights_turquoise");
		///<summary>Spiral Lights White</summary>
		public SwitchEntity SpiralLightsWhite => new(_haContext, "switch.spiral_lights_white");
		///<summary>Spiral Lights Yellow</summary>
		public SwitchEntity SpiralLightsYellow => new(_haContext, "switch.spiral_lights_yellow");
		///<summary>Squiggley Desktop</summary>
		public SwitchEntity SquiggleyDesktop => new(_haContext, "switch.squiggley_desktop");
		///<summary>stag Relay</summary>
		public SwitchEntity StagRelay => new(_haContext, "switch.stag_relay");
		///<summary>stag Restart</summary>
		public SwitchEntity StagRestart => new(_haContext, "switch.stag_restart");
		///<summary>turn_on_eddie</summary>
		public SwitchEntity TurnOnEddie => new(_haContext, "switch.turn_on_eddie");
		///<summary>ZaphodWLED Nightlight</summary>
		public SwitchEntity ZaphodwledNightlight => new(_haContext, "switch.zaphodwled_nightlight");
		///<summary>ZaphodWLED Reverse</summary>
		public SwitchEntity ZaphodwledReverse => new(_haContext, "switch.zaphodwled_reverse");
		///<summary>ZaphodWLED Sync Receive</summary>
		public SwitchEntity ZaphodwledSyncReceive => new(_haContext, "switch.zaphodwled_sync_receive");
		///<summary>ZaphodWLED Sync Send</summary>
		public SwitchEntity ZaphodwledSyncSend => new(_haContext, "switch.zaphodwled_sync_send");
	}

	public class TimerEntities
	{
		private readonly IHaContext _haContext;
		public TimerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public TimerEntity BathroomBoostTimer => new(_haContext, "timer.bathroom_boost_timer");
		public TimerEntity BathroomMakeupTimer => new(_haContext, "timer.bathroom_makeup_timer");
		public TimerEntity BedroomBoostTimer => new(_haContext, "timer.bedroom_boost_timer");
		public TimerEntity KitchenBoostTimer => new(_haContext, "timer.kitchen_boost_timer");
		public TimerEntity LivingroomBoostTimer => new(_haContext, "timer.livingroom_boost_timer");
		public TimerEntity NightLightTimer => new(_haContext, "timer.night_light_timer");
		public TimerEntity OfficeBoostTimer => new(_haContext, "timer.office_boost_timer");
		public TimerEntity ToiletLightsTimer => new(_haContext, "timer.toilet_lights_timer");
		public TimerEntity VestibuleBoostTimer => new(_haContext, "timer.vestibule_boost_timer");
		public TimerEntity WeebearBoostTimer => new(_haContext, "timer.weebear_boost_timer");
		///<summary>Time remaining</summary>
		public TimerEntity ZigbeePermitJoin => new(_haContext, "timer.zigbee_permit_join");
	}

	public class VacuumEntities
	{
		private readonly IHaContext _haContext;
		public VacuumEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Kaggi II</summary>
		public VacuumEntity KaggiIi => new(_haContext, "vacuum.kaggi_ii");
	}

	public class VarEntities
	{
		private readonly IHaContext _haContext;
		public VarEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Light Button Height</summary>
		public VarEntity LightButtonHeight => new(_haContext, "var.light_button_height");
		///<summary>Light Button Width</summary>
		public VarEntity LightButtonWidth => new(_haContext, "var.light_button_width");
		///<summary>marvin History 1</summary>
		public VarEntity MarvinHistory1 => new(_haContext, "var.marvin_history_1");
		///<summary>marvin History 10</summary>
		public VarEntity MarvinHistory10 => new(_haContext, "var.marvin_history_10");
		///<summary>marvin History 2</summary>
		public VarEntity MarvinHistory2 => new(_haContext, "var.marvin_history_2");
		///<summary>marvin History 3</summary>
		public VarEntity MarvinHistory3 => new(_haContext, "var.marvin_history_3");
		///<summary>marvin History 4</summary>
		public VarEntity MarvinHistory4 => new(_haContext, "var.marvin_history_4");
		///<summary>marvin History 5</summary>
		public VarEntity MarvinHistory5 => new(_haContext, "var.marvin_history_5");
		///<summary>marvin History 6</summary>
		public VarEntity MarvinHistory6 => new(_haContext, "var.marvin_history_6");
		///<summary>marvin History 7</summary>
		public VarEntity MarvinHistory7 => new(_haContext, "var.marvin_history_7");
		///<summary>marvin History 8</summary>
		public VarEntity MarvinHistory8 => new(_haContext, "var.marvin_history_8");
		///<summary>marvin History 9</summary>
		public VarEntity MarvinHistory9 => new(_haContext, "var.marvin_history_9");
		///<summary>marvin Last Played</summary>
		public VarEntity MarvinLastPlayed => new(_haContext, "var.marvin_last_played");
		///<summary>Office High Brightness</summary>
		public VarEntity OfficeHigh => new(_haContext, "var.office_high");
		///<summary>Office Low Brightness</summary>
		public VarEntity OfficeLow => new(_haContext, "var.office_low");
		///<summary>Office Medium Brightness</summary>
		public VarEntity OfficeMed => new(_haContext, "var.office_med");
		///<summary>slartibartfarst History 1</summary>
		public VarEntity SlartibartfarstHistory1 => new(_haContext, "var.slartibartfarst_history_1");
		///<summary>slartibartfarst History 10</summary>
		public VarEntity SlartibartfarstHistory10 => new(_haContext, "var.slartibartfarst_history_10");
		///<summary>slartibartfarst History 2</summary>
		public VarEntity SlartibartfarstHistory2 => new(_haContext, "var.slartibartfarst_history_2");
		///<summary>slartibartfarst History 3</summary>
		public VarEntity SlartibartfarstHistory3 => new(_haContext, "var.slartibartfarst_history_3");
		///<summary>slartibartfarst History 4</summary>
		public VarEntity SlartibartfarstHistory4 => new(_haContext, "var.slartibartfarst_history_4");
		///<summary>slartibartfarst History 5</summary>
		public VarEntity SlartibartfarstHistory5 => new(_haContext, "var.slartibartfarst_history_5");
		///<summary>slartibartfarst History 6</summary>
		public VarEntity SlartibartfarstHistory6 => new(_haContext, "var.slartibartfarst_history_6");
		///<summary>slartibartfarst History 7</summary>
		public VarEntity SlartibartfarstHistory7 => new(_haContext, "var.slartibartfarst_history_7");
		///<summary>slartibartfarst History 8</summary>
		public VarEntity SlartibartfarstHistory8 => new(_haContext, "var.slartibartfarst_history_8");
		///<summary>slartibartfarst History 9</summary>
		public VarEntity SlartibartfarstHistory9 => new(_haContext, "var.slartibartfarst_history_9");
		///<summary>slartibartfarst Last Played</summary>
		public VarEntity SlartibartfarstLastPlayed => new(_haContext, "var.slartibartfarst_last_played");
		///<summary>Zaphod History 1</summary>
		public VarEntity ZaphodHistory1 => new(_haContext, "var.zaphod_history_1");
		///<summary>Zaphod History 10</summary>
		public VarEntity ZaphodHistory10 => new(_haContext, "var.zaphod_history_10");
		///<summary>Zaphod History 2</summary>
		public VarEntity ZaphodHistory2 => new(_haContext, "var.zaphod_history_2");
		///<summary>Zaphod History 3</summary>
		public VarEntity ZaphodHistory3 => new(_haContext, "var.zaphod_history_3");
		///<summary>Zaphod History 4</summary>
		public VarEntity ZaphodHistory4 => new(_haContext, "var.zaphod_history_4");
		///<summary>Zaphod History 5</summary>
		public VarEntity ZaphodHistory5 => new(_haContext, "var.zaphod_history_5");
		///<summary>Zaphod History 6</summary>
		public VarEntity ZaphodHistory6 => new(_haContext, "var.zaphod_history_6");
		///<summary>Zaphod History 7</summary>
		public VarEntity ZaphodHistory7 => new(_haContext, "var.zaphod_history_7");
		///<summary>Zaphod History 8</summary>
		public VarEntity ZaphodHistory8 => new(_haContext, "var.zaphod_history_8");
		///<summary>Zaphod History 9</summary>
		public VarEntity ZaphodHistory9 => new(_haContext, "var.zaphod_history_9");
		///<summary>Zaphod Last Played</summary>
		public VarEntity ZaphodLastPlayed => new(_haContext, "var.zaphod_last_played");
	}

	public class VariableEntities
	{
		private readonly IHaContext _haContext;
		public VariableEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Kaggi_II</summary>
		public VariableEntity DeebotKaggiIiQueue => new(_haContext, "variable.deebot_kaggi_ii_queue");
	}

	public class WeatherEntities
	{
		private readonly IHaContext _haContext;
		public WeatherEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Met Office Corstorphine 3-Hourly</summary>
		public WeatherEntity MetOfficeCorstorphine => new(_haContext, "weather.met_office_corstorphine");
		///<summary>Met Office Corstorphine Daily</summary>
		public WeatherEntity MetOfficeCorstorphineDaily => new(_haContext, "weather.met_office_corstorphine_daily");
	}

	public class ZoneEntities
	{
		private readonly IHaContext _haContext;
		public ZoneEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Asda</summary>
		public ZoneEntity Asda => new(_haContext, "zone.asda");
		///<summary>SquiggleBear</summary>
		public ZoneEntity Home => new(_haContext, "zone.home");
		///<summary>Squiggley Work</summary>
		public ZoneEntity SquiggleyWork2 => new(_haContext, "zone.squiggley_work_2");
		///<summary>Tesco</summary>
		public ZoneEntity Tesco => new(_haContext, "zone.tesco");
		///<summary>Wee Bear Gym</summary>
		public ZoneEntity WeeBearGym2 => new(_haContext, "zone.wee_bear_gym_2");
		///<summary>Wee Bear Work</summary>
		public ZoneEntity WeeBearWork2 => new(_haContext, "zone.wee_bear_work_2");
	}

	public record AlarmControlPanelEntity : Entity<AlarmControlPanelEntity, EntityState<AlarmControlPanelAttributes>, AlarmControlPanelAttributes>
	{
		public AlarmControlPanelEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public AlarmControlPanelEntity(Entity entity) : base(entity)
		{
		}
	}

	public record AlertEntity : Entity<AlertEntity, EntityState<AlertAttributes>, AlertAttributes>
	{
		public AlertEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public AlertEntity(Entity entity) : base(entity)
		{
		}
	}

	public record AutomationEntity : Entity<AutomationEntity, EntityState<AutomationAttributes>, AutomationAttributes>
	{
		public AutomationEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public AutomationEntity(Entity entity) : base(entity)
		{
		}
	}

	public record BinarySensorEntity : Entity<BinarySensorEntity, EntityState<BinarySensorAttributes>, BinarySensorAttributes>
	{
		public BinarySensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public BinarySensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ButtonEntity : Entity<ButtonEntity, EntityState<ButtonAttributes>, ButtonAttributes>
	{
		public ButtonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ButtonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CalendarEntity : Entity<CalendarEntity, EntityState<CalendarAttributes>, CalendarAttributes>
	{
		public CalendarEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CalendarEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CameraEntity : Entity<CameraEntity, EntityState<CameraAttributes>, CameraAttributes>
	{
		public CameraEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CameraEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ClimateEntity : Entity<ClimateEntity, EntityState<ClimateAttributes>, ClimateAttributes>
	{
		public ClimateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ClimateEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CoverEntity : Entity<CoverEntity, EntityState<CoverAttributes>, CoverAttributes>
	{
		public CoverEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CoverEntity(Entity entity) : base(entity)
		{
		}
	}

	public record DeviceTrackerEntity : Entity<DeviceTrackerEntity, EntityState<DeviceTrackerAttributes>, DeviceTrackerAttributes>
	{
		public DeviceTrackerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public DeviceTrackerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record GroupEntity : Entity<GroupEntity, EntityState<GroupAttributes>, GroupAttributes>
	{
		public GroupEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public GroupEntity(Entity entity) : base(entity)
		{
		}
	}

	public record HumidifierEntity : Entity<HumidifierEntity, EntityState<HumidifierAttributes>, HumidifierAttributes>
	{
		public HumidifierEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public HumidifierEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputBooleanEntity : Entity<InputBooleanEntity, EntityState<InputBooleanAttributes>, InputBooleanAttributes>
	{
		public InputBooleanEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputBooleanEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputDatetimeEntity : Entity<InputDatetimeEntity, EntityState<InputDatetimeAttributes>, InputDatetimeAttributes>
	{
		public InputDatetimeEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputDatetimeEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputNumberEntity : NumericEntity<InputNumberEntity, NumericEntityState<InputNumberAttributes>, InputNumberAttributes>
	{
		public InputNumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputNumberEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputSelectEntity : Entity<InputSelectEntity, EntityState<InputSelectAttributes>, InputSelectAttributes>
	{
		public InputSelectEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputSelectEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputTextEntity : Entity<InputTextEntity, EntityState<InputTextAttributes>, InputTextAttributes>
	{
		public InputTextEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputTextEntity(Entity entity) : base(entity)
		{
		}
	}

	public record LightEntity : Entity<LightEntity, EntityState<LightAttributes>, LightAttributes>
	{
		public LightEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LightEntity(Entity entity) : base(entity)
		{
		}
	}

	public record MediaPlayerEntity : Entity<MediaPlayerEntity, EntityState<MediaPlayerAttributes>, MediaPlayerAttributes>
	{
		public MediaPlayerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public MediaPlayerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record NumberEntity : NumericEntity<NumberEntity, NumericEntityState<NumberAttributes>, NumberAttributes>
	{
		public NumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumberEntity(Entity entity) : base(entity)
		{
		}
	}

	public record PersistentNotificationEntity : Entity<PersistentNotificationEntity, EntityState<PersistentNotificationAttributes>, PersistentNotificationAttributes>
	{
		public PersistentNotificationEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public PersistentNotificationEntity(Entity entity) : base(entity)
		{
		}
	}

	public record PersonEntity : Entity<PersonEntity, EntityState<PersonAttributes>, PersonAttributes>
	{
		public PersonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public PersonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record RemoteEntity : Entity<RemoteEntity, EntityState<RemoteAttributes>, RemoteAttributes>
	{
		public RemoteEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public RemoteEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SceneEntity : Entity<SceneEntity, EntityState<SceneAttributes>, SceneAttributes>
	{
		public SceneEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SceneEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ScriptEntity : Entity<ScriptEntity, EntityState<ScriptAttributes>, ScriptAttributes>
	{
		public ScriptEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ScriptEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SelectEntity : Entity<SelectEntity, EntityState<SelectAttributes>, SelectAttributes>
	{
		public SelectEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SelectEntity(Entity entity) : base(entity)
		{
		}
	}

	public record NumericSensorEntity : NumericEntity<NumericSensorEntity, NumericEntityState<NumericSensorAttributes>, NumericSensorAttributes>
	{
		public NumericSensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumericSensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SensorEntity : Entity<SensorEntity, EntityState<SensorAttributes>, SensorAttributes>
	{
		public SensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SunEntity : Entity<SunEntity, EntityState<SunAttributes>, SunAttributes>
	{
		public SunEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SunEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SwitchEntity : Entity<SwitchEntity, EntityState<SwitchAttributes>, SwitchAttributes>
	{
		public SwitchEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SwitchEntity(Entity entity) : base(entity)
		{
		}
	}

	public record TimerEntity : Entity<TimerEntity, EntityState<TimerAttributes>, TimerAttributes>
	{
		public TimerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public TimerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record VacuumEntity : Entity<VacuumEntity, EntityState<VacuumAttributes>, VacuumAttributes>
	{
		public VacuumEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public VacuumEntity(Entity entity) : base(entity)
		{
		}
	}

	public record VarEntity : Entity<VarEntity, EntityState<VarAttributes>, VarAttributes>
	{
		public VarEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public VarEntity(Entity entity) : base(entity)
		{
		}
	}

	public record VariableEntity : Entity<VariableEntity, EntityState<VariableAttributes>, VariableAttributes>
	{
		public VariableEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public VariableEntity(Entity entity) : base(entity)
		{
		}
	}

	public record WeatherEntity : Entity<WeatherEntity, EntityState<WeatherAttributes>, WeatherAttributes>
	{
		public WeatherEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public WeatherEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ZoneEntity : Entity<ZoneEntity, EntityState<ZoneAttributes>, ZoneAttributes>
	{
		public ZoneEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ZoneEntity(Entity entity) : base(entity)
		{
		}
	}

	public record AlarmControlPanelAttributes
	{
		[JsonPropertyName("arm_mode")]
		public object? ArmMode { get; init; }

		[JsonPropertyName("bypassed_sensors")]
		public object? BypassedSensors { get; init; }

		[JsonPropertyName("changed_by")]
		public object? ChangedBy { get; init; }

		[JsonPropertyName("code_arm_required")]
		public bool? CodeArmRequired { get; init; }

		[JsonPropertyName("code_format")]
		public object? CodeFormat { get; init; }

		[JsonPropertyName("delay")]
		public object? Delay { get; init; }

		[JsonPropertyName("expiration")]
		public object? Expiration { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("open_sensors")]
		public object? OpenSensors { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record AlertAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }
	}

	public record AutomationAttributes
	{
		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("last_triggered")]
		public string? LastTriggered { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record BinarySensorAttributes
	{
		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("contact")]
		public bool? Contact { get; init; }

		[JsonPropertyName("days_offset")]
		public double? DaysOffset { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("elapsed")]
		public double? Elapsed { get; init; }

		[JsonPropertyName("excludes")]
		public object? Excludes { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("ignoring_battery_optimizations")]
		public bool? IgnoringBatteryOptimizations { get; init; }

		[JsonPropertyName("illuminance")]
		public double? Illuminance { get; init; }

		[JsonPropertyName("illuminance_lux")]
		public double? IlluminanceLux { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("led")]
		public bool? Led { get; init; }

		[JsonPropertyName("led_indication")]
		public bool? LedIndication { get; init; }

		[JsonPropertyName("led_state")]
		public bool? LedState { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("motion_sensitivity")]
		public string? MotionSensitivity { get; init; }

		[JsonPropertyName("occupancy")]
		public bool? Occupancy { get; init; }

		[JsonPropertyName("occupancy_timeout")]
		public double? OccupancyTimeout { get; init; }

		[JsonPropertyName("pending_notices")]
		public object? PendingNotices { get; init; }

		[JsonPropertyName("pfsense_base_installed_version")]
		public string? PfsenseBaseInstalledVersion { get; init; }

		[JsonPropertyName("pfsense_base_pkg_version_compare")]
		public string? PfsenseBasePkgVersionCompare { get; init; }

		[JsonPropertyName("pfsense_base_version")]
		public string? PfsenseBaseVersion { get; init; }

		[JsonPropertyName("position")]
		public double? Position { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("running")]
		public bool? Running { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }

		[JsonPropertyName("workdays")]
		public object? Workdays { get; init; }
	}

	public record ButtonAttributes
	{
		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }
	}

	public record CalendarAttributes
	{
		[JsonPropertyName("all_day")]
		public bool? AllDay { get; init; }

		[JsonPropertyName("description")]
		public string? Description { get; init; }

		[JsonPropertyName("end_time")]
		public string? EndTime { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("location")]
		public string? Location { get; init; }

		[JsonPropertyName("message")]
		public string? Message { get; init; }

		[JsonPropertyName("start_time")]
		public string? StartTime { get; init; }
	}

	public record CameraAttributes
	{
		[JsonPropertyName("access_token")]
		public string? AccessToken { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("frontend_stream_type")]
		public string? FrontendStreamType { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record ClimateAttributes
	{
		[JsonPropertyName("current_temperature")]
		public double? CurrentTemperature { get; init; }

		[JsonPropertyName("floor_temperature")]
		public double? FloorTemperature { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("hvac_action")]
		public string? HvacAction { get; init; }

		[JsonPropertyName("hvac_modes")]
		public object? HvacModes { get; init; }

		[JsonPropertyName("low_battery")]
		public bool? LowBattery { get; init; }

		[JsonPropertyName("max_temp")]
		public double? MaxTemp { get; init; }

		[JsonPropertyName("min_temp")]
		public double? MinTemp { get; init; }

		[JsonPropertyName("offline")]
		public bool? Offline { get; init; }

		[JsonPropertyName("preheat_active")]
		public bool? PreheatActive { get; init; }

		[JsonPropertyName("standby")]
		public bool? Standby { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("target_temp_step")]
		public double? TargetTempStep { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }
	}

	public record CoverAttributes
	{
		[JsonPropertyName("current_position")]
		public double? CurrentPosition { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("position")]
		public double? Position { get; init; }

		[JsonPropertyName("running")]
		public bool? Running { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public object? UpdateAvailable { get; init; }
	}

	public record DeviceTrackerAttributes
	{
		[JsonPropertyName("altitude")]
		public double? Altitude { get; init; }

		[JsonPropertyName("battery_level")]
		public double? BatteryLevel { get; init; }

		[JsonPropertyName("course")]
		public double? Course { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("picture")]
		public string? Picture { get; init; }

		[JsonPropertyName("source_type")]
		public string? SourceType { get; init; }

		[JsonPropertyName("speed")]
		public double? Speed { get; init; }

		[JsonPropertyName("vertical_accuracy")]
		public double? VerticalAccuracy { get; init; }
	}

	public record GroupAttributes
	{
		[JsonPropertyName("assumed_state")]
		public bool? AssumedState { get; init; }

		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("order")]
		public double? Order { get; init; }
	}

	public record HumidifierAttributes
	{
		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("max_humidity")]
		public double? MaxHumidity { get; init; }

		[JsonPropertyName("min_humidity")]
		public double? MinHumidity { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record InputBooleanAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record InputDatetimeAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("has_date")]
		public bool? HasDate { get; init; }

		[JsonPropertyName("has_time")]
		public bool? HasTime { get; init; }

		[JsonPropertyName("hour")]
		public double? Hour { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("minute")]
		public double? Minute { get; init; }

		[JsonPropertyName("second")]
		public double? Second { get; init; }

		[JsonPropertyName("timestamp")]
		public double? Timestamp { get; init; }
	}

	public record InputNumberAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("hidden")]
		public bool? Hidden { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("initial")]
		public double? Initial { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("step")]
		public double? Step { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record InputSelectAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public record InputTextAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("hidden")]
		public bool? Hidden { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("pattern")]
		public object? Pattern { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record LightAttributes
	{
		[JsonPropertyName("Area")]
		public string? Area { get; init; }

		[JsonPropertyName("brightness")]
		public double? Brightness { get; init; }

		[JsonPropertyName("color")]
		public object? Color { get; init; }

		[JsonPropertyName("color_mode")]
		public string? ColorMode { get; init; }

		[JsonPropertyName("effect")]
		public string? Effect { get; init; }

		[JsonPropertyName("effect_list")]
		public object? EffectList { get; init; }

		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		[JsonPropertyName("flowing")]
		public bool? Flowing { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("max_mireds")]
		public double? MaxMireds { get; init; }

		[JsonPropertyName("min_mireds")]
		public double? MinMireds { get; init; }

		[JsonPropertyName("music_mode")]
		public bool? MusicMode { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		[JsonPropertyName("rgbw_color")]
		public object? RgbwColor { get; init; }

		[JsonPropertyName("rgbww_color")]
		public object? RgbwwColor { get; init; }

		[JsonPropertyName("supported_color_modes")]
		public object? SupportedColorModes { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }
	}

	public record MediaPlayerAttributes
	{
		[JsonPropertyName("adb_response")]
		public object? AdbResponse { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("hdmi_input")]
		public object? HdmiInput { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("is_volume_muted")]
		public bool? IsVolumeMuted { get; init; }

		[JsonPropertyName("media_album_name")]
		public string? MediaAlbumName { get; init; }

		[JsonPropertyName("media_artist")]
		public string? MediaArtist { get; init; }

		[JsonPropertyName("media_content_id")]
		public string? MediaContentId { get; init; }

		[JsonPropertyName("media_content_type")]
		public string? MediaContentType { get; init; }

		[JsonPropertyName("media_duration")]
		public double? MediaDuration { get; init; }

		[JsonPropertyName("media_position")]
		public double? MediaPosition { get; init; }

		[JsonPropertyName("media_position_updated_at")]
		public string? MediaPositionUpdatedAt { get; init; }

		[JsonPropertyName("media_title")]
		public string? MediaTitle { get; init; }

		[JsonPropertyName("media_track")]
		public double? MediaTrack { get; init; }

		[JsonPropertyName("repeat")]
		public string? Repeat { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }

		[JsonPropertyName("sound_mode_list")]
		public object? SoundModeList { get; init; }

		[JsonPropertyName("source")]
		public string? Source { get; init; }

		[JsonPropertyName("source_list")]
		public object? SourceList { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }
	}

	public record NumberAttributes
	{
		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("elapsed")]
		public double? Elapsed { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("illuminance")]
		public double? Illuminance { get; init; }

		[JsonPropertyName("illuminance_lux")]
		public double? IlluminanceLux { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("led_indication")]
		public bool? LedIndication { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("motion_sensitivity")]
		public string? MotionSensitivity { get; init; }

		[JsonPropertyName("occupancy")]
		public bool? Occupancy { get; init; }

		[JsonPropertyName("occupancy_timeout")]
		public double? OccupancyTimeout { get; init; }

		[JsonPropertyName("step")]
		public double? Step { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }
	}

	public record PersistentNotificationAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("message")]
		public string? Message { get; init; }

		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public record PersonAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("source")]
		public string? Source { get; init; }

		[JsonPropertyName("user_id")]
		public string? UserId { get; init; }
	}

	public record RemoteAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record SceneAttributes
	{
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }
	}

	public record ScriptAttributes
	{
		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("hidden")]
		public bool? Hidden { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("last_triggered")]
		public string? LastTriggered { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public record SelectAttributes
	{
		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("elapsed")]
		public double? Elapsed { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("illuminance")]
		public double? Illuminance { get; init; }

		[JsonPropertyName("illuminance_lux")]
		public double? IlluminanceLux { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("led_indication")]
		public bool? LedIndication { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("motion_sensitivity")]
		public string? MotionSensitivity { get; init; }

		[JsonPropertyName("occupancy")]
		public bool? Occupancy { get; init; }

		[JsonPropertyName("occupancy_timeout")]
		public double? OccupancyTimeout { get; init; }

		[JsonPropertyName("options")]
		public object? Options { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }
	}

	public record NumericSensorAttributes
	{
		[JsonPropertyName("action")]
		public string? Action { get; init; }

		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("Available")]
		public string? Available { get; init; }

		[JsonPropertyName("Available (Important)")]
		public string? AvailableImportant { get; init; }

		[JsonPropertyName("Available (Opportunistic)")]
		public string? AvailableOpportunistic { get; init; }

		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("Battery Level")]
		public double? BatteryLevel { get; init; }

		[JsonPropertyName("Battery State")]
		public string? BatteryState { get; init; }

		[JsonPropertyName("click")]
		public object? Click { get; init; }

		[JsonPropertyName("co")]
		public double? Co { get; init; }

		[JsonPropertyName("connected_not_paired_devices")]
		public string? ConnectedNotPairedDevices { get; init; }

		[JsonPropertyName("connected_paired_devices")]
		public string? ConnectedPairedDevices { get; init; }

		[JsonPropertyName("contact")]
		public bool? Contact { get; init; }

		[JsonPropertyName("device")]
		public string? Device { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("Device Name")]
		public string? DeviceName { get; init; }

		[JsonPropertyName("Device Type")]
		public string? DeviceType { get; init; }

		[JsonPropertyName("Device Version")]
		public string? DeviceVersion { get; init; }

		[JsonPropertyName("dew")]
		public double? Dew { get; init; }

		[JsonPropertyName("dominentpol")]
		public string? Dominentpol { get; init; }

		[JsonPropertyName("elapsed")]
		public double? Elapsed { get; init; }

		[JsonPropertyName("enable")]
		public bool? Enable { get; init; }

		[JsonPropertyName("end")]
		public double? End { get; init; }

		[JsonPropertyName("free_external_storage")]
		public string? FreeExternalStorage { get; init; }

		[JsonPropertyName("Free internal storage")]
		public string? Freeinternalstorage { get; init; }

		[JsonPropertyName("free_memory")]
		public double? FreeMemory { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("humidity")]
		public double? Humidity { get; init; }

		[JsonPropertyName("hwif")]
		public string? Hwif { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("if")]
		public string? If { get; init; }

		[JsonPropertyName("illuminance")]
		public double? Illuminance { get; init; }

		[JsonPropertyName("illuminance_lux")]
		public double? IlluminanceLux { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("last_update")]
		public string? LastUpdate { get; init; }

		[JsonPropertyName("led")]
		public bool? Led { get; init; }

		[JsonPropertyName("led_indication")]
		public bool? LedIndication { get; init; }

		[JsonPropertyName("led_state")]
		public bool? LedState { get; init; }

		[JsonPropertyName("light")]
		public double? Light { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("macaddr")]
		public string? Macaddr { get; init; }

		[JsonPropertyName("monitorip")]
		public string? Monitorip { get; init; }

		[JsonPropertyName("motion")]
		public double? Motion { get; init; }

		[JsonPropertyName("motion_sensitivity")]
		public string? MotionSensitivity { get; init; }

		[JsonPropertyName("mountpoint")]
		public string? Mountpoint { get; init; }

		[JsonPropertyName("mtu")]
		public double? Mtu { get; init; }

		[JsonPropertyName("nitrogen_dioxide")]
		public double? NitrogenDioxide { get; init; }

		[JsonPropertyName("occupancy")]
		public bool? Occupancy { get; init; }

		[JsonPropertyName("occupancy_timeout")]
		public double? OccupancyTimeout { get; init; }

		[JsonPropertyName("ozone")]
		public double? Ozone { get; init; }

		[JsonPropertyName("paired_devices")]
		public string? PairedDevices { get; init; }

		[JsonPropertyName("pm_10")]
		public double? Pm10 { get; init; }

		[JsonPropertyName("pm_2_5")]
		public double? Pm25 { get; init; }

		[JsonPropertyName("pressure")]
		public double? Pressure { get; init; }

		[JsonPropertyName("repositories")]
		public object? Repositories { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("sensor_id")]
		public string? SensorId { get; init; }

		[JsonPropertyName("site_id")]
		public string? SiteId { get; init; }

		[JsonPropertyName("site_name")]
		public string? SiteName { get; init; }

		[JsonPropertyName("srcip")]
		public string? Srcip { get; init; }

		[JsonPropertyName("start")]
		public double? Start { get; init; }

		[JsonPropertyName("state_class")]
		public string? StateClass { get; init; }

		[JsonPropertyName("status")]
		public string? Status { get; init; }

		[JsonPropertyName("substatus")]
		public string? Substatus { get; init; }

		[JsonPropertyName("sulfur_dioxide")]
		public double? SulfurDioxide { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("time")]
		public string? Time { get; init; }

		[JsonPropertyName("timestamp")]
		public double? Timestamp { get; init; }

		[JsonPropertyName("Total")]
		public string? Total { get; init; }

		[JsonPropertyName("total_external_storage")]
		public string? TotalExternalStorage { get; init; }

		[JsonPropertyName("Total internal storage")]
		public string? Totalinternalstorage { get; init; }

		[JsonPropertyName("total_memory")]
		public double? TotalMemory { get; init; }

		[JsonPropertyName("total_size")]
		public string? TotalSize { get; init; }

		[JsonPropertyName("type")]
		public string? Type { get; init; }

		[JsonPropertyName("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }

		[JsonPropertyName("value")]
		public string? Value { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }

		[JsonPropertyName("w")]
		public double? W { get; init; }

		[JsonPropertyName("wg")]
		public double? Wg { get; init; }
	}

	public record SensorAttributes
	{
		[JsonPropertyName("action")]
		public string? Action { get; init; }

		[JsonPropertyName("Administrative Area")]
		public string? AdministrativeArea_0 { get; init; }

		[JsonPropertyName("administrative_area")]
		public string? AdministrativeArea_1 { get; init; }

		[JsonPropertyName("Allows VoIP")]
		public bool? AllowsVoIP { get; init; }

		[JsonPropertyName("area")]
		public double? Area { get; init; }

		[JsonPropertyName("Areas Of Interest")]
		public string? AreasOfInterest { get; init; }

		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("Battery Level")]
		public double? BatteryLevel { get; init; }

		[JsonPropertyName("Battery State")]
		public string? BatteryState { get; init; }

		[JsonPropertyName("Carrier ID")]
		public string? CarrierID { get; init; }

		[JsonPropertyName("Carrier Name")]
		public string? CarrierName { get; init; }

		[JsonPropertyName("changes")]
		public object? Changes { get; init; }

		[JsonPropertyName("city")]
		public string? City { get; init; }

		[JsonPropertyName("click")]
		public object? Click { get; init; }

		[JsonPropertyName("Confidence")]
		public string? Confidence { get; init; }

		[JsonPropertyName("country")]
		public string? Country_0 { get; init; }

		[JsonPropertyName("Country")]
		public string? Country_1 { get; init; }

		[JsonPropertyName("count_sensors")]
		public double? CountSensors { get; init; }

		[JsonPropertyName("county")]
		public string? County { get; init; }

		[JsonPropertyName("covered")]
		public object? Covered { get; init; }

		[JsonPropertyName("current_latitude")]
		public string? CurrentLatitude { get; init; }

		[JsonPropertyName("current_location")]
		public string? CurrentLocation { get; init; }

		[JsonPropertyName("current_longitude")]
		public string? CurrentLongitude { get; init; }

		[JsonPropertyName("Current Radio Technology")]
		public string? CurrentRadioTechnology { get; init; }

		[JsonPropertyName("days")]
		public double? Days { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("Device Name")]
		public string? DeviceName { get; init; }

		[JsonPropertyName("devicetracker_entityid")]
		public string? DevicetrackerEntityid { get; init; }

		[JsonPropertyName("devicetracker_zone")]
		public string? DevicetrackerZone { get; init; }

		[JsonPropertyName("Device Type")]
		public string? DeviceType { get; init; }

		[JsonPropertyName("Device Version")]
		public string? DeviceVersion { get; init; }

		[JsonPropertyName("direction_of_travel")]
		public string? DirectionOfTravel { get; init; }

		[JsonPropertyName("distance_from_home_km")]
		public string? DistanceFromHomeKm { get; init; }

		[JsonPropertyName("distance_from_home_m")]
		public double? DistanceFromHomeM { get; init; }

		[JsonPropertyName("duration")]
		public double? Duration { get; init; }

		[JsonPropertyName("elapsed")]
		public double? Elapsed { get; init; }

		[JsonPropertyName("enable")]
		public bool? Enable { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("formatted_address")]
		public string? FormattedAddress { get; init; }

		[JsonPropertyName("friday")]
		public object? Friday { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("8d_ago")]
		public object? HA8dAgo { get; init; }

		[JsonPropertyName("home_latitude")]
		public string? HomeLatitude { get; init; }

		[JsonPropertyName("home_longitude")]
		public string? HomeLongitude { get; init; }

		[JsonPropertyName("home_zone")]
		public string? HomeZone { get; init; }

		[JsonPropertyName("hwif")]
		public string? Hwif { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("if")]
		public string? If { get; init; }

		[JsonPropertyName("image_url")]
		public string? ImageUrl { get; init; }

		[JsonPropertyName("in_daylight_time")]
		public bool? InDaylightTime { get; init; }

		[JsonPropertyName("Inland Water")]
		public string? InlandWater { get; init; }

		[JsonPropertyName("in_vehicle")]
		public double? InVehicle { get; init; }

		[JsonPropertyName("is_hidden")]
		public bool? IsHidden { get; init; }

		[JsonPropertyName("iso_country_code")]
		public string? IsoCountryCode { get; init; }

		[JsonPropertyName("ISO Country Code")]
		public string? ISOCountryCode { get; init; }

		[JsonPropertyName("last_changed")]
		public string? LastChanged { get; init; }

		[JsonPropertyName("last_collection")]
		public object? LastCollection { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("last_snapshot")]
		public string? LastSnapshot { get; init; }

		[JsonPropertyName("last_update")]
		public string? LastUpdate { get; init; }

		[JsonPropertyName("last_updated")]
		public string? LastUpdated { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude_0 { get; init; }

		[JsonPropertyName("Latitude")]
		public double? Latitude_1 { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("locality")]
		public string? Locality_0 { get; init; }

		[JsonPropertyName("Locality")]
		public string? Locality_1 { get; init; }

		[JsonPropertyName("Local Time")]
		public string? LocalTime { get; init; }

		[JsonPropertyName("Location")]
		public object? Location { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude_0 { get; init; }

		[JsonPropertyName("Longitude")]
		public double? Longitude_1 { get; init; }

		[JsonPropertyName("Low Power Mode")]
		public bool? LowPowerMode { get; init; }

		[JsonPropertyName("macaddr")]
		public string? Macaddr { get; init; }

		[JsonPropertyName("map_link")]
		public string? MapLink { get; init; }

		[JsonPropertyName("Mobile Country Code")]
		public string? MobileCountryCode { get; init; }

		[JsonPropertyName("Mobile Network Code")]
		public string? MobileNetworkCode { get; init; }

		[JsonPropertyName("monday")]
		public object? Monday { get; init; }

		[JsonPropertyName("monitorip")]
		public string? Monitorip { get; init; }

		[JsonPropertyName("mtu")]
		public double? Mtu { get; init; }

		[JsonPropertyName("Name")]
		public string? Name { get; init; }

		[JsonPropertyName("neighbourhood")]
		public string? Neighbourhood { get; init; }

		[JsonPropertyName("next_date")]
		public string? NextDate { get; init; }

		[JsonPropertyName("Ocean")]
		public string? Ocean { get; init; }

		[JsonPropertyName("on_foot")]
		public double? OnFoot { get; init; }

		[JsonPropertyName("options")]
		public string? Options { get; init; }

		[JsonPropertyName("Package")]
		public string? Package { get; init; }

		[JsonPropertyName("place_category")]
		public string? PlaceCategory { get; init; }

		[JsonPropertyName("place_name")]
		public string? PlaceName { get; init; }

		[JsonPropertyName("place_type")]
		public string? PlaceType { get; init; }

		[JsonPropertyName("Postal Code")]
		public string? PostalCode_0 { get; init; }

		[JsonPropertyName("postal_code")]
		public string? PostalCode_1 { get; init; }

		[JsonPropertyName("postal_town")]
		public string? PostalTown { get; init; }

		[JsonPropertyName("previous_latitude")]
		public string? PreviousLatitude { get; init; }

		[JsonPropertyName("previous_location")]
		public string? PreviousLocation { get; init; }

		[JsonPropertyName("previous_longitude")]
		public string? PreviousLongitude { get; init; }

		[JsonPropertyName("response")]
		public object? Response { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("saturday")]
		public object? Saturday { get; init; }

		[JsonPropertyName("sensor_id")]
		public string? SensorId { get; init; }

		[JsonPropertyName("site_id")]
		public string? SiteId { get; init; }

		[JsonPropertyName("site_name")]
		public string? SiteName { get; init; }

		[JsonPropertyName("size_in_google_drive")]
		public string? SizeInGoogleDrive { get; init; }

		[JsonPropertyName("size_in_home_assistant")]
		public string? SizeInHomeAssistant { get; init; }

		[JsonPropertyName("snapshots")]
		public object? Snapshots { get; init; }

		[JsonPropertyName("snapshots_in_google_drive")]
		public double? SnapshotsInGoogleDrive { get; init; }

		[JsonPropertyName("snapshots_in_hassio")]
		public double? SnapshotsInHassio { get; init; }

		[JsonPropertyName("snapshots_in_home_assistant")]
		public double? SnapshotsInHomeAssistant { get; init; }

		[JsonPropertyName("srcip")]
		public string? Srcip { get; init; }

		[JsonPropertyName("state_class")]
		public string? StateClass { get; init; }

		[JsonPropertyName("state_province")]
		public string? StateProvince { get; init; }

		[JsonPropertyName("still")]
		public double? Still { get; init; }

		[JsonPropertyName("street")]
		public string? Street { get; init; }

		[JsonPropertyName("street_number")]
		public string? StreetNumber { get; init; }

		[JsonPropertyName("Sub Administrative Area")]
		public string? SubAdministrativeArea_0 { get; init; }

		[JsonPropertyName("sub_administrative_area")]
		public string? SubAdministrativeArea_1 { get; init; }

		[JsonPropertyName("Sub Locality")]
		public string? SubLocality_0 { get; init; }

		[JsonPropertyName("sub_locality")]
		public string? SubLocality_1 { get; init; }

		[JsonPropertyName("substatus")]
		public string? Substatus { get; init; }

		[JsonPropertyName("Sub Thoroughfare")]
		public string? SubThoroughfare_0 { get; init; }

		[JsonPropertyName("sub_thoroughfare")]
		public string? SubThoroughfare_1 { get; init; }

		[JsonPropertyName("sunday")]
		public object? Sunday { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("thoroughfare")]
		public string? Thoroughfare_0 { get; init; }

		[JsonPropertyName("Thoroughfare")]
		public string? Thoroughfare_1 { get; init; }

		[JsonPropertyName("thursday")]
		public object? Thursday { get; init; }

		[JsonPropertyName("Time in Milliseconds")]
		public double? TimeinMilliseconds { get; init; }

		[JsonPropertyName("timestamp")]
		public double? Timestamp { get; init; }

		[JsonPropertyName("Time Zone")]
		public string? TimeZone { get; init; }

		[JsonPropertyName("time_zone_id")]
		public string? TimeZoneId { get; init; }

		[JsonPropertyName("time_zone_short")]
		public string? TimeZoneShort { get; init; }

		[JsonPropertyName("total_media_session_count")]
		public double? TotalMediaSessionCount { get; init; }

		[JsonPropertyName("tuesday")]
		public object? Tuesday { get; init; }

		[JsonPropertyName("type")]
		public string? Type { get; init; }

		[JsonPropertyName("Types")]
		public object? Types { get; init; }

		[JsonPropertyName("unknown")]
		public double? Unknown { get; init; }

		[JsonPropertyName("uses_daylight_time")]
		public bool? UsesDaylightTime { get; init; }

		[JsonPropertyName("utc_offset")]
		public double? UtcOffset { get; init; }

		[JsonPropertyName("versions")]
		public object? Versions { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }

		[JsonPropertyName("walking")]
		public double? Walking { get; init; }

		[JsonPropertyName("wednesday")]
		public object? Wednesday { get; init; }

		[JsonPropertyName("yesterday")]
		public object? Yesterday { get; init; }

		[JsonPropertyName("Zones")]
		public object? Zones { get; init; }
	}

	public record SunAttributes
	{
		[JsonPropertyName("azimuth")]
		public double? Azimuth { get; init; }

		[JsonPropertyName("elevation")]
		public double? Elevation { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("next_dawn")]
		public string? NextDawn { get; init; }

		[JsonPropertyName("next_dusk")]
		public string? NextDusk { get; init; }

		[JsonPropertyName("next_midnight")]
		public string? NextMidnight { get; init; }

		[JsonPropertyName("next_noon")]
		public string? NextNoon { get; init; }

		[JsonPropertyName("next_rising")]
		public string? NextRising { get; init; }

		[JsonPropertyName("next_setting")]
		public string? NextSetting { get; init; }

		[JsonPropertyName("rising")]
		public bool? Rising { get; init; }
	}

	public record SwitchAttributes
	{
		[JsonPropertyName("assumed_state")]
		public bool? AssumedState { get; init; }

		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("duration")]
		public double? Duration { get; init; }

		[JsonPropertyName("elapsed")]
		public double? Elapsed { get; init; }

		[JsonPropertyName("fade")]
		public bool? Fade { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("illuminance")]
		public double? Illuminance { get; init; }

		[JsonPropertyName("illuminance_lux")]
		public double? IlluminanceLux { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("led_indication")]
		public bool? LedIndication { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("motion_sensitivity")]
		public string? MotionSensitivity { get; init; }

		[JsonPropertyName("occupancy")]
		public bool? Occupancy { get; init; }

		[JsonPropertyName("occupancy_timeout")]
		public double? OccupancyTimeout { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("target_brightness")]
		public double? TargetBrightness { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("udp_port")]
		public double? UdpPort { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }
	}

	public record TimerAttributes
	{
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }

		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }
	}

	public record VacuumAttributes
	{
		[JsonPropertyName("battery_icon")]
		public string? BatteryIcon { get; init; }

		[JsonPropertyName("battery_level")]
		public object? BatteryLevel { get; init; }

		[JsonPropertyName("fan_speed")]
		public object? FanSpeed { get; init; }

		[JsonPropertyName("fan_speed_list")]
		public object? FanSpeedList { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record VarAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }
	}

	public record VariableAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }
	}

	public record WeatherAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("forecast")]
		public object? Forecast { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("humidity")]
		public double? Humidity { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("visibility")]
		public string? Visibility { get; init; }

		[JsonPropertyName("wind_bearing")]
		public string? WindBearing { get; init; }

		[JsonPropertyName("wind_speed")]
		public double? WindSpeed { get; init; }
	}

	public record ZoneAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("passive")]
		public bool? Passive { get; init; }

		[JsonPropertyName("radius")]
		public double? Radius { get; init; }
	}

	public interface IServices
	{
		AlarmControlPanelServices AlarmControlPanel { get; }

		AlarmoServices Alarmo { get; }

		AlertServices Alert { get; }

		AndroidtvServices Androidtv { get; }

		AutomationServices Automation { get; }

		ButtonServices Button { get; }

		CameraServices Camera { get; }

		CastServices Cast { get; }

		ClimateServices Climate { get; }

		CloudServices Cloud { get; }

		ConversationServices Conversation { get; }

		CounterServices Counter { get; }

		CoverServices Cover { get; }

		DeebotServices Deebot { get; }

		DeviceTrackerServices DeviceTracker { get; }

		FanServices Fan { get; }

		FfmpegServices Ffmpeg { get; }

		FrontendServices Frontend { get; }

		GarbageCollectionServices GarbageCollection { get; }

		GenericServices Generic { get; }

		GroupServices Group { get; }

		HassioServices Hassio { get; }

		HistoryStatsServices HistoryStats { get; }

		HomeassistantServices Homeassistant { get; }

		HumidifierServices Humidifier { get; }

		InputBooleanServices InputBoolean { get; }

		InputButtonServices InputButton { get; }

		InputDatetimeServices InputDatetime { get; }

		InputNumberServices InputNumber { get; }

		InputSelectServices InputSelect { get; }

		InputTextServices InputText { get; }

		KodiServices Kodi { get; }

		LightServices Light { get; }

		LogbookServices Logbook { get; }

		LoggerServices Logger { get; }

		MediaPlayerServices MediaPlayer { get; }

		MinMaxServices MinMax { get; }

		MqttServices Mqtt { get; }

		NotifyServices Notify { get; }

		NumberServices Number { get; }

		OnvifServices Onvif { get; }

		OpenhomeServices Openhome { get; }

		PersistentNotificationServices PersistentNotification { get; }

		PersonServices Person { get; }

		PfsenseServices Pfsense { get; }

		PlexServices Plex { get; }

		PyscriptServices Pyscript { get; }

		RecorderServices Recorder { get; }

		RemoteServices Remote { get; }

		RestServices Rest { get; }

		SceneServices Scene { get; }

		ScriptServices Script { get; }

		SelectServices Select { get; }

		SirenServices Siren { get; }

		SwitchServices Switch { get; }

		SystemLogServices SystemLog { get; }

		TemplateServices Template { get; }

		TimerServices Timer { get; }

		TtsServices Tts { get; }

		UnifiServices Unifi { get; }

		VacuumServices Vacuum { get; }

		VarServices Var { get; }

		VariableServices Variable { get; }

		WakeOnLanServices WakeOnLan { get; }

		YamahaServices Yamaha { get; }

		YeelightServices Yeelight { get; }

		ZoneServices Zone { get; }

		ZwaveJsServices ZwaveJs { get; }
	}

	public class Services : IServices
	{
		private readonly IHaContext _haContext;
		public Services(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AlarmControlPanelServices AlarmControlPanel => new(_haContext);
		public AlarmoServices Alarmo => new(_haContext);
		public AlertServices Alert => new(_haContext);
		public AndroidtvServices Androidtv => new(_haContext);
		public AutomationServices Automation => new(_haContext);
		public ButtonServices Button => new(_haContext);
		public CameraServices Camera => new(_haContext);
		public CastServices Cast => new(_haContext);
		public ClimateServices Climate => new(_haContext);
		public CloudServices Cloud => new(_haContext);
		public ConversationServices Conversation => new(_haContext);
		public CounterServices Counter => new(_haContext);
		public CoverServices Cover => new(_haContext);
		public DeebotServices Deebot => new(_haContext);
		public DeviceTrackerServices DeviceTracker => new(_haContext);
		public FanServices Fan => new(_haContext);
		public FfmpegServices Ffmpeg => new(_haContext);
		public FrontendServices Frontend => new(_haContext);
		public GarbageCollectionServices GarbageCollection => new(_haContext);
		public GenericServices Generic => new(_haContext);
		public GroupServices Group => new(_haContext);
		public HassioServices Hassio => new(_haContext);
		public HistoryStatsServices HistoryStats => new(_haContext);
		public HomeassistantServices Homeassistant => new(_haContext);
		public HumidifierServices Humidifier => new(_haContext);
		public InputBooleanServices InputBoolean => new(_haContext);
		public InputButtonServices InputButton => new(_haContext);
		public InputDatetimeServices InputDatetime => new(_haContext);
		public InputNumberServices InputNumber => new(_haContext);
		public InputSelectServices InputSelect => new(_haContext);
		public InputTextServices InputText => new(_haContext);
		public KodiServices Kodi => new(_haContext);
		public LightServices Light => new(_haContext);
		public LogbookServices Logbook => new(_haContext);
		public LoggerServices Logger => new(_haContext);
		public MediaPlayerServices MediaPlayer => new(_haContext);
		public MinMaxServices MinMax => new(_haContext);
		public MqttServices Mqtt => new(_haContext);
		public NotifyServices Notify => new(_haContext);
		public NumberServices Number => new(_haContext);
		public OnvifServices Onvif => new(_haContext);
		public OpenhomeServices Openhome => new(_haContext);
		public PersistentNotificationServices PersistentNotification => new(_haContext);
		public PersonServices Person => new(_haContext);
		public PfsenseServices Pfsense => new(_haContext);
		public PlexServices Plex => new(_haContext);
		public PyscriptServices Pyscript => new(_haContext);
		public RecorderServices Recorder => new(_haContext);
		public RemoteServices Remote => new(_haContext);
		public RestServices Rest => new(_haContext);
		public SceneServices Scene => new(_haContext);
		public ScriptServices Script => new(_haContext);
		public SelectServices Select => new(_haContext);
		public SirenServices Siren => new(_haContext);
		public SwitchServices Switch => new(_haContext);
		public SystemLogServices SystemLog => new(_haContext);
		public TemplateServices Template => new(_haContext);
		public TimerServices Timer => new(_haContext);
		public TtsServices Tts => new(_haContext);
		public UnifiServices Unifi => new(_haContext);
		public VacuumServices Vacuum => new(_haContext);
		public VarServices Var => new(_haContext);
		public VariableServices Variable => new(_haContext);
		public WakeOnLanServices WakeOnLan => new(_haContext);
		public YamahaServices Yamaha => new(_haContext);
		public YeelightServices Yeelight => new(_haContext);
		public ZoneServices Zone => new(_haContext);
		public ZwaveJsServices ZwaveJs => new(_haContext);
	}

	public class AlarmControlPanelServices
	{
		private readonly IHaContext _haContext;
		public AlarmControlPanelServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmAway(ServiceTarget target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public void AlarmArmAway(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmCustomBypass(ServiceTarget target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, data);
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public void AlarmArmCustomBypass(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmHome(ServiceTarget target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public void AlarmArmHome(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmNight(ServiceTarget target, AlarmControlPanelAlarmArmNightParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public void AlarmArmNight(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmVacation(ServiceTarget target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public void AlarmArmVacation(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmDisarm(ServiceTarget target, AlarmControlPanelAlarmDisarmParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public void AlarmDisarm(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmTrigger(ServiceTarget target, AlarmControlPanelAlarmTriggerParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public void AlarmTrigger(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}
	}

	public record AlarmControlPanelAlarmArmAwayParameters
	{
		///<summary>An optional code to arm away the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmCustomBypassParameters
	{
		///<summary>An optional code to arm custom bypass the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmHomeParameters
	{
		///<summary>An optional code to arm home the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmNightParameters
	{
		///<summary>An optional code to arm night the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmVacationParameters
	{
		///<summary>An optional code to arm vacation the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmDisarmParameters
	{
		///<summary>An optional code to disarm the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmTriggerParameters
	{
		///<summary>An optional code to trigger the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class AlarmoServices
	{
		private readonly IHaContext _haContext;
		public AlarmoServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Arm an Alarmo entity with custom settings.</summary>
		public void Arm(AlarmoArmParameters data)
		{
			_haContext.CallService("alarmo", "arm", null, data);
		}

		///<summary>Arm an Alarmo entity with custom settings.</summary>
		///<param name="entityId">Name of entity that should be armed. eg: alarm_control_panel.alarm</param>
		///<param name="code">Code to arm the alarm with. eg: 1234</param>
		///<param name="mode">Mode to arm the alarm in. eg: away</param>
		///<param name="skipDelay">Skip the exit delay. eg: True</param>
		///<param name="force">Automatically bypass all sensors that prevent the arming operation. eg: True</param>
		public void Arm(string @entityId, string? @code = null, string? @mode = null, bool? @skipDelay = null, bool? @force = null)
		{
			_haContext.CallService("alarmo", "arm", null, new AlarmoArmParameters{EntityId = @entityId, Code = @code, Mode = @mode, SkipDelay = @skipDelay, Force = @force});
		}

		///<summary>Block a user from arming/disarming alarmo.</summary>
		public void DisableUser(AlarmoDisableUserParameters data)
		{
			_haContext.CallService("alarmo", "disable_user", null, data);
		}

		///<summary>Block a user from arming/disarming alarmo.</summary>
		///<param name="name">Name of the user to disable. eg: Frank</param>
		public void DisableUser(string @name)
		{
			_haContext.CallService("alarmo", "disable_user", null, new AlarmoDisableUserParameters{Name = @name});
		}

		///<summary>Disarm an Alarmo entity.</summary>
		public void Disarm(AlarmoDisarmParameters data)
		{
			_haContext.CallService("alarmo", "disarm", null, data);
		}

		///<summary>Disarm an Alarmo entity.</summary>
		///<param name="entityId">Name of entity that should be disarmed. eg: alarm_control_panel.alarm</param>
		///<param name="code">Code to disarm the alarm with. eg: 1234</param>
		public void Disarm(string @entityId, string? @code = null)
		{
			_haContext.CallService("alarmo", "disarm", null, new AlarmoDisarmParameters{EntityId = @entityId, Code = @code});
		}

		///<summary>Allow a user to arm/disarm alarmo.</summary>
		public void EnableUser(AlarmoEnableUserParameters data)
		{
			_haContext.CallService("alarmo", "enable_user", null, data);
		}

		///<summary>Allow a user to arm/disarm alarmo.</summary>
		///<param name="name">Name of the user to enable. eg: Frank</param>
		public void EnableUser(string @name)
		{
			_haContext.CallService("alarmo", "enable_user", null, new AlarmoEnableUserParameters{Name = @name});
		}
	}

	public record AlarmoArmParameters
	{
		///<summary>Name of entity that should be armed. eg: alarm_control_panel.alarm</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Code to arm the alarm with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }

		///<summary>Mode to arm the alarm in. eg: away</summary>
		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		///<summary>Skip the exit delay. eg: True</summary>
		[JsonPropertyName("skip_delay")]
		public bool? SkipDelay { get; init; }

		///<summary>Automatically bypass all sensors that prevent the arming operation. eg: True</summary>
		[JsonPropertyName("force")]
		public bool? Force { get; init; }
	}

	public record AlarmoDisableUserParameters
	{
		///<summary>Name of the user to disable. eg: Frank</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public record AlarmoDisarmParameters
	{
		///<summary>Name of entity that should be disarmed. eg: alarm_control_panel.alarm</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Code to disarm the alarm with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmoEnableUserParameters
	{
		///<summary>Name of the user to enable. eg: Frank</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public class AlertServices
	{
		private readonly IHaContext _haContext;
		public AlertServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggle alert's notifications.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("alert", "toggle", target);
		}

		///<summary>Silence alert's notifications.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("alert", "turn_off", target);
		}

		///<summary>Reset alert's notifications.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("alert", "turn_on", target);
		}
	}

	public class AndroidtvServices
	{
		private readonly IHaContext _haContext;
		public AndroidtvServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send an ADB command to an Android TV / Fire TV device.</summary>
		///<param name="target">The target for this service call</param>
		public void AdbCommand(ServiceTarget target, AndroidtvAdbCommandParameters data)
		{
			_haContext.CallService("androidtv", "adb_command", target, data);
		}

		///<summary>Send an ADB command to an Android TV / Fire TV device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="command">Either a key command or an ADB shell command. eg: HOME</param>
		public void AdbCommand(ServiceTarget target, string @command)
		{
			_haContext.CallService("androidtv", "adb_command", target, new AndroidtvAdbCommandParameters{Command = @command});
		}

		///<summary>Download a file from your Android TV / Fire TV device to your Home Assistant instance.</summary>
		///<param name="target">The target for this service call</param>
		public void Download(ServiceTarget target, AndroidtvDownloadParameters data)
		{
			_haContext.CallService("androidtv", "download", target, data);
		}

		///<summary>Download a file from your Android TV / Fire TV device to your Home Assistant instance.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="devicePath">The filepath on the Android TV / Fire TV device. eg: /storage/emulated/0/Download/example.txt</param>
		///<param name="localPath">The filepath on your Home Assistant instance. eg: /config/www/example.txt</param>
		public void Download(ServiceTarget target, string @devicePath, string @localPath)
		{
			_haContext.CallService("androidtv", "download", target, new AndroidtvDownloadParameters{DevicePath = @devicePath, LocalPath = @localPath});
		}

		///<summary>Translate a key press on a remote into ADB 'sendevent' commands.  You must press one button on the remote within 8 seconds of calling this service.</summary>
		///<param name="target">The target for this service call</param>
		public void LearnSendevent(ServiceTarget target)
		{
			_haContext.CallService("androidtv", "learn_sendevent", target);
		}

		///<summary>Upload a file from your Home Assistant instance to an Android TV / Fire TV device.</summary>
		///<param name="target">The target for this service call</param>
		public void Upload(ServiceTarget target, AndroidtvUploadParameters data)
		{
			_haContext.CallService("androidtv", "upload", target, data);
		}

		///<summary>Upload a file from your Home Assistant instance to an Android TV / Fire TV device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="devicePath">The filepath on the Android TV / Fire TV device. eg: /storage/emulated/0/Download/example.txt</param>
		///<param name="localPath">The filepath on your Home Assistant instance. eg: /config/www/example.txt</param>
		public void Upload(ServiceTarget target, string @devicePath, string @localPath)
		{
			_haContext.CallService("androidtv", "upload", target, new AndroidtvUploadParameters{DevicePath = @devicePath, LocalPath = @localPath});
		}
	}

	public record AndroidtvAdbCommandParameters
	{
		///<summary>Either a key command or an ADB shell command. eg: HOME</summary>
		[JsonPropertyName("command")]
		public string? Command { get; init; }
	}

	public record AndroidtvDownloadParameters
	{
		///<summary>The filepath on the Android TV / Fire TV device. eg: /storage/emulated/0/Download/example.txt</summary>
		[JsonPropertyName("device_path")]
		public string? DevicePath { get; init; }

		///<summary>The filepath on your Home Assistant instance. eg: /config/www/example.txt</summary>
		[JsonPropertyName("local_path")]
		public string? LocalPath { get; init; }
	}

	public record AndroidtvUploadParameters
	{
		///<summary>The filepath on the Android TV / Fire TV device. eg: /storage/emulated/0/Download/example.txt</summary>
		[JsonPropertyName("device_path")]
		public string? DevicePath { get; init; }

		///<summary>The filepath on your Home Assistant instance. eg: /config/www/example.txt</summary>
		[JsonPropertyName("local_path")]
		public string? LocalPath { get; init; }
	}

	public class AutomationServices
	{
		private readonly IHaContext _haContext;
		public AutomationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the automation configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("automation", "reload", null);
		}

		///<summary>Toggle (enable / disable) an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("automation", "toggle", target);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Trigger(ServiceTarget target, AutomationTriggerParameters data)
		{
			_haContext.CallService("automation", "trigger", target, data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public void Trigger(ServiceTarget target, bool? @skipCondition = null)
		{
			_haContext.CallService("automation", "trigger", target, new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, AutomationTurnOffParameters data)
		{
			_haContext.CallService("automation", "turn_off", target, data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public void TurnOff(ServiceTarget target, bool? @stopActions = null)
		{
			_haContext.CallService("automation", "turn_off", target, new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("automation", "turn_on", target);
		}
	}

	public record AutomationTriggerParameters
	{
		///<summary>Whether or not the conditions will be skipped.</summary>
		[JsonPropertyName("skip_condition")]
		public bool? SkipCondition { get; init; }
	}

	public record AutomationTurnOffParameters
	{
		///<summary>Stop currently running actions.</summary>
		[JsonPropertyName("stop_actions")]
		public bool? StopActions { get; init; }
	}

	public class ButtonServices
	{
		private readonly IHaContext _haContext;
		public ButtonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Press the button entity.</summary>
		///<param name="target">The target for this service call</param>
		public void Press(ServiceTarget target)
		{
			_haContext.CallService("button", "press", target);
		}
	}

	public class CameraServices
	{
		private readonly IHaContext _haContext;
		public CameraServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Disable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void DisableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "disable_motion_detection", target);
		}

		///<summary>Enable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void EnableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "enable_motion_detection", target);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayStream(ServiceTarget target, CameraPlayStreamParameters data)
		{
			_haContext.CallService("camera", "play_stream", target, data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public void PlayStream(ServiceTarget target, string @mediaPlayer, string? @format = null)
		{
			_haContext.CallService("camera", "play_stream", target, new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		public void Record(ServiceTarget target, CameraRecordParameters data)
		{
			_haContext.CallService("camera", "record", target, data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public void Record(ServiceTarget target, string @filename, long? @duration = null, long? @lookback = null)
		{
			_haContext.CallService("camera", "record", target, new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void Snapshot(ServiceTarget target, CameraSnapshotParameters data)
		{
			_haContext.CallService("camera", "snapshot", target, data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public void Snapshot(ServiceTarget target, string @filename)
		{
			_haContext.CallService("camera", "snapshot", target, new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_off", target);
		}

		///<summary>Turn on camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_on", target);
		}
	}

	public record CameraPlayStreamParameters
	{
		///<summary>Name(s) of media player to stream to.</summary>
		[JsonPropertyName("media_player")]
		public string? MediaPlayer { get; init; }

		///<summary>Stream format supported by media player.</summary>
		[JsonPropertyName("format")]
		public string? Format { get; init; }
	}

	public record CameraRecordParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }

		///<summary>Target recording length.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</summary>
		[JsonPropertyName("lookback")]
		public long? Lookback { get; init; }
	}

	public record CameraSnapshotParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }
	}

	public class CastServices
	{
		private readonly IHaContext _haContext;
		public CastServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Show a Lovelace view on a Chromecast.</summary>
		public void ShowLovelaceView(CastShowLovelaceViewParameters data)
		{
			_haContext.CallService("cast", "show_lovelace_view", null, data);
		}

		///<summary>Show a Lovelace view on a Chromecast.</summary>
		///<param name="entityId">Media Player entity to show the Lovelace view on.</param>
		///<param name="dashboardPath">The URL path of the Lovelace dashboard to show. eg: lovelace-cast</param>
		///<param name="viewPath">The path of the Lovelace view to show. eg: downstairs</param>
		public void ShowLovelaceView(string @entityId, string @dashboardPath, string? @viewPath = null)
		{
			_haContext.CallService("cast", "show_lovelace_view", null, new CastShowLovelaceViewParameters{EntityId = @entityId, DashboardPath = @dashboardPath, ViewPath = @viewPath});
		}
	}

	public record CastShowLovelaceViewParameters
	{
		///<summary>Media Player entity to show the Lovelace view on.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>The URL path of the Lovelace dashboard to show. eg: lovelace-cast</summary>
		[JsonPropertyName("dashboard_path")]
		public string? DashboardPath { get; init; }

		///<summary>The path of the Lovelace view to show. eg: downstairs</summary>
		[JsonPropertyName("view_path")]
		public string? ViewPath { get; init; }
	}

	public class ClimateServices
	{
		private readonly IHaContext _haContext;
		public ClimateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetAuxHeat(ServiceTarget target, ClimateSetAuxHeatParameters data)
		{
			_haContext.CallService("climate", "set_aux_heat", target, data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public void SetAuxHeat(ServiceTarget target, bool @auxHeat)
		{
			_haContext.CallService("climate", "set_aux_heat", target, new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanMode(ServiceTarget target, ClimateSetFanModeParameters data)
		{
			_haContext.CallService("climate", "set_fan_mode", target, data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public void SetFanMode(ServiceTarget target, string @fanMode)
		{
			_haContext.CallService("climate", "set_fan_mode", target, new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(ServiceTarget target, ClimateSetHumidityParameters data)
		{
			_haContext.CallService("climate", "set_humidity", target, data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public void SetHumidity(ServiceTarget target, long @humidity)
		{
			_haContext.CallService("climate", "set_humidity", target, new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHvacMode(ServiceTarget target, ClimateSetHvacModeParameters data)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public void SetHvacMode(ServiceTarget target, string? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, ClimateSetPresetModeParameters data)
		{
			_haContext.CallService("climate", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("climate", "set_preset_mode", target, new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSwingMode(ServiceTarget target, ClimateSetSwingModeParameters data)
		{
			_haContext.CallService("climate", "set_swing_mode", target, data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public void SetSwingMode(ServiceTarget target, string @swingMode)
		{
			_haContext.CallService("climate", "set_swing_mode", target, new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetTemperature(ServiceTarget target, ClimateSetTemperatureParameters data)
		{
			_haContext.CallService("climate", "set_temperature", target, data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public void SetTemperature(ServiceTarget target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, string? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_temperature", target, new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_off", target);
		}

		///<summary>Turn climate device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_on", target);
		}
	}

	public record ClimateSetAuxHeatParameters
	{
		///<summary>New value of auxiliary heater.</summary>
		[JsonPropertyName("aux_heat")]
		public bool? AuxHeat { get; init; }
	}

	public record ClimateSetFanModeParameters
	{
		///<summary>New value of fan mode. eg: low</summary>
		[JsonPropertyName("fan_mode")]
		public string? FanMode { get; init; }
	}

	public record ClimateSetHumidityParameters
	{
		///<summary>New target humidity for climate device.</summary>
		[JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record ClimateSetHvacModeParameters
	{
		///<summary>New value of operation mode.</summary>
		[JsonPropertyName("hvac_mode")]
		public string? HvacMode { get; init; }
	}

	public record ClimateSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: away</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record ClimateSetSwingModeParameters
	{
		///<summary>New value of swing mode. eg: horizontal</summary>
		[JsonPropertyName("swing_mode")]
		public string? SwingMode { get; init; }
	}

	public record ClimateSetTemperatureParameters
	{
		///<summary>New target temperature for HVAC.</summary>
		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		///<summary>New target high temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_high")]
		public double? TargetTempHigh { get; init; }

		///<summary>New target low temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_low")]
		public double? TargetTempLow { get; init; }

		///<summary>HVAC operation mode to set temperature to.</summary>
		[JsonPropertyName("hvac_mode")]
		public string? HvacMode { get; init; }
	}

	public class CloudServices
	{
		private readonly IHaContext _haContext;
		public CloudServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Make instance UI available outside over NabuCasa cloud</summary>
		public void RemoteConnect()
		{
			_haContext.CallService("cloud", "remote_connect", null);
		}

		///<summary>Disconnect UI from NabuCasa cloud</summary>
		public void RemoteDisconnect()
		{
			_haContext.CallService("cloud", "remote_disconnect", null);
		}
	}

	public class ConversationServices
	{
		private readonly IHaContext _haContext;
		public ConversationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Launch a conversation from a transcribed text.</summary>
		public void Process(ConversationProcessParameters data)
		{
			_haContext.CallService("conversation", "process", null, data);
		}

		///<summary>Launch a conversation from a transcribed text.</summary>
		///<param name="text">Transcribed text eg: Turn all lights on</param>
		public void Process(string? @text = null)
		{
			_haContext.CallService("conversation", "process", null, new ConversationProcessParameters{Text = @text});
		}
	}

	public record ConversationProcessParameters
	{
		///<summary>Transcribed text eg: Turn all lights on</summary>
		[JsonPropertyName("text")]
		public string? Text { get; init; }
	}

	public class CounterServices
	{
		private readonly IHaContext _haContext;
		public CounterServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		public void Configure(ServiceTarget target, CounterConfigureParameters data)
		{
			_haContext.CallService("counter", "configure", target, data);
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="minimum">New minimum value for the counter or None to remove minimum.</param>
		///<param name="maximum">New maximum value for the counter or None to remove maximum.</param>
		///<param name="step">New value for step.</param>
		///<param name="initial">New value for initial.</param>
		///<param name="value">New state value.</param>
		public void Configure(ServiceTarget target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			_haContext.CallService("counter", "configure", target, new CounterConfigureParameters{Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value});
		}

		///<summary>Decrement a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("counter", "decrement", target);
		}

		///<summary>Increment a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
		{
			_haContext.CallService("counter", "increment", target);
		}

		///<summary>Reset a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Reset(ServiceTarget target)
		{
			_haContext.CallService("counter", "reset", target);
		}
	}

	public record CounterConfigureParameters
	{
		///<summary>New minimum value for the counter or None to remove minimum.</summary>
		[JsonPropertyName("minimum")]
		public long? Minimum { get; init; }

		///<summary>New maximum value for the counter or None to remove maximum.</summary>
		[JsonPropertyName("maximum")]
		public long? Maximum { get; init; }

		///<summary>New value for step.</summary>
		[JsonPropertyName("step")]
		public long? Step { get; init; }

		///<summary>New value for initial.</summary>
		[JsonPropertyName("initial")]
		public long? Initial { get; init; }

		///<summary>New state value.</summary>
		[JsonPropertyName("value")]
		public long? Value { get; init; }
	}

	public class CoverServices
	{
		private readonly IHaContext _haContext;
		public CoverServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Close all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover", target);
		}

		///<summary>Close all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover_tilt", target);
		}

		///<summary>Open all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover", target);
		}

		///<summary>Open all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover_tilt", target);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverPosition(ServiceTarget target, CoverSetCoverPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_position", target, data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="position">Position of the cover</param>
		public void SetCoverPosition(ServiceTarget target, long @position)
		{
			_haContext.CallService("cover", "set_cover_position", target, new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverTiltPosition(ServiceTarget target, CoverSetCoverTiltPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public void SetCoverTiltPosition(ServiceTarget target, long @tiltPosition)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover", target);
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover_tilt", target);
		}

		///<summary>Toggle a cover open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle", target);
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void ToggleCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle_cover_tilt", target);
		}
	}

	public record CoverSetCoverPositionParameters
	{
		///<summary>Position of the cover</summary>
		[JsonPropertyName("position")]
		public long? Position { get; init; }
	}

	public record CoverSetCoverTiltPositionParameters
	{
		///<summary>Tilt position of the cover.</summary>
		[JsonPropertyName("tilt_position")]
		public long? TiltPosition { get; init; }
	}

	public class DeebotServices
	{
		private readonly IHaContext _haContext;
		public DeebotServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Manually request a refresh</summary>
		///<param name="target">The target for this service call</param>
		public void Refresh(ServiceTarget target, DeebotRefreshParameters data)
		{
			_haContext.CallService("deebot", "refresh", target, data);
		}

		///<summary>Manually request a refresh</summary>
		///<param name="target">The target for this service call</param>
		///<param name="part">Which part should be refreshed? eg: Status</param>
		public void Refresh(ServiceTarget target, string @part)
		{
			_haContext.CallService("deebot", "refresh", target, new DeebotRefreshParameters{Part = @part});
		}
	}

	public record DeebotRefreshParameters
	{
		///<summary>Which part should be refreshed? eg: Status</summary>
		[JsonPropertyName("part")]
		public string? Part { get; init; }
	}

	public class DeviceTrackerServices
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Control tracked device.</summary>
		public void See(DeviceTrackerSeeParameters data)
		{
			_haContext.CallService("device_tracker", "see", null, data);
		}

		///<summary>Control tracked device.</summary>
		///<param name="mac">MAC address of device eg: FF:FF:FF:FF:FF:FF</param>
		///<param name="devId">Id of device (find id in known_devices.yaml). eg: phonedave</param>
		///<param name="hostName">Hostname of device eg: Dave</param>
		///<param name="locationName">Name of location where device is located (not_home is away). eg: home</param>
		///<param name="gps">GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</param>
		///<param name="gpsAccuracy">Accuracy of GPS coordinates.</param>
		///<param name="battery">Battery level of device.</param>
		public void See(string? @mac = null, string? @devId = null, string? @hostName = null, string? @locationName = null, object? @gps = null, long? @gpsAccuracy = null, long? @battery = null)
		{
			_haContext.CallService("device_tracker", "see", null, new DeviceTrackerSeeParameters{Mac = @mac, DevId = @devId, HostName = @hostName, LocationName = @locationName, Gps = @gps, GpsAccuracy = @gpsAccuracy, Battery = @battery});
		}
	}

	public record DeviceTrackerSeeParameters
	{
		///<summary>MAC address of device eg: FF:FF:FF:FF:FF:FF</summary>
		[JsonPropertyName("mac")]
		public string? Mac { get; init; }

		///<summary>Id of device (find id in known_devices.yaml). eg: phonedave</summary>
		[JsonPropertyName("dev_id")]
		public string? DevId { get; init; }

		///<summary>Hostname of device eg: Dave</summary>
		[JsonPropertyName("host_name")]
		public string? HostName { get; init; }

		///<summary>Name of location where device is located (not_home is away). eg: home</summary>
		[JsonPropertyName("location_name")]
		public string? LocationName { get; init; }

		///<summary>GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</summary>
		[JsonPropertyName("gps")]
		public object? Gps { get; init; }

		///<summary>Accuracy of GPS coordinates.</summary>
		[JsonPropertyName("gps_accuracy")]
		public long? GpsAccuracy { get; init; }

		///<summary>Battery level of device.</summary>
		[JsonPropertyName("battery")]
		public long? Battery { get; init; }
	}

	public class FanServices
	{
		private readonly IHaContext _haContext;
		public FanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void DecreaseSpeed(ServiceTarget target, FanDecreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "decrease_speed", target, data);
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Decrease speed by a percentage.</param>
		public void DecreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "decrease_speed", target, new FanDecreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void IncreaseSpeed(ServiceTarget target, FanIncreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "increase_speed", target, data);
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Increase speed by a percentage.</param>
		public void IncreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "increase_speed", target, new FanIncreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		public void Oscillate(ServiceTarget target, FanOscillateParameters data)
		{
			_haContext.CallService("fan", "oscillate", target, data);
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="oscillating">Flag to turn on/off oscillation.</param>
		public void Oscillate(ServiceTarget target, bool @oscillating)
		{
			_haContext.CallService("fan", "oscillate", target, new FanOscillateParameters{Oscillating = @oscillating});
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDirection(ServiceTarget target, FanSetDirectionParameters data)
		{
			_haContext.CallService("fan", "set_direction", target, data);
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="direction">The direction to rotate.</param>
		public void SetDirection(ServiceTarget target, string @direction)
		{
			_haContext.CallService("fan", "set_direction", target, new FanSetDirectionParameters{Direction = @direction});
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPercentage(ServiceTarget target, FanSetPercentageParameters data)
		{
			_haContext.CallService("fan", "set_percentage", target, data);
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentage">Percentage speed setting.</param>
		public void SetPercentage(ServiceTarget target, long @percentage)
		{
			_haContext.CallService("fan", "set_percentage", target, new FanSetPercentageParameters{Percentage = @percentage});
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, FanSetPresetModeParameters data)
		{
			_haContext.CallService("fan", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: auto</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("fan", "set_preset_mode", target, new FanSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set fan speed.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSpeed(ServiceTarget target, FanSetSpeedParameters data)
		{
			_haContext.CallService("fan", "set_speed", target, data);
		}

		///<summary>Set fan speed.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="speed">Speed setting. eg: low</param>
		public void SetSpeed(ServiceTarget target, string @speed)
		{
			_haContext.CallService("fan", "set_speed", target, new FanSetSpeedParameters{Speed = @speed});
		}

		///<summary>Toggle the fan on/off.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("fan", "toggle", target);
		}

		///<summary>Turn fan off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("fan", "turn_off", target);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, FanTurnOnParameters data)
		{
			_haContext.CallService("fan", "turn_on", target, data);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="speed">Speed setting. eg: high</param>
		///<param name="percentage">Percentage speed setting.</param>
		///<param name="presetMode">Preset mode setting. eg: auto</param>
		public void TurnOn(ServiceTarget target, string? @speed = null, long? @percentage = null, string? @presetMode = null)
		{
			_haContext.CallService("fan", "turn_on", target, new FanTurnOnParameters{Speed = @speed, Percentage = @percentage, PresetMode = @presetMode});
		}
	}

	public record FanDecreaseSpeedParameters
	{
		///<summary>Decrease speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanIncreaseSpeedParameters
	{
		///<summary>Increase speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanOscillateParameters
	{
		///<summary>Flag to turn on/off oscillation.</summary>
		[JsonPropertyName("oscillating")]
		public bool? Oscillating { get; init; }
	}

	public record FanSetDirectionParameters
	{
		///<summary>The direction to rotate.</summary>
		[JsonPropertyName("direction")]
		public string? Direction { get; init; }
	}

	public record FanSetPercentageParameters
	{
		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }
	}

	public record FanSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record FanSetSpeedParameters
	{
		///<summary>Speed setting. eg: low</summary>
		[JsonPropertyName("speed")]
		public string? Speed { get; init; }
	}

	public record FanTurnOnParameters
	{
		///<summary>Speed setting. eg: high</summary>
		[JsonPropertyName("speed")]
		public string? Speed { get; init; }

		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }

		///<summary>Preset mode setting. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public class FfmpegServices
	{
		private readonly IHaContext _haContext;
		public FfmpegServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send a restart command to a ffmpeg based sensor.</summary>
		public void Restart(FfmpegRestartParameters data)
		{
			_haContext.CallService("ffmpeg", "restart", null, data);
		}

		///<summary>Send a restart command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will restart. Platform dependent.</param>
		public void Restart(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "restart", null, new FfmpegRestartParameters{EntityId = @entityId});
		}

		///<summary>Send a start command to a ffmpeg based sensor.</summary>
		public void Start(FfmpegStartParameters data)
		{
			_haContext.CallService("ffmpeg", "start", null, data);
		}

		///<summary>Send a start command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will start. Platform dependent.</param>
		public void Start(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "start", null, new FfmpegStartParameters{EntityId = @entityId});
		}

		///<summary>Send a stop command to a ffmpeg based sensor.</summary>
		public void Stop(FfmpegStopParameters data)
		{
			_haContext.CallService("ffmpeg", "stop", null, data);
		}

		///<summary>Send a stop command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will stop. Platform dependent.</param>
		public void Stop(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "stop", null, new FfmpegStopParameters{EntityId = @entityId});
		}
	}

	public record FfmpegRestartParameters
	{
		///<summary>Name of entity that will restart. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record FfmpegStartParameters
	{
		///<summary>Name of entity that will start. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record FfmpegStopParameters
	{
		///<summary>Name of entity that will stop. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public class FrontendServices
	{
		private readonly IHaContext _haContext;
		public FrontendServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload themes from YAML configuration.</summary>
		public void ReloadThemes()
		{
			_haContext.CallService("frontend", "reload_themes", null);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		public void SetTheme(FrontendSetThemeParameters data)
		{
			_haContext.CallService("frontend", "set_theme", null, data);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		///<param name="name">Name of a predefined theme, 'default' or 'none'. eg: default</param>
		///<param name="mode">The mode the theme is for.</param>
		public void SetTheme(string @name, string? @mode = null)
		{
			_haContext.CallService("frontend", "set_theme", null, new FrontendSetThemeParameters{Name = @name, Mode = @mode});
		}
	}

	public record FrontendSetThemeParameters
	{
		///<summary>Name of a predefined theme, 'default' or 'none'. eg: default</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>The mode the theme is for.</summary>
		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public class GarbageCollectionServices
	{
		private readonly IHaContext _haContext;
		public GarbageCollectionServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Manually add collection date.</summary>
		///<param name="target">The target for this service call</param>
		public void AddDate(ServiceTarget target, GarbageCollectionAddDateParameters data)
		{
			_haContext.CallService("garbage_collection", "add_date", target, data);
		}

		///<summary>Manually add collection date.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">The garbage_collection sensor entity_id eg: sensor.general_waste</param>
		///<param name="date">Collection date to add eg: "2020-08-16"</param>
		public void AddDate(ServiceTarget target, object? @entityId = null, object? @date = null)
		{
			_haContext.CallService("garbage_collection", "add_date", target, new GarbageCollectionAddDateParameters{EntityId = @entityId, Date = @date});
		}

		///<summary>Set the last_collection attribute to the current date and time.</summary>
		///<param name="target">The target for this service call</param>
		public void CollectGarbage(ServiceTarget target, GarbageCollectionCollectGarbageParameters data)
		{
			_haContext.CallService("garbage_collection", "collect_garbage", target, data);
		}

		///<summary>Set the last_collection attribute to the current date and time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">The garbage_collection sensor entity_id eg: sensor.general_waste</param>
		///<param name="lastCollection">Date and time of the last collection (optional) eg: 2020-08-16 10:54:00</param>
		public void CollectGarbage(ServiceTarget target, object? @entityId = null, object? @lastCollection = null)
		{
			_haContext.CallService("garbage_collection", "collect_garbage", target, new GarbageCollectionCollectGarbageParameters{EntityId = @entityId, LastCollection = @lastCollection});
		}

		///<summary>Move the collection date by a number of days.</summary>
		///<param name="target">The target for this service call</param>
		public void OffsetDate(ServiceTarget target, GarbageCollectionOffsetDateParameters data)
		{
			_haContext.CallService("garbage_collection", "offset_date", target, data);
		}

		///<summary>Move the collection date by a number of days.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">The garbage_collection sensor entity_id eg: sensor.general_waste</param>
		///<param name="date">Collection date to move eg: "2020-08-16"</param>
		///<param name="offset">Nuber of days to move (negative number will move it back) eg: 1</param>
		public void OffsetDate(ServiceTarget target, object? @entityId = null, object? @date = null, object? @offset = null)
		{
			_haContext.CallService("garbage_collection", "offset_date", target, new GarbageCollectionOffsetDateParameters{EntityId = @entityId, Date = @date, Offset = @offset});
		}

		///<summary>Remove automatically calculated collection date.</summary>
		///<param name="target">The target for this service call</param>
		public void RemoveDate(ServiceTarget target, GarbageCollectionRemoveDateParameters data)
		{
			_haContext.CallService("garbage_collection", "remove_date", target, data);
		}

		///<summary>Remove automatically calculated collection date.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">The garbage_collection sensor entity_id eg: sensor.general_waste</param>
		///<param name="date">Collection date to remove eg: "2020-08-16"</param>
		public void RemoveDate(ServiceTarget target, object? @entityId = null, object? @date = null)
		{
			_haContext.CallService("garbage_collection", "remove_date", target, new GarbageCollectionRemoveDateParameters{EntityId = @entityId, Date = @date});
		}

		///<summary>Update the entity state and attributes. Used with the manual_update option, do defer the update after changing the automatically created schedule by automation trigered by the garbage_collection_loaded event.</summary>
		///<param name="target">The target for this service call</param>
		public void UpdateState(ServiceTarget target, GarbageCollectionUpdateStateParameters data)
		{
			_haContext.CallService("garbage_collection", "update_state", target, data);
		}

		///<summary>Update the entity state and attributes. Used with the manual_update option, do defer the update after changing the automatically created schedule by automation trigered by the garbage_collection_loaded event.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">The garbage_collection sensor entity_id eg: sensor.general_waste</param>
		public void UpdateState(ServiceTarget target, object? @entityId = null)
		{
			_haContext.CallService("garbage_collection", "update_state", target, new GarbageCollectionUpdateStateParameters{EntityId = @entityId});
		}
	}

	public record GarbageCollectionAddDateParameters
	{
		///<summary>The garbage_collection sensor entity_id eg: sensor.general_waste</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>Collection date to add eg: "2020-08-16"</summary>
		[JsonPropertyName("date")]
		public object? Date { get; init; }
	}

	public record GarbageCollectionCollectGarbageParameters
	{
		///<summary>The garbage_collection sensor entity_id eg: sensor.general_waste</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>Date and time of the last collection (optional) eg: 2020-08-16 10:54:00</summary>
		[JsonPropertyName("last_collection")]
		public object? LastCollection { get; init; }
	}

	public record GarbageCollectionOffsetDateParameters
	{
		///<summary>The garbage_collection sensor entity_id eg: sensor.general_waste</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>Collection date to move eg: "2020-08-16"</summary>
		[JsonPropertyName("date")]
		public object? Date { get; init; }

		///<summary>Nuber of days to move (negative number will move it back) eg: 1</summary>
		[JsonPropertyName("offset")]
		public object? Offset { get; init; }
	}

	public record GarbageCollectionRemoveDateParameters
	{
		///<summary>The garbage_collection sensor entity_id eg: sensor.general_waste</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>Collection date to remove eg: "2020-08-16"</summary>
		[JsonPropertyName("date")]
		public object? Date { get; init; }
	}

	public record GarbageCollectionUpdateStateParameters
	{
		///<summary>The garbage_collection sensor entity_id eg: sensor.general_waste</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }
	}

	public class GenericServices
	{
		private readonly IHaContext _haContext;
		public GenericServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all generic entities.</summary>
		public void Reload()
		{
			_haContext.CallService("generic", "reload", null);
		}
	}

	public class GroupServices
	{
		private readonly IHaContext _haContext;
		public GroupServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload group configuration, entities, and notify services.</summary>
		public void Reload()
		{
			_haContext.CallService("group", "reload", null);
		}

		///<summary>Remove a user group.</summary>
		public void Remove(GroupRemoveParameters data)
		{
			_haContext.CallService("group", "remove", null, data);
		}

		///<summary>Remove a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		public void Remove(object @objectId)
		{
			_haContext.CallService("group", "remove", null, new GroupRemoveParameters{ObjectId = @objectId});
		}

		///<summary>Create/Update a user group.</summary>
		public void Set(GroupSetParameters data)
		{
			_haContext.CallService("group", "set", null, data);
		}

		///<summary>Create/Update a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		///<param name="name">Name of group eg: My test group</param>
		///<param name="icon">Name of icon for the group. eg: mdi:camera</param>
		///<param name="entities">List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="addEntities">List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="all">Enable this option if the group should only turn on when all entities are on.</param>
		public void Set(string @objectId, string? @name = null, string? @icon = null, object? @entities = null, object? @addEntities = null, bool? @all = null)
		{
			_haContext.CallService("group", "set", null, new GroupSetParameters{ObjectId = @objectId, Name = @name, Icon = @icon, Entities = @entities, AddEntities = @addEntities, All = @all});
		}
	}

	public record GroupRemoveParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public object? ObjectId { get; init; }
	}

	public record GroupSetParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public string? ObjectId { get; init; }

		///<summary>Name of group eg: My test group</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Name of icon for the group. eg: mdi:camera</summary>
		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		///<summary>List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("add_entities")]
		public object? AddEntities { get; init; }

		///<summary>Enable this option if the group should only turn on when all entities are on.</summary>
		[JsonPropertyName("all")]
		public bool? All { get; init; }
	}

	public class HassioServices
	{
		private readonly IHaContext _haContext;
		public HassioServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Restart add-on.</summary>
		public void AddonRestart(HassioAddonRestartParameters data)
		{
			_haContext.CallService("hassio", "addon_restart", null, data);
		}

		///<summary>Restart add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonRestart(string @addon)
		{
			_haContext.CallService("hassio", "addon_restart", null, new HassioAddonRestartParameters{Addon = @addon});
		}

		///<summary>Start add-on.</summary>
		public void AddonStart(HassioAddonStartParameters data)
		{
			_haContext.CallService("hassio", "addon_start", null, data);
		}

		///<summary>Start add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStart(string @addon)
		{
			_haContext.CallService("hassio", "addon_start", null, new HassioAddonStartParameters{Addon = @addon});
		}

		///<summary>Write data to add-on stdin.</summary>
		public void AddonStdin(HassioAddonStdinParameters data)
		{
			_haContext.CallService("hassio", "addon_stdin", null, data);
		}

		///<summary>Write data to add-on stdin.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStdin(string @addon)
		{
			_haContext.CallService("hassio", "addon_stdin", null, new HassioAddonStdinParameters{Addon = @addon});
		}

		///<summary>Stop add-on.</summary>
		public void AddonStop(HassioAddonStopParameters data)
		{
			_haContext.CallService("hassio", "addon_stop", null, data);
		}

		///<summary>Stop add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStop(string @addon)
		{
			_haContext.CallService("hassio", "addon_stop", null, new HassioAddonStopParameters{Addon = @addon});
		}

		///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
		public void AddonUpdate(HassioAddonUpdateParameters data)
		{
			_haContext.CallService("hassio", "addon_update", null, data);
		}

		///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonUpdate(string @addon)
		{
			_haContext.CallService("hassio", "addon_update", null, new HassioAddonUpdateParameters{Addon = @addon});
		}

		///<summary>Create a full backup.</summary>
		public void BackupFull(HassioBackupFullParameters data)
		{
			_haContext.CallService("hassio", "backup_full", null, data);
		}

		///<summary>Create a full backup.</summary>
		///<param name="name">Optional (default = current date and time). eg: Backup 1</param>
		///<param name="password">Optional password. eg: password</param>
		public void BackupFull(string? @name = null, string? @password = null)
		{
			_haContext.CallService("hassio", "backup_full", null, new HassioBackupFullParameters{Name = @name, Password = @password});
		}

		///<summary>Create a partial backup.</summary>
		public void BackupPartial(HassioBackupPartialParameters data)
		{
			_haContext.CallService("hassio", "backup_partial", null, data);
		}

		///<summary>Create a partial backup.</summary>
		///<param name="homeassistant">Backup Home Assistant settings</param>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</param>
		///<param name="folders">Optional list of directories. eg: ["homeassistant","share"]</param>
		///<param name="name">Optional (default = current date and time). eg: Partial backup 1</param>
		///<param name="password">Optional password. eg: password</param>
		public void BackupPartial(bool? @homeassistant = null, object? @addons = null, object? @folders = null, string? @name = null, string? @password = null)
		{
			_haContext.CallService("hassio", "backup_partial", null, new HassioBackupPartialParameters{Homeassistant = @homeassistant, Addons = @addons, Folders = @folders, Name = @name, Password = @password});
		}

		///<summary>Reboot the host system.</summary>
		public void HostReboot()
		{
			_haContext.CallService("hassio", "host_reboot", null);
		}

		///<summary>Poweroff the host system.</summary>
		public void HostShutdown()
		{
			_haContext.CallService("hassio", "host_shutdown", null);
		}

		///<summary>Restore from full backup.</summary>
		public void RestoreFull(HassioRestoreFullParameters data)
		{
			_haContext.CallService("hassio", "restore_full", null, data);
		}

		///<summary>Restore from full backup.</summary>
		///<param name="slug">Slug of backup to restore from.</param>
		///<param name="password">Optional password. eg: password</param>
		public void RestoreFull(string @slug, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_full", null, new HassioRestoreFullParameters{Slug = @slug, Password = @password});
		}

		///<summary>Restore from partial backup.</summary>
		public void RestorePartial(HassioRestorePartialParameters data)
		{
			_haContext.CallService("hassio", "restore_partial", null, data);
		}

		///<summary>Restore from partial backup.</summary>
		///<param name="slug">Slug of backup to restore from.</param>
		///<param name="homeassistant">Restore Home Assistant</param>
		///<param name="folders">Optional list of directories. eg: ["homeassistant","share"]</param>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</param>
		///<param name="password">Optional password. eg: password</param>
		public void RestorePartial(string @slug, bool? @homeassistant = null, object? @folders = null, object? @addons = null, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_partial", null, new HassioRestorePartialParameters{Slug = @slug, Homeassistant = @homeassistant, Folders = @folders, Addons = @addons, Password = @password});
		}
	}

	public record HassioAddonRestartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStdinParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStopParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonUpdateParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioBackupFullParameters
	{
		///<summary>Optional (default = current date and time). eg: Backup 1</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public record HassioBackupPartialParameters
	{
		///<summary>Backup Home Assistant settings</summary>
		[JsonPropertyName("homeassistant")]
		public bool? Homeassistant { get; init; }

		///<summary>Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</summary>
		[JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant","share"]</summary>
		[JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional (default = current date and time). eg: Partial backup 1</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public record HassioRestoreFullParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public record HassioRestorePartialParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Restore Home Assistant</summary>
		[JsonPropertyName("homeassistant")]
		public bool? Homeassistant { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant","share"]</summary>
		[JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</summary>
		[JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public class HistoryStatsServices
	{
		private readonly IHaContext _haContext;
		public HistoryStatsServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all history_stats entities.</summary>
		public void Reload()
		{
			_haContext.CallService("history_stats", "reload", null);
		}
	}

	public class HomeassistantServices
	{
		private readonly IHaContext _haContext;
		public HomeassistantServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Check the Home Assistant configuration files for errors. Errors will be displayed in the Home Assistant log.</summary>
		public void CheckConfig()
		{
			_haContext.CallService("homeassistant", "check_config", null);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		public void ReloadConfigEntry(ServiceTarget target, HomeassistantReloadConfigEntryParameters data)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, data);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entryId">A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</param>
		public void ReloadConfigEntry(ServiceTarget target, string? @entryId = null)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, new HomeassistantReloadConfigEntryParameters{EntryId = @entryId});
		}

		///<summary>Reload the core configuration.</summary>
		public void ReloadCoreConfig()
		{
			_haContext.CallService("homeassistant", "reload_core_config", null);
		}

		///<summary>Restart the Home Assistant service.</summary>
		public void Restart()
		{
			_haContext.CallService("homeassistant", "restart", null);
		}

		///<summary>Save the persistent states (for entities derived from RestoreEntity) immediately. Maintain the normal periodic saving interval.</summary>
		public void SavePersistentStates()
		{
			_haContext.CallService("homeassistant", "save_persistent_states", null);
		}

		///<summary>Update the Home Assistant location.</summary>
		public void SetLocation(HomeassistantSetLocationParameters data)
		{
			_haContext.CallService("homeassistant", "set_location", null, data);
		}

		///<summary>Update the Home Assistant location.</summary>
		///<param name="latitude">Latitude of your location. eg: 32.87336</param>
		///<param name="longitude">Longitude of your location. eg: 117.22743</param>
		public void SetLocation(string @latitude, string @longitude)
		{
			_haContext.CallService("homeassistant", "set_location", null, new HomeassistantSetLocationParameters{Latitude = @latitude, Longitude = @longitude});
		}

		///<summary>Stop the Home Assistant service.</summary>
		public void Stop()
		{
			_haContext.CallService("homeassistant", "stop", null);
		}

		///<summary>Generic service to toggle devices on/off under any domain</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "toggle", target);
		}

		///<summary>Generic service to turn devices off under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_off", target);
		}

		///<summary>Generic service to turn devices on under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_on", target);
		}

		///<summary>Force one or more entities to update its data</summary>
		///<param name="target">The target for this service call</param>
		public void UpdateEntity(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "update_entity", target);
		}
	}

	public record HomeassistantReloadConfigEntryParameters
	{
		///<summary>A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</summary>
		[JsonPropertyName("entry_id")]
		public string? EntryId { get; init; }
	}

	public record HomeassistantSetLocationParameters
	{
		///<summary>Latitude of your location. eg: 32.87336</summary>
		[JsonPropertyName("latitude")]
		public string? Latitude { get; init; }

		///<summary>Longitude of your location. eg: 117.22743</summary>
		[JsonPropertyName("longitude")]
		public string? Longitude { get; init; }
	}

	public class HumidifierServices
	{
		private readonly IHaContext _haContext;
		public HumidifierServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(ServiceTarget target, HumidifierSetHumidityParameters data)
		{
			_haContext.CallService("humidifier", "set_humidity", target, data);
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for humidifier device.</param>
		public void SetHumidity(ServiceTarget target, long @humidity)
		{
			_haContext.CallService("humidifier", "set_humidity", target, new HumidifierSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetMode(ServiceTarget target, HumidifierSetModeParameters data)
		{
			_haContext.CallService("humidifier", "set_mode", target, data);
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mode">New mode eg: away</param>
		public void SetMode(ServiceTarget target, string @mode)
		{
			_haContext.CallService("humidifier", "set_mode", target, new HumidifierSetModeParameters{Mode = @mode});
		}

		///<summary>Toggles a humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "toggle", target);
		}

		///<summary>Turn humidifier device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "turn_off", target);
		}

		///<summary>Turn humidifier device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "turn_on", target);
		}
	}

	public record HumidifierSetHumidityParameters
	{
		///<summary>New target humidity for humidifier device.</summary>
		[JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record HumidifierSetModeParameters
	{
		///<summary>New mode eg: away</summary>
		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public class InputBooleanServices
	{
		private readonly IHaContext _haContext;
		public InputBooleanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_boolean configuration</summary>
		public void Reload()
		{
			_haContext.CallService("input_boolean", "reload", null);
		}

		///<summary>Toggle an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "toggle", target);
		}

		///<summary>Turn off an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_off", target);
		}

		///<summary>Turn on an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_on", target);
		}
	}

	public class InputButtonServices
	{
		private readonly IHaContext _haContext;
		public InputButtonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Press the input button entity.</summary>
		///<param name="target">The target for this service call</param>
		public void Press(ServiceTarget target)
		{
			_haContext.CallService("input_button", "press", target);
		}

		public void Reload()
		{
			_haContext.CallService("input_button", "reload", null);
		}
	}

	public class InputDatetimeServices
	{
		private readonly IHaContext _haContext;
		public InputDatetimeServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_datetime configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_datetime", "reload", null);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDatetime(ServiceTarget target, InputDatetimeSetDatetimeParameters data)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public void SetDatetime(ServiceTarget target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public record InputDatetimeSetDatetimeParameters
	{
		///<summary>The target date the entity should be set to. eg: "2019-04-20"</summary>
		[JsonPropertyName("date")]
		public string? Date { get; init; }

		///<summary>The target time the entity should be set to. eg: "05:04:20"</summary>
		[JsonPropertyName("time")]
		public DateTime? Time { get; init; }

		///<summary>The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</summary>
		[JsonPropertyName("datetime")]
		public string? Datetime { get; init; }

		///<summary>The target date & time the entity should be set to as expressed by a UNIX timestamp.</summary>
		[JsonPropertyName("timestamp")]
		public long? Timestamp { get; init; }
	}

	public class InputNumberServices
	{
		private readonly IHaContext _haContext;
		public InputNumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("input_number", "decrement", target);
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
		{
			_haContext.CallService("input_number", "increment", target);
		}

		///<summary>Reload the input_number configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_number", "reload", null);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, InputNumberSetValueParameters data)
		{
			_haContext.CallService("input_number", "set_value", target, data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to.</param>
		public void SetValue(ServiceTarget target, double @value)
		{
			_haContext.CallService("input_number", "set_value", target, new InputNumberSetValueParameters{Value = @value});
		}
	}

	public record InputNumberSetValueParameters
	{
		///<summary>The target value the entity should be set to.</summary>
		[JsonPropertyName("value")]
		public double? Value { get; init; }
	}

	public class InputSelectServices
	{
		private readonly IHaContext _haContext;
		public InputSelectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_select configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_select", "reload", null);
		}

		///<summary>Select the first option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectFirst(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_first", target);
		}

		///<summary>Select the last option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectLast(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_last", target);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectNext(ServiceTarget target, InputSelectSelectNextParameters data)
		{
			_haContext.CallService("input_select", "select_next", target, data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public void SelectNext(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_next", target, new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, InputSelectSelectOptionParameters data)
		{
			_haContext.CallService("input_select", "select_option", target, data);
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("input_select", "select_option", target, new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectPrevious(ServiceTarget target, InputSelectSelectPreviousParameters data)
		{
			_haContext.CallService("input_select", "select_previous", target, data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public void SelectPrevious(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_previous", target, new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetOptions(ServiceTarget target, InputSelectSetOptionsParameters data)
		{
			_haContext.CallService("input_select", "set_options", target, data);
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public void SetOptions(ServiceTarget target, object @options)
		{
			_haContext.CallService("input_select", "set_options", target, new InputSelectSetOptionsParameters{Options = @options});
		}
	}

	public record InputSelectSelectNextParameters
	{
		///<summary>If the option should cycle from the last to the first.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public record InputSelectSelectPreviousParameters
	{
		///<summary>If the option should cycle from the first to the last.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSetOptionsParameters
	{
		///<summary>Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class InputTextServices
	{
		private readonly IHaContext _haContext;
		public InputTextServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_text configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_text", "reload", null);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, InputTextSetValueParameters data)
		{
			_haContext.CallService("input_text", "set_value", target, data);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public void SetValue(ServiceTarget target, string @value)
		{
			_haContext.CallService("input_text", "set_value", target, new InputTextSetValueParameters{Value = @value});
		}
	}

	public record InputTextSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: This is an example text</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class KodiServices
	{
		private readonly IHaContext _haContext;
		public KodiServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Add music to the default playlist (i.e. playlistid=0).</summary>
		///<param name="target">The target for this service call</param>
		public void AddToPlaylist(ServiceTarget target, KodiAddToPlaylistParameters data)
		{
			_haContext.CallService("kodi", "add_to_playlist", target, data);
		}

		///<summary>Add music to the default playlist (i.e. playlistid=0).</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaType">Media type identifier. It must be one of SONG or ALBUM. eg: ALBUM</param>
		///<param name="mediaId">Unique Id of the media entry to add (`songid` or albumid`). If not defined, `media_name` and `artist_name` are needed to search the Kodi music library. eg: 123456</param>
		///<param name="mediaName">Optional media name for filtering media. Can be 'ALL' when `media_type` is 'ALBUM' and `artist_name` is specified, to add all songs from one artist. eg: Highway to Hell</param>
		///<param name="artistName">Optional artist name for filtering media. eg: AC/DC</param>
		public void AddToPlaylist(ServiceTarget target, string @mediaType, string? @mediaId = null, string? @mediaName = null, string? @artistName = null)
		{
			_haContext.CallService("kodi", "add_to_playlist", target, new KodiAddToPlaylistParameters{MediaType = @mediaType, MediaId = @mediaId, MediaName = @mediaName, ArtistName = @artistName});
		}

		///<summary>Call a Kodi JSONRPC API method with optional parameters. Results of the Kodi API call will be redirected in a Home Assistant event: `kodi_call_method_result`.</summary>
		///<param name="target">The target for this service call</param>
		public void CallMethod(ServiceTarget target, KodiCallMethodParameters data)
		{
			_haContext.CallService("kodi", "call_method", target, data);
		}

		///<summary>Call a Kodi JSONRPC API method with optional parameters. Results of the Kodi API call will be redirected in a Home Assistant event: `kodi_call_method_result`.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="method">Name of the Kodi JSONRPC API method to be called. eg: VideoLibrary.GetRecentlyAddedEpisodes</param>
		public void CallMethod(ServiceTarget target, string @method)
		{
			_haContext.CallService("kodi", "call_method", target, new KodiCallMethodParameters{Method = @method});
		}
	}

	public record KodiAddToPlaylistParameters
	{
		///<summary>Media type identifier. It must be one of SONG or ALBUM. eg: ALBUM</summary>
		[JsonPropertyName("media_type")]
		public string? MediaType { get; init; }

		///<summary>Unique Id of the media entry to add (`songid` or albumid`). If not defined, `media_name` and `artist_name` are needed to search the Kodi music library. eg: 123456</summary>
		[JsonPropertyName("media_id")]
		public string? MediaId { get; init; }

		///<summary>Optional media name for filtering media. Can be 'ALL' when `media_type` is 'ALBUM' and `artist_name` is specified, to add all songs from one artist. eg: Highway to Hell</summary>
		[JsonPropertyName("media_name")]
		public string? MediaName { get; init; }

		///<summary>Optional artist name for filtering media. eg: AC/DC</summary>
		[JsonPropertyName("artist_name")]
		public string? ArtistName { get; init; }
	}

	public record KodiCallMethodParameters
	{
		///<summary>Name of the Kodi JSONRPC API method to be called. eg: VideoLibrary.GetRecentlyAddedEpisodes</summary>
		[JsonPropertyName("method")]
		public string? Method { get; init; }
	}

	public class LightServices
	{
		private readonly IHaContext _haContext;
		public LightServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target, LightToggleParameters data)
		{
			_haContext.CallService("light", "toggle", target, data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void Toggle(ServiceTarget target, long? @transition = null, object? @rgbColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "toggle", target, new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, LightTurnOffParameters data)
		{
			_haContext.CallService("light", "turn_off", target, data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public void TurnOff(ServiceTarget target, long? @transition = null, string? @flash = null)
		{
			_haContext.CallService("light", "turn_off", target, new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, LightTurnOnParameters data)
		{
			_haContext.CallService("light", "turn_on", target, data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void TurnOn(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "turn_on", target, new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public record LightToggleParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>Color for the light in RGB-format. eg: [255, 100, 100]</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public string? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public long? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating level of white.</summary>
		[JsonPropertyName("white_value")]
		public long? WhiteValue { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public string? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public record LightTurnOffParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public string? Flash { get; init; }
	}

	public record LightTurnOnParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</summary>
		[JsonPropertyName("rgbw_color")]
		public object? RgbwColor { get; init; }

		///<summary>A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</summary>
		[JsonPropertyName("rgbww_color")]
		public object? RgbwwColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public string? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public long? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Change brightness by an amount.</summary>
		[JsonPropertyName("brightness_step")]
		public long? BrightnessStep { get; init; }

		///<summary>Change brightness by a percentage.</summary>
		[JsonPropertyName("brightness_step_pct")]
		public long? BrightnessStepPct { get; init; }

		///<summary>Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("white")]
		public long? White { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public string? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public class LogbookServices
	{
		private readonly IHaContext _haContext;
		public LogbookServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create a custom entry in your logbook.</summary>
		public void Log(LogbookLogParameters data)
		{
			_haContext.CallService("logbook", "log", null, data);
		}

		///<summary>Create a custom entry in your logbook.</summary>
		///<param name="name">Custom name for an entity, can be referenced with entity_id. eg: Kitchen</param>
		///<param name="message">Message of the custom logbook entry. eg: is being used</param>
		///<param name="entityId">Entity to reference in custom logbook entry.</param>
		///<param name="domain">Icon of domain to display in custom logbook entry. eg: light</param>
		public void Log(string @name, string @message, string? @entityId = null, string? @domain = null)
		{
			_haContext.CallService("logbook", "log", null, new LogbookLogParameters{Name = @name, Message = @message, EntityId = @entityId, Domain = @domain});
		}
	}

	public record LogbookLogParameters
	{
		///<summary>Custom name for an entity, can be referenced with entity_id. eg: Kitchen</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Message of the custom logbook entry. eg: is being used</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Entity to reference in custom logbook entry.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Icon of domain to display in custom logbook entry. eg: light</summary>
		[JsonPropertyName("domain")]
		public string? Domain { get; init; }
	}

	public class LoggerServices
	{
		private readonly IHaContext _haContext;
		public LoggerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set the default log level for integrations.</summary>
		public void SetDefaultLevel(LoggerSetDefaultLevelParameters data)
		{
			_haContext.CallService("logger", "set_default_level", null, data);
		}

		///<summary>Set the default log level for integrations.</summary>
		///<param name="level">Default severity level for all integrations.</param>
		public void SetDefaultLevel(string? @level = null)
		{
			_haContext.CallService("logger", "set_default_level", null, new LoggerSetDefaultLevelParameters{Level = @level});
		}

		///<summary>Set log level for integrations.</summary>
		public void SetLevel()
		{
			_haContext.CallService("logger", "set_level", null);
		}
	}

	public record LoggerSetDefaultLevelParameters
	{
		///<summary>Default severity level for all integrations.</summary>
		[JsonPropertyName("level")]
		public string? Level { get; init; }
	}

	public class MediaPlayerServices
	{
		private readonly IHaContext _haContext;
		public MediaPlayerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearPlaylist(ServiceTarget target)
		{
			_haContext.CallService("media_player", "clear_playlist", target);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Join(ServiceTarget target, MediaPlayerJoinParameters data)
		{
			_haContext.CallService("media_player", "join", target, data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</param>
		public void Join(ServiceTarget target, object? @groupMembers = null)
		{
			_haContext.CallService("media_player", "join", target, new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaNextTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_next_track", target);
		}

		///<summary>Send the media player the command for pause.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_pause", target);
		}

		///<summary>Send the media player the command for play.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlay(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play", target);
		}

		///<summary>Toggle media player play/pause state.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlayPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play_pause", target);
		}

		///<summary>Send the media player the command for previous track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPreviousTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_previous_track", target);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaSeek(ServiceTarget target, MediaPlayerMediaSeekParameters data)
		{
			_haContext.CallService("media_player", "media_seek", target, data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public void MediaSeek(ServiceTarget target, double @seekPosition)
		{
			_haContext.CallService("media_player", "media_seek", target, new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaStop(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_stop", target);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayMedia(ServiceTarget target, MediaPlayerPlayMediaParameters data)
		{
			_haContext.CallService("media_player", "play_media", target, data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		public void PlayMedia(ServiceTarget target, string @mediaContentId, string @mediaContentType)
		{
			_haContext.CallService("media_player", "play_media", target, new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		public void RepeatSet(ServiceTarget target, MediaPlayerRepeatSetParameters data)
		{
			_haContext.CallService("media_player", "repeat_set", target, data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		///<param name="repeat">Repeat mode to set.</param>
		public void RepeatSet(ServiceTarget target, string @repeat)
		{
			_haContext.CallService("media_player", "repeat_set", target, new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSoundMode(ServiceTarget target, MediaPlayerSelectSoundModeParameters data)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public void SelectSoundMode(ServiceTarget target, string? @soundMode = null)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSource(ServiceTarget target, MediaPlayerSelectSourceParameters data)
		{
			_haContext.CallService("media_player", "select_source", target, data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public void SelectSource(ServiceTarget target, string @source)
		{
			_haContext.CallService("media_player", "select_source", target, new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		public void ShuffleSet(ServiceTarget target, MediaPlayerShuffleSetParameters data)
		{
			_haContext.CallService("media_player", "shuffle_set", target, data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public void ShuffleSet(ServiceTarget target, bool @shuffle)
		{
			_haContext.CallService("media_player", "shuffle_set", target, new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("media_player", "toggle", target);
		}

		///<summary>Turn a media player power off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_off", target);
		}

		///<summary>Turn a media player power on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_on", target);
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Unjoin(ServiceTarget target)
		{
			_haContext.CallService("media_player", "unjoin", target);
		}

		///<summary>Turn a media player volume down.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeDown(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_down", target);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeMute(ServiceTarget target, MediaPlayerVolumeMuteParameters data)
		{
			_haContext.CallService("media_player", "volume_mute", target, data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public void VolumeMute(ServiceTarget target, bool @isVolumeMuted)
		{
			_haContext.CallService("media_player", "volume_mute", target, new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeSet(ServiceTarget target, MediaPlayerVolumeSetParameters data)
		{
			_haContext.CallService("media_player", "volume_set", target, data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public void VolumeSet(ServiceTarget target, double @volumeLevel)
		{
			_haContext.CallService("media_player", "volume_set", target, new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeUp(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_up", target);
		}
	}

	public record MediaPlayerJoinParameters
	{
		///<summary>The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</summary>
		[JsonPropertyName("group_members")]
		public object? GroupMembers { get; init; }
	}

	public record MediaPlayerMediaSeekParameters
	{
		///<summary>Position to seek to. The format is platform dependent.</summary>
		[JsonPropertyName("seek_position")]
		public double? SeekPosition { get; init; }
	}

	public record MediaPlayerPlayMediaParameters
	{
		///<summary>The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</summary>
		[JsonPropertyName("media_content_id")]
		public string? MediaContentId { get; init; }

		///<summary>The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</summary>
		[JsonPropertyName("media_content_type")]
		public string? MediaContentType { get; init; }
	}

	public record MediaPlayerRepeatSetParameters
	{
		///<summary>Repeat mode to set.</summary>
		[JsonPropertyName("repeat")]
		public string? Repeat { get; init; }
	}

	public record MediaPlayerSelectSoundModeParameters
	{
		///<summary>Name of the sound mode to switch to. eg: Music</summary>
		[JsonPropertyName("sound_mode")]
		public string? SoundMode { get; init; }
	}

	public record MediaPlayerSelectSourceParameters
	{
		///<summary>Name of the source to switch to. Platform dependent. eg: video1</summary>
		[JsonPropertyName("source")]
		public string? Source { get; init; }
	}

	public record MediaPlayerShuffleSetParameters
	{
		///<summary>True/false for enabling/disabling shuffle.</summary>
		[JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }
	}

	public record MediaPlayerVolumeMuteParameters
	{
		///<summary>True/false for mute/unmute.</summary>
		[JsonPropertyName("is_volume_muted")]
		public bool? IsVolumeMuted { get; init; }
	}

	public record MediaPlayerVolumeSetParameters
	{
		///<summary>Volume level to set as float.</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }
	}

	public class MinMaxServices
	{
		private readonly IHaContext _haContext;
		public MinMaxServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all min_max entities.</summary>
		public void Reload()
		{
			_haContext.CallService("min_max", "reload", null);
		}
	}

	public class MqttServices
	{
		private readonly IHaContext _haContext;
		public MqttServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
		public void Dump(MqttDumpParameters data)
		{
			_haContext.CallService("mqtt", "dump", null, data);
		}

		///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
		///<param name="topic">topic to listen to eg: OpenZWave/#</param>
		///<param name="duration">how long we should listen for messages in seconds</param>
		public void Dump(string? @topic = null, long? @duration = null)
		{
			_haContext.CallService("mqtt", "dump", null, new MqttDumpParameters{Topic = @topic, Duration = @duration});
		}

		///<summary>Publish a message to an MQTT topic.</summary>
		public void Publish(MqttPublishParameters data)
		{
			_haContext.CallService("mqtt", "publish", null, data);
		}

		///<summary>Publish a message to an MQTT topic.</summary>
		///<param name="topic">Topic to publish payload. eg: /homeassistant/hello</param>
		///<param name="payload">Payload to publish. eg: This is great</param>
		///<param name="payloadTemplate">Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</param>
		///<param name="qos">Quality of Service to use.</param>
		///<param name="retain">If message should have the retain flag set.</param>
		public void Publish(string @topic, string? @payload = null, object? @payloadTemplate = null, string? @qos = null, bool? @retain = null)
		{
			_haContext.CallService("mqtt", "publish", null, new MqttPublishParameters{Topic = @topic, Payload = @payload, PayloadTemplate = @payloadTemplate, Qos = @qos, Retain = @retain});
		}

		///<summary>Reload all MQTT entities from YAML.</summary>
		public void Reload()
		{
			_haContext.CallService("mqtt", "reload", null);
		}
	}

	public record MqttDumpParameters
	{
		///<summary>topic to listen to eg: OpenZWave/#</summary>
		[JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>how long we should listen for messages in seconds</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public record MqttPublishParameters
	{
		///<summary>Topic to publish payload. eg: /homeassistant/hello</summary>
		[JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>Payload to publish. eg: This is great</summary>
		[JsonPropertyName("payload")]
		public string? Payload { get; init; }

		///<summary>Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</summary>
		[JsonPropertyName("payload_template")]
		public object? PayloadTemplate { get; init; }

		///<summary>Quality of Service to use.</summary>
		[JsonPropertyName("qos")]
		public string? Qos { get; init; }

		///<summary>If message should have the retain flag set.</summary>
		[JsonPropertyName("retain")]
		public bool? Retain { get; init; }
	}

	public class NotifyServices
	{
		private readonly IHaContext _haContext;
		public NotifyServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sends a notification message using the bear_googleypoo service.</summary>
		public void BearGoogleypoo(NotifyBearGoogleypooParameters data)
		{
			_haContext.CallService("notify", "bear_googleypoo", null, data);
		}

		///<summary>Sends a notification message using the bear_googleypoo service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void BearGoogleypoo(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "bear_googleypoo", null, new NotifyBearGoogleypooParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the bedroom_googleypoo service.</summary>
		public void BedroomGoogleypoo(NotifyBedroomGoogleypooParameters data)
		{
			_haContext.CallService("notify", "bedroom_googleypoo", null, data);
		}

		///<summary>Sends a notification message using the bedroom_googleypoo service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void BedroomGoogleypoo(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "bedroom_googleypoo", null, new NotifyBedroomGoogleypooParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the everyone service.</summary>
		public void Everyone(NotifyEveryoneParameters data)
		{
			_haContext.CallService("notify", "everyone", null, data);
		}

		///<summary>Sends a notification message using the everyone service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void Everyone(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "everyone", null, new NotifyEveryoneParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the ios_claires_iphone integration.</summary>
		public void IosClairesIphone(NotifyIosClairesIphoneParameters data)
		{
			_haContext.CallService("notify", "ios_claires_iphone", null, data);
		}

		///<summary>Sends a notification message using the ios_claires_iphone integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void IosClairesIphone(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "ios_claires_iphone", null, new NotifyIosClairesIphoneParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the kitchen_googleypoo service.</summary>
		public void KitchenGoogleypoo(NotifyKitchenGoogleypooParameters data)
		{
			_haContext.CallService("notify", "kitchen_googleypoo", null, data);
		}

		///<summary>Sends a notification message using the kitchen_googleypoo service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void KitchenGoogleypoo(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "kitchen_googleypoo", null, new NotifyKitchenGoogleypooParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the livingroom_googleypoo service.</summary>
		public void LivingroomGoogleypoo(NotifyLivingroomGoogleypooParameters data)
		{
			_haContext.CallService("notify", "livingroom_googleypoo", null, data);
		}

		///<summary>Sends a notification message using the livingroom_googleypoo service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void LivingroomGoogleypoo(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "livingroom_googleypoo", null, new NotifyLivingroomGoogleypooParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_bigsquigglepad integration.</summary>
		public void MobileAppBigsquigglepad(NotifyMobileAppBigsquigglepadParameters data)
		{
			_haContext.CallService("notify", "mobile_app_bigsquigglepad", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_bigsquigglepad integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppBigsquigglepad(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_bigsquigglepad", null, new NotifyMobileAppBigsquigglepadParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_ipad_3 integration.</summary>
		public void MobileAppIpad3(NotifyMobileAppIpad3Parameters data)
		{
			_haContext.CallService("notify", "mobile_app_ipad_3", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_ipad_3 integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppIpad3(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_ipad_3", null, new NotifyMobileAppIpad3Parameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_iphone integration.</summary>
		public void MobileAppIphone(NotifyMobileAppIphoneParameters data)
		{
			_haContext.CallService("notify", "mobile_app_iphone", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_iphone integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppIphone(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_iphone", null, new NotifyMobileAppIphoneParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_kingsquigglepad integration.</summary>
		public void MobileAppKingsquigglepad(NotifyMobileAppKingsquigglepadParameters data)
		{
			_haContext.CallService("notify", "mobile_app_kingsquigglepad", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_kingsquigglepad integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppKingsquigglepad(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_kingsquigglepad", null, new NotifyMobileAppKingsquigglepadParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_kitchen_tablet integration.</summary>
		public void MobileAppKitchenTablet(NotifyMobileAppKitchenTabletParameters data)
		{
			_haContext.CallService("notify", "mobile_app_kitchen_tablet", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_kitchen_tablet integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppKitchenTablet(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_kitchen_tablet", null, new NotifyMobileAppKitchenTabletParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_shield_tablet_k1 integration.</summary>
		public void MobileAppShieldTabletK1(NotifyMobileAppShieldTabletK1Parameters data)
		{
			_haContext.CallService("notify", "mobile_app_shield_tablet_k1", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_shield_tablet_k1 integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppShieldTabletK1(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_shield_tablet_k1", null, new NotifyMobileAppShieldTabletK1Parameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_small_squiggle_pad integration.</summary>
		public void MobileAppSmallSquigglePad(NotifyMobileAppSmallSquigglePadParameters data)
		{
			_haContext.CallService("notify", "mobile_app_small_squiggle_pad", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_small_squiggle_pad integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppSmallSquigglePad(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_small_squiggle_pad", null, new NotifyMobileAppSmallSquigglePadParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_smallsquigglepad integration.</summary>
		public void MobileAppSmallsquigglepad(NotifyMobileAppSmallsquigglepadParameters data)
		{
			_haContext.CallService("notify", "mobile_app_smallsquigglepad", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_smallsquigglepad integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppSmallsquigglepad(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_smallsquigglepad", null, new NotifyMobileAppSmallsquigglepadParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_squigglepad integration.</summary>
		public void MobileAppSquigglepad(NotifyMobileAppSquigglepadParameters data)
		{
			_haContext.CallService("notify", "mobile_app_squigglepad", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_squigglepad integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppSquigglepad(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_squigglepad", null, new NotifyMobileAppSquigglepadParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_squigglephone integration.</summary>
		public void MobileAppSquigglephone(NotifyMobileAppSquigglephoneParameters data)
		{
			_haContext.CallService("notify", "mobile_app_squigglephone", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_squigglephone integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppSquigglephone(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_squigglephone", null, new NotifyMobileAppSquigglephoneParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the notify service.</summary>
		public void Notify(NotifyNotifyParameters data)
		{
			_haContext.CallService("notify", "notify", null, data);
		}

		///<summary>Sends a notification message using the notify service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void Notify(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "notify", null, new NotifyNotifyParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the office_googleypoo service.</summary>
		public void OfficeGoogleypoo(NotifyOfficeGoogleypooParameters data)
		{
			_haContext.CallService("notify", "office_googleypoo", null, data);
		}

		///<summary>Sends a notification message using the office_googleypoo service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void OfficeGoogleypoo(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "office_googleypoo", null, new NotifyOfficeGoogleypooParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification to the visible in the front-end.</summary>
		public void PersistentNotification(NotifyPersistentNotificationParameters data)
		{
			_haContext.CallService("notify", "persistent_notification", null, data);
		}

		///<summary>Sends a notification to the visible in the front-end.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		public void PersistentNotification(string @message, string? @title = null)
		{
			_haContext.CallService("notify", "persistent_notification", null, new NotifyPersistentNotificationParameters{Message = @message, Title = @title});
		}

		///<summary>Sends a notification message using the squiggley service.</summary>
		public void Squiggley(NotifySquiggleyParameters data)
		{
			_haContext.CallService("notify", "squiggley", null, data);
		}

		///<summary>Sends a notification message using the squiggley service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void Squiggley(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "squiggley", null, new NotifySquiggleyParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the wee_bear service.</summary>
		public void WeeBear(NotifyWeeBearParameters data)
		{
			_haContext.CallService("notify", "wee_bear", null, data);
		}

		///<summary>Sends a notification message using the wee_bear service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void WeeBear(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "wee_bear", null, new NotifyWeeBearParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}
	}

	public record NotifyBearGoogleypooParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyBedroomGoogleypooParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyEveryoneParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyIosClairesIphoneParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyKitchenGoogleypooParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyLivingroomGoogleypooParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppBigsquigglepadParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppIpad3Parameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppIphoneParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppKingsquigglepadParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppKitchenTabletParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppShieldTabletK1Parameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppSmallSquigglePadParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppSmallsquigglepadParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppSquigglepadParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppSquigglephoneParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyNotifyParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyOfficeGoogleypooParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyPersistentNotificationParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public record NotifySquiggleyParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyWeeBearParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public class NumberServices
	{
		private readonly IHaContext _haContext;
		public NumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, NumberSetValueParameters data)
		{
			_haContext.CallService("number", "set_value", target, data);
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public void SetValue(ServiceTarget target, string? @value = null)
		{
			_haContext.CallService("number", "set_value", target, new NumberSetValueParameters{Value = @value});
		}
	}

	public record NumberSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: 42</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class OnvifServices
	{
		private readonly IHaContext _haContext;
		public OnvifServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>If your ONVIF camera supports PTZ, you will be able to pan, tilt or zoom your camera.</summary>
		///<param name="target">The target for this service call</param>
		public void Ptz(ServiceTarget target, OnvifPtzParameters data)
		{
			_haContext.CallService("onvif", "ptz", target, data);
		}

		///<summary>If your ONVIF camera supports PTZ, you will be able to pan, tilt or zoom your camera.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tilt">Tilt direction.</param>
		///<param name="pan">Pan direction.</param>
		///<param name="zoom">Zoom.</param>
		///<param name="distance">Distance coefficient. Sets how much PTZ should be executed in one request.</param>
		///<param name="speed">Speed coefficient. Sets how fast PTZ will be executed.</param>
		///<param name="continuousDuration">Set ContinuousMove delay in seconds before stopping the move</param>
		///<param name="preset">PTZ preset profile token. Sets the preset profile token which is executed with GotoPreset eg: 1</param>
		///<param name="moveMode">PTZ moving mode.</param>
		public void Ptz(ServiceTarget target, string? @tilt = null, string? @pan = null, string? @zoom = null, double? @distance = null, double? @speed = null, double? @continuousDuration = null, string? @preset = null, string? @moveMode = null)
		{
			_haContext.CallService("onvif", "ptz", target, new OnvifPtzParameters{Tilt = @tilt, Pan = @pan, Zoom = @zoom, Distance = @distance, Speed = @speed, ContinuousDuration = @continuousDuration, Preset = @preset, MoveMode = @moveMode});
		}
	}

	public record OnvifPtzParameters
	{
		///<summary>Tilt direction.</summary>
		[JsonPropertyName("tilt")]
		public string? Tilt { get; init; }

		///<summary>Pan direction.</summary>
		[JsonPropertyName("pan")]
		public string? Pan { get; init; }

		///<summary>Zoom.</summary>
		[JsonPropertyName("zoom")]
		public string? Zoom { get; init; }

		///<summary>Distance coefficient. Sets how much PTZ should be executed in one request.</summary>
		[JsonPropertyName("distance")]
		public double? Distance { get; init; }

		///<summary>Speed coefficient. Sets how fast PTZ will be executed.</summary>
		[JsonPropertyName("speed")]
		public double? Speed { get; init; }

		///<summary>Set ContinuousMove delay in seconds before stopping the move</summary>
		[JsonPropertyName("continuous_duration")]
		public double? ContinuousDuration { get; init; }

		///<summary>PTZ preset profile token. Sets the preset profile token which is executed with GotoPreset eg: 1</summary>
		[JsonPropertyName("preset")]
		public string? Preset { get; init; }

		///<summary>PTZ moving mode.</summary>
		[JsonPropertyName("move_mode")]
		public string? MoveMode { get; init; }
	}

	public class OpenhomeServices
	{
		private readonly IHaContext _haContext;
		public OpenhomeServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Invoke a pin on the specified device.</summary>
		///<param name="target">The target for this service call</param>
		public void InvokePin(ServiceTarget target, OpenhomeInvokePinParameters data)
		{
			_haContext.CallService("openhome", "invoke_pin", target, data);
		}

		///<summary>Invoke a pin on the specified device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="pin">Which pin to invoke</param>
		public void InvokePin(ServiceTarget target, long @pin)
		{
			_haContext.CallService("openhome", "invoke_pin", target, new OpenhomeInvokePinParameters{Pin = @pin});
		}
	}

	public record OpenhomeInvokePinParameters
	{
		///<summary>Which pin to invoke</summary>
		[JsonPropertyName("pin")]
		public long? Pin { get; init; }
	}

	public class PersistentNotificationServices
	{
		private readonly IHaContext _haContext;
		public PersistentNotificationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Show a notification in the frontend.</summary>
		public void Create(PersistentNotificationCreateParameters data)
		{
			_haContext.CallService("persistent_notification", "create", null, data);
		}

		///<summary>Show a notification in the frontend.</summary>
		///<param name="message">Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</param>
		///<param name="title">Optional title for your notification. [Templates accepted] eg: Test notification</param>
		///<param name="notificationId">Target ID of the notification, will replace a notification with the same ID. eg: 1234</param>
		public void Create(string @message, string? @title = null, string? @notificationId = null)
		{
			_haContext.CallService("persistent_notification", "create", null, new PersistentNotificationCreateParameters{Message = @message, Title = @title, NotificationId = @notificationId});
		}

		///<summary>Remove a notification from the frontend.</summary>
		public void Dismiss(PersistentNotificationDismissParameters data)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, data);
		}

		///<summary>Remove a notification from the frontend.</summary>
		///<param name="notificationId">Target ID of the notification, which should be removed. eg: 1234</param>
		public void Dismiss(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, new PersistentNotificationDismissParameters{NotificationId = @notificationId});
		}

		///<summary>Mark a notification read.</summary>
		public void MarkRead(PersistentNotificationMarkReadParameters data)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, data);
		}

		///<summary>Mark a notification read.</summary>
		///<param name="notificationId">Target ID of the notification, which should be mark read. eg: 1234</param>
		public void MarkRead(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, new PersistentNotificationMarkReadParameters{NotificationId = @notificationId});
		}
	}

	public record PersistentNotificationCreateParameters
	{
		///<summary>Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Optional title for your notification. [Templates accepted] eg: Test notification</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>Target ID of the notification, will replace a notification with the same ID. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationDismissParameters
	{
		///<summary>Target ID of the notification, which should be removed. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationMarkReadParameters
	{
		///<summary>Target ID of the notification, which should be mark read. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public class PersonServices
	{
		private readonly IHaContext _haContext;
		public PersonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the person configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("person", "reload", null);
		}
	}

	public class PfsenseServices
	{
		private readonly IHaContext _haContext;
		public PfsenseServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Closes a notice(s).</summary>
		public void CloseNotice(PfsenseCloseNoticeParameters data)
		{
			_haContext.CallService("pfsense", "close_notice", null, data);
		}

		///<summary>Closes a notice(s).</summary>
		///<param name="entityId">pfSense entity id eg: binary_sensor.pfsense_localdomain_pending_notices_present</param>
		///<param name="id">The notice ID eg: all</param>
		public void CloseNotice(object? @entityId = null, object? @id = null)
		{
			_haContext.CallService("pfsense", "close_notice", null, new PfsenseCloseNoticeParameters{EntityId = @entityId, Id = @id});
		}

		///<summary>Files a notice(s).</summary>
		public void FileNotice(PfsenseFileNoticeParameters data)
		{
			_haContext.CallService("pfsense", "file_notice", null, data);
		}

		///<summary>Files a notice(s).</summary>
		///<param name="entityId">pfSense entity id eg: binary_sensor.pfsense_localdomain_pending_notices_present</param>
		///<param name="id">The notice ID eg: all</param>
		///<param name="notice">The notice message eg: hello world from hass</param>
		///<param name="category">The category of the notice eg: General</param>
		///<param name="url">The url of the notice eg: https://example.com</param>
		///<param name="priority">The priority of the notice eg: 1</param>
		///<param name="localOnly">Do not send the notice via email, etc eg: False</param>
		public void FileNotice(object @id, object @notice, object? @entityId = null, object? @category = null, object? @url = null, object? @priority = null, object? @localOnly = null)
		{
			_haContext.CallService("pfsense", "file_notice", null, new PfsenseFileNoticeParameters{EntityId = @entityId, Id = @id, Notice = @notice, Category = @category, Url = @url, Priority = @priority, LocalOnly = @localOnly});
		}

		///<summary>Restarts a service.</summary>
		public void RestartService(PfsenseRestartServiceParameters data)
		{
			_haContext.CallService("pfsense", "restart_service", null, data);
		}

		///<summary>Restarts a service.</summary>
		///<param name="entityId">pfSense entity id eg: binary_sensor.pfsense_localdomain_pending_notices_present</param>
		///<param name="serviceName">The name of the service. eg: haproxy|dhcp|dpinger|..</param>
		public void RestartService(object @serviceName, object? @entityId = null)
		{
			_haContext.CallService("pfsense", "restart_service", null, new PfsenseRestartServiceParameters{EntityId = @entityId, ServiceName = @serviceName});
		}

		///<summary>Sends wake-on-lan magic packet.</summary>
		public void SendWol(PfsenseSendWolParameters data)
		{
			_haContext.CallService("pfsense", "send_wol", null, data);
		}

		///<summary>Sends wake-on-lan magic packet.</summary>
		///<param name="entityId">pfSense entity id eg: binary_sensor.pfsense_localdomain_pending_notices_present</param>
		///<param name="interface">The name of the interface. eg: wan|lan|opt1|opt2|...</param>
		///<param name="mac">The target mac address.</param>
		public void SendWol(object @interface, object @mac, object? @entityId = null)
		{
			_haContext.CallService("pfsense", "send_wol", null, new PfsenseSendWolParameters{EntityId = @entityId, Interface = @interface, Mac = @mac});
		}

		///<summary>Starts a service.</summary>
		public void StartService(PfsenseStartServiceParameters data)
		{
			_haContext.CallService("pfsense", "start_service", null, data);
		}

		///<summary>Starts a service.</summary>
		///<param name="entityId">pfSense entity id eg: binary_sensor.pfsense_localdomain_pending_notices_present</param>
		///<param name="serviceName">The name of the service. eg: haproxy|dhcp|dpinger|..</param>
		public void StartService(object @serviceName, object? @entityId = null)
		{
			_haContext.CallService("pfsense", "start_service", null, new PfsenseStartServiceParameters{EntityId = @entityId, ServiceName = @serviceName});
		}

		///<summary>Stops a service.</summary>
		public void StopService(PfsenseStopServiceParameters data)
		{
			_haContext.CallService("pfsense", "stop_service", null, data);
		}

		///<summary>Stops a service.</summary>
		///<param name="entityId">pfSense entity id eg: binary_sensor.pfsense_localdomain_pending_notices_present</param>
		///<param name="serviceName">The name of the service. eg: haproxy|dhcp|dpinger|..</param>
		public void StopService(object @serviceName, object? @entityId = null)
		{
			_haContext.CallService("pfsense", "stop_service", null, new PfsenseStopServiceParameters{EntityId = @entityId, ServiceName = @serviceName});
		}

		///<summary>Halts the system.</summary>
		public void SystemHalt(PfsenseSystemHaltParameters data)
		{
			_haContext.CallService("pfsense", "system_halt", null, data);
		}

		///<summary>Halts the system.</summary>
		///<param name="entityId">pfSense entity id eg: binary_sensor.pfsense_localdomain_pending_notices_present</param>
		public void SystemHalt(object? @entityId = null)
		{
			_haContext.CallService("pfsense", "system_halt", null, new PfsenseSystemHaltParameters{EntityId = @entityId});
		}

		///<summary>Reboots the system.</summary>
		public void SystemReboot(PfsenseSystemRebootParameters data)
		{
			_haContext.CallService("pfsense", "system_reboot", null, data);
		}

		///<summary>Reboots the system.</summary>
		///<param name="entityId">pfSense entity id eg: binary_sensor.pfsense_localdomain_pending_notices_present</param>
		public void SystemReboot(object? @entityId = null)
		{
			_haContext.CallService("pfsense", "system_reboot", null, new PfsenseSystemRebootParameters{EntityId = @entityId});
		}
	}

	public record PfsenseCloseNoticeParameters
	{
		///<summary>pfSense entity id eg: binary_sensor.pfsense_localdomain_pending_notices_present</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>The notice ID eg: all</summary>
		[JsonPropertyName("id")]
		public object? Id { get; init; }
	}

	public record PfsenseFileNoticeParameters
	{
		///<summary>pfSense entity id eg: binary_sensor.pfsense_localdomain_pending_notices_present</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>The notice ID eg: all</summary>
		[JsonPropertyName("id")]
		public object? Id { get; init; }

		///<summary>The notice message eg: hello world from hass</summary>
		[JsonPropertyName("notice")]
		public object? Notice { get; init; }

		///<summary>The category of the notice eg: General</summary>
		[JsonPropertyName("category")]
		public object? Category { get; init; }

		///<summary>The url of the notice eg: https://example.com</summary>
		[JsonPropertyName("url")]
		public object? Url { get; init; }

		///<summary>The priority of the notice eg: 1</summary>
		[JsonPropertyName("priority")]
		public object? Priority { get; init; }

		///<summary>Do not send the notice via email, etc eg: False</summary>
		[JsonPropertyName("local_only")]
		public object? LocalOnly { get; init; }
	}

	public record PfsenseRestartServiceParameters
	{
		///<summary>pfSense entity id eg: binary_sensor.pfsense_localdomain_pending_notices_present</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>The name of the service. eg: haproxy|dhcp|dpinger|..</summary>
		[JsonPropertyName("service_name")]
		public object? ServiceName { get; init; }
	}

	public record PfsenseSendWolParameters
	{
		///<summary>pfSense entity id eg: binary_sensor.pfsense_localdomain_pending_notices_present</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>The name of the interface. eg: wan|lan|opt1|opt2|...</summary>
		[JsonPropertyName("interface")]
		public object? Interface { get; init; }

		///<summary>The target mac address.</summary>
		[JsonPropertyName("mac")]
		public object? Mac { get; init; }
	}

	public record PfsenseStartServiceParameters
	{
		///<summary>pfSense entity id eg: binary_sensor.pfsense_localdomain_pending_notices_present</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>The name of the service. eg: haproxy|dhcp|dpinger|..</summary>
		[JsonPropertyName("service_name")]
		public object? ServiceName { get; init; }
	}

	public record PfsenseStopServiceParameters
	{
		///<summary>pfSense entity id eg: binary_sensor.pfsense_localdomain_pending_notices_present</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>The name of the service. eg: haproxy|dhcp|dpinger|..</summary>
		[JsonPropertyName("service_name")]
		public object? ServiceName { get; init; }
	}

	public record PfsenseSystemHaltParameters
	{
		///<summary>pfSense entity id eg: binary_sensor.pfsense_localdomain_pending_notices_present</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }
	}

	public record PfsenseSystemRebootParameters
	{
		///<summary>pfSense entity id eg: binary_sensor.pfsense_localdomain_pending_notices_present</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }
	}

	public class PlexServices
	{
		private readonly IHaContext _haContext;
		public PlexServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Refresh a Plex library to scan for new and updated media.</summary>
		public void RefreshLibrary(PlexRefreshLibraryParameters data)
		{
			_haContext.CallService("plex", "refresh_library", null, data);
		}

		///<summary>Refresh a Plex library to scan for new and updated media.</summary>
		///<param name="serverName">Name of a Plex server if multiple Plex servers configured. eg: My Plex Server</param>
		///<param name="libraryName">Name of the Plex library to refresh. eg: TV Shows</param>
		public void RefreshLibrary(string @libraryName, string? @serverName = null)
		{
			_haContext.CallService("plex", "refresh_library", null, new PlexRefreshLibraryParameters{ServerName = @serverName, LibraryName = @libraryName});
		}

		///<summary>Scan for available clients from the Plex server(s), local network, and plex.tv.</summary>
		public void ScanForClients()
		{
			_haContext.CallService("plex", "scan_for_clients", null);
		}
	}

	public record PlexRefreshLibraryParameters
	{
		///<summary>Name of a Plex server if multiple Plex servers configured. eg: My Plex Server</summary>
		[JsonPropertyName("server_name")]
		public string? ServerName { get; init; }

		///<summary>Name of the Plex library to refresh. eg: TV Shows</summary>
		[JsonPropertyName("library_name")]
		public string? LibraryName { get; init; }
	}

	public class PyscriptServices
	{
		private readonly IHaContext _haContext;
		public PyscriptServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Starts a jupyter kernel for interactive use; Called by Jupyter front end and should generally not be used by users</summary>
		public void JupyterKernelStart(PyscriptJupyterKernelStartParameters data)
		{
			_haContext.CallService("pyscript", "jupyter_kernel_start", null, data);
		}

		///<summary>Starts a jupyter kernel for interactive use; Called by Jupyter front end and should generally not be used by users</summary>
		///<param name="shellPort">Shell port number eg: 63599</param>
		///<param name="iopubPort">IOPub port number eg: 63598</param>
		///<param name="stdinPort">Stdin port number eg: 63597</param>
		///<param name="controlPort">Control port number eg: 63596</param>
		///<param name="hbPort">Heartbeat port number eg: 63595</param>
		///<param name="ip">IP address to connect to Jupyter front end eg: 127.0.0.1</param>
		///<param name="key">Used for signing eg: 012345678-9abcdef023456789abcdef</param>
		///<param name="transport">Transport type eg: tcp</param>
		///<param name="signatureScheme">Signing algorithm eg: hmac-sha256</param>
		///<param name="kernelName">Kernel name eg: pyscript</param>
		public void JupyterKernelStart(string @key, string @kernelName, long? @shellPort = null, long? @iopubPort = null, long? @stdinPort = null, long? @controlPort = null, long? @hbPort = null, string? @ip = null, string? @transport = null, string? @signatureScheme = null)
		{
			_haContext.CallService("pyscript", "jupyter_kernel_start", null, new PyscriptJupyterKernelStartParameters{ShellPort = @shellPort, IopubPort = @iopubPort, StdinPort = @stdinPort, ControlPort = @controlPort, HbPort = @hbPort, Ip = @ip, Key = @key, Transport = @transport, SignatureScheme = @signatureScheme, KernelName = @kernelName});
		}

		///<summary>Reloads all available pyscripts and restart triggers</summary>
		public void Reload(PyscriptReloadParameters data)
		{
			_haContext.CallService("pyscript", "reload", null, data);
		}

		///<summary>Reloads all available pyscripts and restart triggers</summary>
		///<param name="globalCtx">Only reload this specific global context (file or app) eg: file.example</param>
		public void Reload(string? @globalCtx = null)
		{
			_haContext.CallService("pyscript", "reload", null, new PyscriptReloadParameters{GlobalCtx = @globalCtx});
		}
	}

	public record PyscriptJupyterKernelStartParameters
	{
		///<summary>Shell port number eg: 63599</summary>
		[JsonPropertyName("shell_port")]
		public long? ShellPort { get; init; }

		///<summary>IOPub port number eg: 63598</summary>
		[JsonPropertyName("iopub_port")]
		public long? IopubPort { get; init; }

		///<summary>Stdin port number eg: 63597</summary>
		[JsonPropertyName("stdin_port")]
		public long? StdinPort { get; init; }

		///<summary>Control port number eg: 63596</summary>
		[JsonPropertyName("control_port")]
		public long? ControlPort { get; init; }

		///<summary>Heartbeat port number eg: 63595</summary>
		[JsonPropertyName("hb_port")]
		public long? HbPort { get; init; }

		///<summary>IP address to connect to Jupyter front end eg: 127.0.0.1</summary>
		[JsonPropertyName("ip")]
		public string? Ip { get; init; }

		///<summary>Used for signing eg: 012345678-9abcdef023456789abcdef</summary>
		[JsonPropertyName("key")]
		public string? Key { get; init; }

		///<summary>Transport type eg: tcp</summary>
		[JsonPropertyName("transport")]
		public string? Transport { get; init; }

		///<summary>Signing algorithm eg: hmac-sha256</summary>
		[JsonPropertyName("signature_scheme")]
		public string? SignatureScheme { get; init; }

		///<summary>Kernel name eg: pyscript</summary>
		[JsonPropertyName("kernel_name")]
		public string? KernelName { get; init; }
	}

	public record PyscriptReloadParameters
	{
		///<summary>Only reload this specific global context (file or app) eg: file.example</summary>
		[JsonPropertyName("global_ctx")]
		public string? GlobalCtx { get; init; }
	}

	public class RecorderServices
	{
		private readonly IHaContext _haContext;
		public RecorderServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Stop the recording of events and state changes</summary>
		public void Disable()
		{
			_haContext.CallService("recorder", "disable", null);
		}

		///<summary>Start the recording of events and state changes</summary>
		public void Enable()
		{
			_haContext.CallService("recorder", "enable", null);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		public void Purge(RecorderPurgeParameters data)
		{
			_haContext.CallService("recorder", "purge", null, data);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		///<param name="keepDays">Number of history days to keep in database after purge.</param>
		///<param name="repack">Attempt to save disk space by rewriting the entire database file.</param>
		///<param name="applyFilter">Apply entity_id and event_type filter in addition to time based purge.</param>
		public void Purge(long? @keepDays = null, bool? @repack = null, bool? @applyFilter = null)
		{
			_haContext.CallService("recorder", "purge", null, new RecorderPurgeParameters{KeepDays = @keepDays, Repack = @repack, ApplyFilter = @applyFilter});
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		public void PurgeEntities(ServiceTarget target, RecorderPurgeEntitiesParameters data)
		{
			_haContext.CallService("recorder", "purge_entities", target, data);
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="domains">List the domains that need to be removed from the recorder database. eg: sun</param>
		///<param name="entityGlobs">List the glob patterns to select entities for removal from the recorder database. eg: domain*.object_id*</param>
		public void PurgeEntities(ServiceTarget target, object? @domains = null, object? @entityGlobs = null)
		{
			_haContext.CallService("recorder", "purge_entities", target, new RecorderPurgeEntitiesParameters{Domains = @domains, EntityGlobs = @entityGlobs});
		}
	}

	public record RecorderPurgeParameters
	{
		///<summary>Number of history days to keep in database after purge.</summary>
		[JsonPropertyName("keep_days")]
		public long? KeepDays { get; init; }

		///<summary>Attempt to save disk space by rewriting the entire database file.</summary>
		[JsonPropertyName("repack")]
		public bool? Repack { get; init; }

		///<summary>Apply entity_id and event_type filter in addition to time based purge.</summary>
		[JsonPropertyName("apply_filter")]
		public bool? ApplyFilter { get; init; }
	}

	public record RecorderPurgeEntitiesParameters
	{
		///<summary>List the domains that need to be removed from the recorder database. eg: sun</summary>
		[JsonPropertyName("domains")]
		public object? Domains { get; init; }

		///<summary>List the glob patterns to select entities for removal from the recorder database. eg: domain*.object_id*</summary>
		[JsonPropertyName("entity_globs")]
		public object? EntityGlobs { get; init; }
	}

	public class RemoteServices
	{
		private readonly IHaContext _haContext;
		public RemoteServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The target for this service call</param>
		public void DeleteCommand(ServiceTarget target, RemoteDeleteCommandParameters data)
		{
			_haContext.CallService("remote", "delete_command", target, data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public void DeleteCommand(ServiceTarget target, object @command, string? @device = null)
		{
			_haContext.CallService("remote", "delete_command", target, new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The target for this service call</param>
		public void LearnCommand(ServiceTarget target, RemoteLearnCommandParameters data)
		{
			_haContext.CallService("remote", "learn_command", target, data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public void LearnCommand(ServiceTarget target, string? @device = null, object? @command = null, string? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			_haContext.CallService("remote", "learn_command", target, new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(ServiceTarget target, RemoteSendCommandParameters data)
		{
			_haContext.CallService("remote", "send_command", target, data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public void SendCommand(ServiceTarget target, object @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			_haContext.CallService("remote", "send_command", target, new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Toggles a device.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("remote", "toggle", target);
		}

		///<summary>Sends the Power Off Command.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("remote", "turn_off", target);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, RemoteTurnOnParameters data)
		{
			_haContext.CallService("remote", "turn_on", target, data);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public void TurnOn(ServiceTarget target, string? @activity = null)
		{
			_haContext.CallService("remote", "turn_on", target, new RemoteTurnOnParameters{Activity = @activity});
		}
	}

	public record RemoteDeleteCommandParameters
	{
		///<summary>Name of the device from which commands will be deleted. eg: television</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to delete. eg: Mute</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }
	}

	public record RemoteLearnCommandParameters
	{
		///<summary>Device ID to learn command from. eg: television</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to learn. eg: Turn on</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }

		///<summary>The type of command to be learned.</summary>
		[JsonPropertyName("command_type")]
		public string? CommandType { get; init; }

		///<summary>If code must be stored as alternative (useful for discrete remotes).</summary>
		[JsonPropertyName("alternative")]
		public bool? Alternative { get; init; }

		///<summary>Timeout for the command to be learned.</summary>
		[JsonPropertyName("timeout")]
		public long? Timeout { get; init; }
	}

	public record RemoteSendCommandParameters
	{
		///<summary>Device ID to send command to. eg: 32756745</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to send. eg: Play</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }

		///<summary>The number of times you want to repeat the command(s).</summary>
		[JsonPropertyName("num_repeats")]
		public long? NumRepeats { get; init; }

		///<summary>The time you want to wait in between repeated commands.</summary>
		[JsonPropertyName("delay_secs")]
		public double? DelaySecs { get; init; }

		///<summary>The time you want to have it held before the release is send.</summary>
		[JsonPropertyName("hold_secs")]
		public double? HoldSecs { get; init; }
	}

	public record RemoteTurnOnParameters
	{
		///<summary>Activity ID or Activity Name to start. eg: BedroomTV</summary>
		[JsonPropertyName("activity")]
		public string? Activity { get; init; }
	}

	public class RestServices
	{
		private readonly IHaContext _haContext;
		public RestServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all rest entities and notify services</summary>
		public void Reload()
		{
			_haContext.CallService("rest", "reload", null);
		}
	}

	public class SceneServices
	{
		private readonly IHaContext _haContext;
		public SceneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Activate a scene with configuration.</summary>
		public void Apply(SceneApplyParameters data)
		{
			_haContext.CallService("scene", "apply", null, data);
		}

		///<summary>Activate a scene with configuration.</summary>
		///<param name="entities">The entities and the state that they need to be. eg: {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void Apply(object @entities, long? @transition = null)
		{
			_haContext.CallService("scene", "apply", null, new SceneApplyParameters{Entities = @entities, Transition = @transition});
		}

		///<summary>Creates a new scene.</summary>
		public void Create(SceneCreateParameters data)
		{
			_haContext.CallService("scene", "create", null, data);
		}

		///<summary>Creates a new scene.</summary>
		///<param name="sceneId">The entity_id of the new scene. eg: all_lights</param>
		///<param name="entities">The entities to control with the scene. eg: {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}</param>
		///<param name="snapshotEntities">The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</param>
		public void Create(string @sceneId, object? @entities = null, object? @snapshotEntities = null)
		{
			_haContext.CallService("scene", "create", null, new SceneCreateParameters{SceneId = @sceneId, Entities = @entities, SnapshotEntities = @snapshotEntities});
		}

		///<summary>Reload the scene configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("scene", "reload", null);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, SceneTurnOnParameters data)
		{
			_haContext.CallService("scene", "turn_on", target, data);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void TurnOn(ServiceTarget target, long? @transition = null)
		{
			_haContext.CallService("scene", "turn_on", target, new SceneTurnOnParameters{Transition = @transition});
		}
	}

	public record SceneApplyParameters
	{
		///<summary>The entities and the state that they need to be. eg: {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public record SceneCreateParameters
	{
		///<summary>The entity_id of the new scene. eg: all_lights</summary>
		[JsonPropertyName("scene_id")]
		public string? SceneId { get; init; }

		///<summary>The entities to control with the scene. eg: {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</summary>
		[JsonPropertyName("snapshot_entities")]
		public object? SnapshotEntities { get; init; }
	}

	public record SceneTurnOnParameters
	{
		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public class ScriptServices
	{
		private readonly IHaContext _haContext;
		public ScriptServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void AlarmFlashLightsScript()
		{
			_haContext.CallService("script", "alarm_flash_lights_script", null);
		}

		public void AlarmFlashLoop()
		{
			_haContext.CallService("script", "alarm_flash_loop", null);
		}

		public void AlarmVoiceMessageAndSiren()
		{
			_haContext.CallService("script", "alarm_voice_message_and_siren", null);
		}

		public void BackgardenTurnOffLights()
		{
			_haContext.CallService("script", "backgarden_turn_off_lights", null);
		}

		public void BackgardenTurnOnLights()
		{
			_haContext.CallService("script", "backgarden_turn_on_lights", null);
		}

		///<summary>Start a deebot cleaning task</summary>
		public void DeebotClean()
		{
			_haContext.CallService("script", "deebot_clean", null);
		}

		///<summary>Add/Remove a room from the queue</summary>
		public void DeebotRoomQueue(ScriptDeebotRoomQueueParameters data)
		{
			_haContext.CallService("script", "deebot_room_queue", null, data);
		}

		///<summary>Add/Remove a room from the queue</summary>
		///<param name="queue">The queue variable eg: deebot_kaggi_ii_queue</param>
		///<param name="room">Room, which should be removed or added eg: kitchen</param>
		public void DeebotRoomQueue(object? @queue = null, object? @room = null)
		{
			_haContext.CallService("script", "deebot_room_queue", null, new ScriptDeebotRoomQueueParameters{Queue = @queue, Room = @room});
		}

		public void DoorbellStopCastingToOfficeDisplayAfter30Seconds()
		{
			_haContext.CallService("script", "doorbell_stop_casting_to_office_display_after_30_seconds", null);
		}

		public void HomeOff()
		{
			_haContext.CallService("script", "home_off", null);
		}

		public void HomeOffWhenEveryoneLeaves()
		{
			_haContext.CallService("script", "home_off_when_everyone_leaves", null);
		}

		public void MakeupTime()
		{
			_haContext.CallService("script", "makeup_time", null);
		}

		public void MarvinSwitchProfileToSquiggley()
		{
			_haContext.CallService("script", "marvin_switch_profile_to_squiggley", null);
		}

		public void MarvinSwitchProfileToWeeBear()
		{
			_haContext.CallService("script", "marvin_switch_profile_to_wee_bear", null);
		}

		public void PulselightAction()
		{
			_haContext.CallService("script", "pulselight_action", null);
		}

		public void PulselightLoop()
		{
			_haContext.CallService("script", "pulselight_loop", null);
		}

		public void PulselightStart()
		{
			_haContext.CallService("script", "pulselight_start", null);
		}

		public void PulselightStop()
		{
			_haContext.CallService("script", "pulselight_stop", null);
		}

		///<summary>Reload all the available scripts</summary>
		public void Reload()
		{
			_haContext.CallService("script", "reload", null);
		}

		public void SendMessageToUiSelectedUser()
		{
			_haContext.CallService("script", "send_message_to_ui_selected_user", null);
		}

		public void SlartibartfarstSwitchProfileToSquiggley()
		{
			_haContext.CallService("script", "slartibartfarst_switch_profile_to_squiggley", null);
		}

		public void SlartibartfarstSwitchProfileToWeeBear()
		{
			_haContext.CallService("script", "slartibartfarst_switch_profile_to_wee_bear", null);
		}

		public void StupidBoxOff()
		{
			_haContext.CallService("script", "stupid_box_off", null);
		}

		public void StupidBoxOn()
		{
			_haContext.CallService("script", "stupid_box_on", null);
		}

		///<summary>Toggle script</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("script", "toggle", target);
		}

		public void TurnAllLightsOff()
		{
			_haContext.CallService("script", "turn_all_lights_off", null);
		}

		public void TurnDownstairsMediaPlayersOff()
		{
			_haContext.CallService("script", "turn_downstairs_media_players_off", null);
		}

		public void TurnHeatingOff()
		{
			_haContext.CallService("script", "turn_heating_off", null);
		}

		public void TurnHeatingOn()
		{
			_haContext.CallService("script", "turn_heating_on", null);
		}

		///<summary>Turn off script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_off", target);
		}

		public void TurnOffAllTheLightsExceptGarden()
		{
			_haContext.CallService("script", "turn_off_all_the_lights_except_garden", null);
		}

		///<summary>Turn on script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_on", target);
		}

		public void TurnOnTheOffice()
		{
			_haContext.CallService("script", "turn_on_the_office", null);
		}

		public void TurnSocketsOff()
		{
			_haContext.CallService("script", "turn_sockets_off", null);
		}

		public void UpdateLocations()
		{
			_haContext.CallService("script", "update_locations", null);
		}

		public void VacuumCleanZone()
		{
			_haContext.CallService("script", "vacuum_clean_zone", null);
		}

		public void ZaphodBack()
		{
			_haContext.CallService("script", "zaphod_back", null);
		}

		public void ZaphodDown()
		{
			_haContext.CallService("script", "zaphod_down", null);
		}

		public void ZaphodHome()
		{
			_haContext.CallService("script", "zaphod_home", null);
		}

		public void ZaphodLeft()
		{
			_haContext.CallService("script", "zaphod_left", null);
		}

		public void ZaphodNext()
		{
			_haContext.CallService("script", "zaphod_next", null);
		}

		public void ZaphodPlayPause()
		{
			_haContext.CallService("script", "zaphod_play_pause", null);
		}

		public void ZaphodPlaylist()
		{
			_haContext.CallService("script", "zaphod_playlist", null);
		}

		public void ZaphodPrev()
		{
			_haContext.CallService("script", "zaphod_prev", null);
		}

		public void ZaphodRight()
		{
			_haContext.CallService("script", "zaphod_right", null);
		}

		public void ZaphodSelect()
		{
			_haContext.CallService("script", "zaphod_select", null);
		}

		public void ZaphodStop()
		{
			_haContext.CallService("script", "zaphod_stop", null);
		}

		public void ZaphodSwitchProfileToSquiggley()
		{
			_haContext.CallService("script", "zaphod_switch_profile_to_squiggley", null);
		}

		public void ZaphodSwitchProfileToWeeBear()
		{
			_haContext.CallService("script", "zaphod_switch_profile_to_wee_bear", null);
		}

		public void ZaphodUp()
		{
			_haContext.CallService("script", "zaphod_up", null);
		}

		public void ZaphodVolumeDown()
		{
			_haContext.CallService("script", "zaphod_volume_down", null);
		}

		public void ZaphodVolumeMute()
		{
			_haContext.CallService("script", "zaphod_volume_mute", null);
		}

		public void ZaphodVolumeUp()
		{
			_haContext.CallService("script", "zaphod_volume_up", null);
		}

		public void Zoom()
		{
			_haContext.CallService("script", "zoom", null);
		}
	}

	public record ScriptDeebotRoomQueueParameters
	{
		///<summary>The queue variable eg: deebot_kaggi_ii_queue</summary>
		[JsonPropertyName("queue")]
		public object? Queue { get; init; }

		///<summary>Room, which should be removed or added eg: kitchen</summary>
		[JsonPropertyName("room")]
		public object? Room { get; init; }
	}

	public class SelectServices
	{
		private readonly IHaContext _haContext;
		public SelectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, SelectSelectOptionParameters data)
		{
			_haContext.CallService("select", "select_option", target, data);
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("select", "select_option", target, new SelectSelectOptionParameters{Option = @option});
		}
	}

	public record SelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public class SirenServices
	{
		private readonly IHaContext _haContext;
		public SirenServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a siren.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("siren", "toggle", target);
		}

		///<summary>Turn siren off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("siren", "turn_off", target);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, SirenTurnOnParameters data)
		{
			_haContext.CallService("siren", "turn_on", target, data);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tone">The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</param>
		///<param name="volumeLevel">The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0.5</param>
		///<param name="duration">The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</param>
		public void TurnOn(ServiceTarget target, string? @tone = null, double? @volumeLevel = null, string? @duration = null)
		{
			_haContext.CallService("siren", "turn_on", target, new SirenTurnOnParameters{Tone = @tone, VolumeLevel = @volumeLevel, Duration = @duration});
		}
	}

	public record SirenTurnOnParameters
	{
		///<summary>The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</summary>
		[JsonPropertyName("tone")]
		public string? Tone { get; init; }

		///<summary>The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0.5</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }

		///<summary>The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class SwitchServices
	{
		private readonly IHaContext _haContext;
		public SwitchServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a switch state</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("switch", "toggle", target);
		}

		///<summary>Turn a switch off</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_off", target);
		}

		///<summary>Turn a switch on</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_on", target);
		}
	}

	public class SystemLogServices
	{
		private readonly IHaContext _haContext;
		public SystemLogServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Clear all log entries.</summary>
		public void Clear()
		{
			_haContext.CallService("system_log", "clear", null);
		}

		///<summary>Write log entry.</summary>
		public void Write(SystemLogWriteParameters data)
		{
			_haContext.CallService("system_log", "write", null, data);
		}

		///<summary>Write log entry.</summary>
		///<param name="message">Message to log. eg: Something went wrong</param>
		///<param name="level">Log level.</param>
		///<param name="logger">Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</param>
		public void Write(string @message, string? @level = null, string? @logger = null)
		{
			_haContext.CallService("system_log", "write", null, new SystemLogWriteParameters{Message = @message, Level = @level, Logger = @logger});
		}
	}

	public record SystemLogWriteParameters
	{
		///<summary>Message to log. eg: Something went wrong</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Log level.</summary>
		[JsonPropertyName("level")]
		public string? Level { get; init; }

		///<summary>Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</summary>
		[JsonPropertyName("logger")]
		public string? Logger { get; init; }
	}

	public class TemplateServices
	{
		private readonly IHaContext _haContext;
		public TemplateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all template entities.</summary>
		public void Reload()
		{
			_haContext.CallService("template", "reload", null);
		}
	}

	public class TimerServices
	{
		private readonly IHaContext _haContext;
		public TimerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Cancel a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Cancel(ServiceTarget target)
		{
			_haContext.CallService("timer", "cancel", target);
		}

		///<summary>Finish a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Finish(ServiceTarget target)
		{
			_haContext.CallService("timer", "finish", target);
		}

		///<summary>Pause a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("timer", "pause", target);
		}

		public void Reload()
		{
			_haContext.CallService("timer", "reload", null);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target, TimerStartParameters data)
		{
			_haContext.CallService("timer", "start", target, data);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public void Start(ServiceTarget target, string? @duration = null)
		{
			_haContext.CallService("timer", "start", target, new TimerStartParameters{Duration = @duration});
		}
	}

	public record TimerStartParameters
	{
		///<summary>Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class TtsServices
	{
		private readonly IHaContext _haContext;
		public TtsServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Remove all text-to-speech cache files and RAM cache.</summary>
		public void ClearCache()
		{
			_haContext.CallService("tts", "clear_cache", null);
		}

		///<summary>Say something using text-to-speech on a media player with cloud.</summary>
		public void CloudSay(TtsCloudSayParameters data)
		{
			_haContext.CallService("tts", "cloud_say", null, data);
		}

		///<summary>Say something using text-to-speech on a media player with cloud.</summary>
		///<param name="entityId">Name(s) of media player entities.</param>
		///<param name="message">Text to speak on devices. eg: My name is hanna</param>
		///<param name="cache">Control file cache of this message.</param>
		///<param name="language">Language to use for speech generation. eg: ru</param>
		///<param name="options">A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</param>
		public void CloudSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
		{
			_haContext.CallService("tts", "cloud_say", null, new TtsCloudSayParameters{EntityId = @entityId, Message = @message, Cache = @cache, Language = @language, Options = @options});
		}

		///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
		public void GoogleSay(TtsGoogleSayParameters data)
		{
			_haContext.CallService("tts", "google_say", null, data);
		}

		///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
		///<param name="entityId">Name(s) of media player entities.</param>
		///<param name="message">Text to speak on devices. eg: My name is hanna</param>
		///<param name="cache">Control file cache of this message.</param>
		///<param name="language">Language to use for speech generation. eg: ru</param>
		///<param name="options">A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</param>
		public void GoogleSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
		{
			_haContext.CallService("tts", "google_say", null, new TtsGoogleSayParameters{EntityId = @entityId, Message = @message, Cache = @cache, Language = @language, Options = @options});
		}
	}

	public record TtsCloudSayParameters
	{
		///<summary>Name(s) of media player entities.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Text to speak on devices. eg: My name is hanna</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Control file cache of this message.</summary>
		[JsonPropertyName("cache")]
		public bool? Cache { get; init; }

		///<summary>Language to use for speech generation. eg: ru</summary>
		[JsonPropertyName("language")]
		public string? Language { get; init; }

		///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public record TtsGoogleSayParameters
	{
		///<summary>Name(s) of media player entities.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Text to speak on devices. eg: My name is hanna</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Control file cache of this message.</summary>
		[JsonPropertyName("cache")]
		public bool? Cache { get; init; }

		///<summary>Language to use for speech generation. eg: ru</summary>
		[JsonPropertyName("language")]
		public string? Language { get; init; }

		///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class UnifiServices
	{
		private readonly IHaContext _haContext;
		public UnifiServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Try to get wireless client to reconnect to UniFi Network</summary>
		public void ReconnectClient(UnifiReconnectClientParameters data)
		{
			_haContext.CallService("unifi", "reconnect_client", null, data);
		}

		///<summary>Try to get wireless client to reconnect to UniFi Network</summary>
		///<param name="deviceId">Try reconnect client to wireless network</param>
		public void ReconnectClient(string @deviceId)
		{
			_haContext.CallService("unifi", "reconnect_client", null, new UnifiReconnectClientParameters{DeviceId = @deviceId});
		}

		///<summary>Clean up clients that has only been associated with the controller for a short period of time.</summary>
		public void RemoveClients()
		{
			_haContext.CallService("unifi", "remove_clients", null);
		}
	}

	public record UnifiReconnectClientParameters
	{
		///<summary>Try reconnect client to wireless network</summary>
		[JsonPropertyName("device_id")]
		public string? DeviceId { get; init; }
	}

	public class VacuumServices
	{
		private readonly IHaContext _haContext;
		public VacuumServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		///<param name="target">The target for this service call</param>
		public void CleanSpot(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "clean_spot", target);
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		///<param name="target">The target for this service call</param>
		public void Locate(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "locate", target);
		}

		///<summary>Pause the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "pause", target);
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		///<param name="target">The target for this service call</param>
		public void ReturnToBase(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "return_to_base", target);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(ServiceTarget target, VacuumSendCommandParameters data)
		{
			_haContext.CallService("vacuum", "send_command", target, data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public void SendCommand(ServiceTarget target, string @command, object? @params = null)
		{
			_haContext.CallService("vacuum", "send_command", target, new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanSpeed(ServiceTarget target, VacuumSetFanSpeedParameters data)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public void SetFanSpeed(ServiceTarget target, string @fanSpeed)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start", target);
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void StartPause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start_pause", target);
		}

		///<summary>Stop the current cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Stop(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "stop", target);
		}

		public void Toggle()
		{
			_haContext.CallService("vacuum", "toggle", null);
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_off", target);
		}

		///<summary>Start a new cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_on", target);
		}
	}

	public record VacuumSendCommandParameters
	{
		///<summary>Command to execute. eg: set_dnd_timer</summary>
		[JsonPropertyName("command")]
		public string? Command { get; init; }

		///<summary>Parameters for the command. eg: { "key": "value" }</summary>
		[JsonPropertyName("params")]
		public object? Params { get; init; }
	}

	public record VacuumSetFanSpeedParameters
	{
		///<summary>Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</summary>
		[JsonPropertyName("fan_speed")]
		public string? FanSpeed { get; init; }
	}

	public class VarServices
	{
		private readonly IHaContext _haContext;
		public VarServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set attributes of a variable entity.</summary>
		public void Set(VarSetParameters data)
		{
			_haContext.CallService("var", "set", null, data);
		}

		///<summary>Set attributes of a variable entity.</summary>
		///<param name="entityId">Entity id of the variable whose value will be set. eg: var.x</param>
		///<param name="value">The new value for the variable entity. eg: 13</param>
		///<param name="valueTemplate">The new value template for the variable entity. eg: {{ input_boolean.foo }}</param>
		///<param name="trackedEntityId">The new list of entities for the variable entity to track. eg: input_boolean.bar</param>
		///<param name="trackedEventType">The new list of event types for the variable entity to track. eg: sunset</param>
		///<param name="query">An SQL QUERY string, should return 1 result at most. eg: SELECT COUNT(*) AS todays_diaper_count FROM events WHERE event_type = 'diaper_event' AND time_fired BETWEEN DATETIME('now', 'start of day') and DATETIME('now');</param>
		///<param name="column">The SQL COLUMN to select from the result of the SQL QUERY. eg: todays_diaper_count</param>
		///<param name="restore">The new restore value for the variable entity. eg: False</param>
		///<param name="forceUpdate">The new force_update value for the variable entity. eg: True</param>
		///<param name="unitOfMeasurement">The new unit of measurement for the variable entity. eg: ounces</param>
		///<param name="icon">The new icon for the variable entity. eg: mdi:baby-bottle-outline</param>
		///<param name="iconTemplate">The new icon template for the variable entity.</param>
		///<param name="entityPicture">The new picture for the variable entity. eg: local/pic.png</param>
		///<param name="entityPictureTemplate">The new picture template for the variable entity.</param>
		public void Set(object? @entityId = null, object? @value = null, object? @valueTemplate = null, object? @trackedEntityId = null, object? @trackedEventType = null, object? @query = null, object? @column = null, object? @restore = null, object? @forceUpdate = null, object? @unitOfMeasurement = null, object? @icon = null, object? @iconTemplate = null, object? @entityPicture = null, object? @entityPictureTemplate = null)
		{
			_haContext.CallService("var", "set", null, new VarSetParameters{EntityId = @entityId, Value = @value, ValueTemplate = @valueTemplate, TrackedEntityId = @trackedEntityId, TrackedEventType = @trackedEventType, Query = @query, Column = @column, Restore = @restore, ForceUpdate = @forceUpdate, UnitOfMeasurement = @unitOfMeasurement, Icon = @icon, IconTemplate = @iconTemplate, EntityPicture = @entityPicture, EntityPictureTemplate = @entityPictureTemplate});
		}

		///<summary>Force a variable to update its state and atttributes.</summary>
		public void Update(VarUpdateParameters data)
		{
			_haContext.CallService("var", "update", null, data);
		}

		///<summary>Force a variable to update its state and atttributes.</summary>
		///<param name="entityId">Entity id of the variable that will be updated. eg: var.x</param>
		public void Update(object? @entityId = null)
		{
			_haContext.CallService("var", "update", null, new VarUpdateParameters{EntityId = @entityId});
		}
	}

	public record VarSetParameters
	{
		///<summary>Entity id of the variable whose value will be set. eg: var.x</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>The new value for the variable entity. eg: 13</summary>
		[JsonPropertyName("value")]
		public object? Value { get; init; }

		///<summary>The new value template for the variable entity. eg: {{ input_boolean.foo }}</summary>
		[JsonPropertyName("value_template")]
		public object? ValueTemplate { get; init; }

		///<summary>The new list of entities for the variable entity to track. eg: input_boolean.bar</summary>
		[JsonPropertyName("tracked_entity_id")]
		public object? TrackedEntityId { get; init; }

		///<summary>The new list of event types for the variable entity to track. eg: sunset</summary>
		[JsonPropertyName("tracked_event_type")]
		public object? TrackedEventType { get; init; }

		///<summary>An SQL QUERY string, should return 1 result at most. eg: SELECT COUNT(*) AS todays_diaper_count FROM events WHERE event_type = 'diaper_event' AND time_fired BETWEEN DATETIME('now', 'start of day') and DATETIME('now');</summary>
		[JsonPropertyName("query")]
		public object? Query { get; init; }

		///<summary>The SQL COLUMN to select from the result of the SQL QUERY. eg: todays_diaper_count</summary>
		[JsonPropertyName("column")]
		public object? Column { get; init; }

		///<summary>The new restore value for the variable entity. eg: False</summary>
		[JsonPropertyName("restore")]
		public object? Restore { get; init; }

		///<summary>The new force_update value for the variable entity. eg: True</summary>
		[JsonPropertyName("force_update")]
		public object? ForceUpdate { get; init; }

		///<summary>The new unit of measurement for the variable entity. eg: ounces</summary>
		[JsonPropertyName("unit_of_measurement")]
		public object? UnitOfMeasurement { get; init; }

		///<summary>The new icon for the variable entity. eg: mdi:baby-bottle-outline</summary>
		[JsonPropertyName("icon")]
		public object? Icon { get; init; }

		///<summary>The new icon template for the variable entity.</summary>
		[JsonPropertyName("icon_template")]
		public object? IconTemplate { get; init; }

		///<summary>The new picture for the variable entity. eg: local/pic.png</summary>
		[JsonPropertyName("entity_picture")]
		public object? EntityPicture { get; init; }

		///<summary>The new picture template for the variable entity.</summary>
		[JsonPropertyName("entity_picture_template")]
		public object? EntityPictureTemplate { get; init; }
	}

	public record VarUpdateParameters
	{
		///<summary>Entity id of the variable that will be updated. eg: var.x</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }
	}

	public class VariableServices
	{
		private readonly IHaContext _haContext;
		public VariableServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Update a variables value and/or its attributes.</summary>
		public void SetVariable(VariableSetVariableParameters data)
		{
			_haContext.CallService("variable", "set_variable", null, data);
		}

		///<summary>Update a variables value and/or its attributes.</summary>
		///<param name="variable">string (required) The name of the variable to update</param>
		///<param name="value">any (optional) New value to set</param>
		///<param name="attributes">dictionary (optional) Attributes to set or update</param>
		///<param name="replaceAttributes">boolean ( optional ) Replace or merge current attributes (default false = merge)</param>
		public void SetVariable(object? @variable = null, object? @value = null, object? @attributes = null, object? @replaceAttributes = null)
		{
			_haContext.CallService("variable", "set_variable", null, new VariableSetVariableParameters{Variable = @variable, Value = @value, Attributes = @attributes, ReplaceAttributes = @replaceAttributes});
		}
	}

	public record VariableSetVariableParameters
	{
		///<summary>string (required) The name of the variable to update</summary>
		[JsonPropertyName("variable")]
		public object? Variable { get; init; }

		///<summary>any (optional) New value to set</summary>
		[JsonPropertyName("value")]
		public object? Value { get; init; }

		///<summary>dictionary (optional) Attributes to set or update</summary>
		[JsonPropertyName("attributes")]
		public object? Attributes { get; init; }

		///<summary>boolean ( optional ) Replace or merge current attributes (default false = merge)</summary>
		[JsonPropertyName("replace_attributes")]
		public object? ReplaceAttributes { get; init; }
	}

	public class WakeOnLanServices
	{
		private readonly IHaContext _haContext;
		public WakeOnLanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send a 'magic packet' to wake up a device with 'Wake-On-LAN' capabilities.</summary>
		public void SendMagicPacket(WakeOnLanSendMagicPacketParameters data)
		{
			_haContext.CallService("wake_on_lan", "send_magic_packet", null, data);
		}

		///<summary>Send a 'magic packet' to wake up a device with 'Wake-On-LAN' capabilities.</summary>
		///<param name="mac">MAC address of the device to wake up. eg: aa:bb:cc:dd:ee:ff</param>
		///<param name="broadcastAddress">Broadcast IP where to send the magic packet. eg: 192.168.255.255</param>
		///<param name="broadcastPort">Port where to send the magic packet.</param>
		public void SendMagicPacket(string @mac, string? @broadcastAddress = null, long? @broadcastPort = null)
		{
			_haContext.CallService("wake_on_lan", "send_magic_packet", null, new WakeOnLanSendMagicPacketParameters{Mac = @mac, BroadcastAddress = @broadcastAddress, BroadcastPort = @broadcastPort});
		}
	}

	public record WakeOnLanSendMagicPacketParameters
	{
		///<summary>MAC address of the device to wake up. eg: aa:bb:cc:dd:ee:ff</summary>
		[JsonPropertyName("mac")]
		public string? Mac { get; init; }

		///<summary>Broadcast IP where to send the magic packet. eg: 192.168.255.255</summary>
		[JsonPropertyName("broadcast_address")]
		public string? BroadcastAddress { get; init; }

		///<summary>Port where to send the magic packet.</summary>
		[JsonPropertyName("broadcast_port")]
		public long? BroadcastPort { get; init; }
	}

	public class YamahaServices
	{
		private readonly IHaContext _haContext;
		public YamahaServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Enable or disable an output port</summary>
		///<param name="target">The target for this service call</param>
		public void EnableOutput(ServiceTarget target, YamahaEnableOutputParameters data)
		{
			_haContext.CallService("yamaha", "enable_output", target, data);
		}

		///<summary>Enable or disable an output port</summary>
		///<param name="target">The target for this service call</param>
		///<param name="port">Name of port to enable/disable. eg: hdmi1</param>
		///<param name="enabled">Indicate if port should be enabled or not.</param>
		public void EnableOutput(ServiceTarget target, string @port, bool @enabled)
		{
			_haContext.CallService("yamaha", "enable_output", target, new YamahaEnableOutputParameters{Port = @port, Enabled = @enabled});
		}

		///<summary>Control the cursor in a menu</summary>
		///<param name="target">The target for this service call</param>
		public void MenuCursor(ServiceTarget target, YamahaMenuCursorParameters data)
		{
			_haContext.CallService("yamaha", "menu_cursor", target, data);
		}

		///<summary>Control the cursor in a menu</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cursor">Name of the cursor key to press ('up', 'down', 'left', 'right', 'select', 'return') eg: down</param>
		public void MenuCursor(ServiceTarget target, string? @cursor = null)
		{
			_haContext.CallService("yamaha", "menu_cursor", target, new YamahaMenuCursorParameters{Cursor = @cursor});
		}

		///<summary>Select a scene on the receiver</summary>
		///<param name="target">The target for this service call</param>
		public void SelectScene(ServiceTarget target, YamahaSelectSceneParameters data)
		{
			_haContext.CallService("yamaha", "select_scene", target, data);
		}

		///<summary>Select a scene on the receiver</summary>
		///<param name="target">The target for this service call</param>
		///<param name="scene">Name of the scene. Standard for RX-V437 is 'BD/DVD Movie Viewing', 'TV Viewing', 'NET Audio Listening' or 'Radio Listening' eg: TV Viewing</param>
		public void SelectScene(ServiceTarget target, string @scene)
		{
			_haContext.CallService("yamaha", "select_scene", target, new YamahaSelectSceneParameters{Scene = @scene});
		}
	}

	public record YamahaEnableOutputParameters
	{
		///<summary>Name of port to enable/disable. eg: hdmi1</summary>
		[JsonPropertyName("port")]
		public string? Port { get; init; }

		///<summary>Indicate if port should be enabled or not.</summary>
		[JsonPropertyName("enabled")]
		public bool? Enabled { get; init; }
	}

	public record YamahaMenuCursorParameters
	{
		///<summary>Name of the cursor key to press ('up', 'down', 'left', 'right', 'select', 'return') eg: down</summary>
		[JsonPropertyName("cursor")]
		public string? Cursor { get; init; }
	}

	public record YamahaSelectSceneParameters
	{
		///<summary>Name of the scene. Standard for RX-V437 is 'BD/DVD Movie Viewing', 'TV Viewing', 'NET Audio Listening' or 'Radio Listening' eg: TV Viewing</summary>
		[JsonPropertyName("scene")]
		public string? Scene { get; init; }
	}

	public class YeelightServices
	{
		private readonly IHaContext _haContext;
		public YeelightServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Turns the light on to the specified brightness and sets a timer to turn it back off after the given number of minutes. If the light is off, Set a color scene, if light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		public void SetAutoDelayOffScene(ServiceTarget target, YeelightSetAutoDelayOffSceneParameters data)
		{
			_haContext.CallService("yeelight", "set_auto_delay_off_scene", target, data);
		}

		///<summary>Turns the light on to the specified brightness and sets a timer to turn it back off after the given number of minutes. If the light is off, Set a color scene, if light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="minutes">The time to wait before automatically turning the light off.</param>
		///<param name="brightness">The brightness value to set.</param>
		public void SetAutoDelayOffScene(ServiceTarget target, long? @minutes = null, long? @brightness = null)
		{
			_haContext.CallService("yeelight", "set_auto_delay_off_scene", target, new YeelightSetAutoDelayOffSceneParameters{Minutes = @minutes, Brightness = @brightness});
		}

		///<summary>starts a color flow. If the light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		public void SetColorFlowScene(ServiceTarget target, YeelightSetColorFlowSceneParameters data)
		{
			_haContext.CallService("yeelight", "set_color_flow_scene", target, data);
		}

		///<summary>starts a color flow. If the light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="count">The number of times to run this flow (0 to run forever).</param>
		///<param name="action">The action to take after the flow stops.</param>
		///<param name="transitions">Array of transitions, for desired effect. Examples https://yeelight.readthedocs.io/en/stable/flow.html eg: [{ "TemperatureTransition": [1900, 1000, 80] }, { "TemperatureTransition": [1900, 1000, 10] }]</param>
		public void SetColorFlowScene(ServiceTarget target, long? @count = null, string? @action = null, object? @transitions = null)
		{
			_haContext.CallService("yeelight", "set_color_flow_scene", target, new YeelightSetColorFlowSceneParameters{Count = @count, Action = @action, Transitions = @transitions});
		}

		///<summary>Changes the light to the specified RGB color and brightness. If the light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		public void SetColorScene(ServiceTarget target, YeelightSetColorSceneParameters data)
		{
			_haContext.CallService("yeelight", "set_color_scene", target, data);
		}

		///<summary>Changes the light to the specified RGB color and brightness. If the light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="brightness">The brightness value to set.</param>
		public void SetColorScene(ServiceTarget target, object? @rgbColor = null, long? @brightness = null)
		{
			_haContext.CallService("yeelight", "set_color_scene", target, new YeelightSetColorSceneParameters{RgbColor = @rgbColor, Brightness = @brightness});
		}

		///<summary>Changes the light to the specified color temperature. If the light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		public void SetColorTempScene(ServiceTarget target, YeelightSetColorTempSceneParameters data)
		{
			_haContext.CallService("yeelight", "set_color_temp_scene", target, data);
		}

		///<summary>Changes the light to the specified color temperature. If the light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">The brightness value to set.</param>
		public void SetColorTempScene(ServiceTarget target, long? @kelvin = null, long? @brightness = null)
		{
			_haContext.CallService("yeelight", "set_color_temp_scene", target, new YeelightSetColorTempSceneParameters{Kelvin = @kelvin, Brightness = @brightness});
		}

		///<summary>Changes the light to the specified HSV color and brightness. If the light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHsvScene(ServiceTarget target, YeelightSetHsvSceneParameters data)
		{
			_haContext.CallService("yeelight", "set_hsv_scene", target, data);
		}

		///<summary>Changes the light to the specified HSV color and brightness. If the light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-359 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="brightness">The brightness value to set.</param>
		public void SetHsvScene(ServiceTarget target, object? @hsColor = null, long? @brightness = null)
		{
			_haContext.CallService("yeelight", "set_hsv_scene", target, new YeelightSetHsvSceneParameters{HsColor = @hsColor, Brightness = @brightness});
		}

		///<summary>Set a operation mode.</summary>
		///<param name="target">The target for this service call</param>
		public void SetMode(ServiceTarget target, YeelightSetModeParameters data)
		{
			_haContext.CallService("yeelight", "set_mode", target, data);
		}

		///<summary>Set a operation mode.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mode">Operation mode.</param>
		public void SetMode(ServiceTarget target, string @mode)
		{
			_haContext.CallService("yeelight", "set_mode", target, new YeelightSetModeParameters{Mode = @mode});
		}

		///<summary>Enable or disable music_mode</summary>
		///<param name="target">The target for this service call</param>
		public void SetMusicMode(ServiceTarget target, YeelightSetMusicModeParameters data)
		{
			_haContext.CallService("yeelight", "set_music_mode", target, data);
		}

		///<summary>Enable or disable music_mode</summary>
		///<param name="target">The target for this service call</param>
		///<param name="musicMode">Use true or false to enable / disable music_mode</param>
		public void SetMusicMode(ServiceTarget target, bool @musicMode)
		{
			_haContext.CallService("yeelight", "set_music_mode", target, new YeelightSetMusicModeParameters{MusicMode = @musicMode});
		}

		///<summary>Start a custom flow, using transitions from https://yeelight.readthedocs.io/en/stable/yeelight.html#flow-objects</summary>
		///<param name="target">The target for this service call</param>
		public void StartFlow(ServiceTarget target, YeelightStartFlowParameters data)
		{
			_haContext.CallService("yeelight", "start_flow", target, data);
		}

		///<summary>Start a custom flow, using transitions from https://yeelight.readthedocs.io/en/stable/yeelight.html#flow-objects</summary>
		///<param name="target">The target for this service call</param>
		///<param name="count">The number of times to run this flow (0 to run forever).</param>
		///<param name="action">The action to take after the flow stops.</param>
		///<param name="transitions">Array of transitions, for desired effect. Examples https://yeelight.readthedocs.io/en/stable/flow.html eg: [{ "TemperatureTransition": [1900, 1000, 80] }, { "TemperatureTransition": [1900, 1000, 10] }]</param>
		public void StartFlow(ServiceTarget target, long? @count = null, string? @action = null, object? @transitions = null)
		{
			_haContext.CallService("yeelight", "start_flow", target, new YeelightStartFlowParameters{Count = @count, Action = @action, Transitions = @transitions});
		}
	}

	public record YeelightSetAutoDelayOffSceneParameters
	{
		///<summary>The time to wait before automatically turning the light off.</summary>
		[JsonPropertyName("minutes")]
		public long? Minutes { get; init; }

		///<summary>The brightness value to set.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }
	}

	public record YeelightSetColorFlowSceneParameters
	{
		///<summary>The number of times to run this flow (0 to run forever).</summary>
		[JsonPropertyName("count")]
		public long? Count { get; init; }

		///<summary>The action to take after the flow stops.</summary>
		[JsonPropertyName("action")]
		public string? Action { get; init; }

		///<summary>Array of transitions, for desired effect. Examples https://yeelight.readthedocs.io/en/stable/flow.html eg: [{ "TemperatureTransition": [1900, 1000, 80] }, { "TemperatureTransition": [1900, 1000, 10] }]</summary>
		[JsonPropertyName("transitions")]
		public object? Transitions { get; init; }
	}

	public record YeelightSetColorSceneParameters
	{
		///<summary>Color for the light in RGB-format. eg: [255, 100, 100]</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>The brightness value to set.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }
	}

	public record YeelightSetColorTempSceneParameters
	{
		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>The brightness value to set.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }
	}

	public record YeelightSetHsvSceneParameters
	{
		///<summary>Color for the light in hue/sat format. Hue is 0-359 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>The brightness value to set.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }
	}

	public record YeelightSetModeParameters
	{
		///<summary>Operation mode.</summary>
		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public record YeelightSetMusicModeParameters
	{
		///<summary>Use true or false to enable / disable music_mode</summary>
		[JsonPropertyName("music_mode")]
		public bool? MusicMode { get; init; }
	}

	public record YeelightStartFlowParameters
	{
		///<summary>The number of times to run this flow (0 to run forever).</summary>
		[JsonPropertyName("count")]
		public long? Count { get; init; }

		///<summary>The action to take after the flow stops.</summary>
		[JsonPropertyName("action")]
		public string? Action { get; init; }

		///<summary>Array of transitions, for desired effect. Examples https://yeelight.readthedocs.io/en/stable/flow.html eg: [{ "TemperatureTransition": [1900, 1000, 80] }, { "TemperatureTransition": [1900, 1000, 10] }]</summary>
		[JsonPropertyName("transitions")]
		public object? Transitions { get; init; }
	}

	public class ZoneServices
	{
		private readonly IHaContext _haContext;
		public ZoneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the YAML-based zone configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("zone", "reload", null);
		}
	}

	public class ZwaveJsServices
	{
		private readonly IHaContext _haContext;
		public ZwaveJsServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Allow for bulk setting partial parameters. Useful when multiple partial parameters have to be set at the same time.</summary>
		///<param name="target">The target for this service call</param>
		public void BulkSetPartialConfigParameters(ServiceTarget target, ZwaveJsBulkSetPartialConfigParametersParameters data)
		{
			_haContext.CallService("zwave_js", "bulk_set_partial_config_parameters", target, data);
		}

		///<summary>Allow for bulk setting partial parameters. Useful when multiple partial parameters have to be set at the same time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="parameter">The id of the configuration parameter you want to configure. eg: 9</param>
		///<param name="value">The new value(s) to set for this configuration parameter. Can either be a raw integer value to represent the bulk change or a mapping where the key is the bitmask (either in hex or integer form) and the value is the new value you want to set for that partial parameter. eg: {"0x1":1,"0x10":1,"0x20":1,"0x40":1}</param>
		public void BulkSetPartialConfigParameters(ServiceTarget target, string @parameter, object @value)
		{
			_haContext.CallService("zwave_js", "bulk_set_partial_config_parameters", target, new ZwaveJsBulkSetPartialConfigParametersParameters{Parameter = @parameter, Value = @value});
		}

		///<summary>Allow for changing any value that Z-Wave JS recognizes on multiple Z-Wave devices using multicast, so all devices receive the message simultaneously. This service has minimal validation so only use this service if you know what you are doing.</summary>
		///<param name="target">The target for this service call</param>
		public void MulticastSetValue(ServiceTarget target, ZwaveJsMulticastSetValueParameters data)
		{
			_haContext.CallService("zwave_js", "multicast_set_value", target, data);
		}

		///<summary>Allow for changing any value that Z-Wave JS recognizes on multiple Z-Wave devices using multicast, so all devices receive the message simultaneously. This service has minimal validation so only use this service if you know what you are doing.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="broadcast">Whether command should be broadcast to all devices on the network. eg: True</param>
		///<param name="commandClass">The ID of the command class for the value. eg: 117</param>
		///<param name="endpoint">The endpoint for the value. eg: 1</param>
		///<param name="property">The ID of the property for the value. eg: currentValue</param>
		///<param name="propertyKey">The ID of the property key for the value eg: 1</param>
		///<param name="options">Set value options map. Refer to the Z-Wave JS documentation for more information on what options can be set.</param>
		///<param name="value">The new value to set. eg: ffbb99</param>
		public void MulticastSetValue(ServiceTarget target, string @commandClass, string @property, object @value, bool? @broadcast = null, string? @endpoint = null, string? @propertyKey = null, object? @options = null)
		{
			_haContext.CallService("zwave_js", "multicast_set_value", target, new ZwaveJsMulticastSetValueParameters{Broadcast = @broadcast, CommandClass = @commandClass, Endpoint = @endpoint, Property = @property, PropertyKey = @propertyKey, Options = @options, Value = @value});
		}

		///<summary>Forces Z-Wave JS to try to reach a node. This can be used to update the status of the node in Z-Wave JS when you think it doesn't accurately reflect reality, e.g. reviving a failed/dead node or marking the node as asleep.</summary>
		///<param name="target">The target for this service call</param>
		public void Ping(ServiceTarget target)
		{
			_haContext.CallService("zwave_js", "ping", target);
		}

		///<summary>Force update value(s) for a Z-Wave entity</summary>
		public void RefreshValue(ZwaveJsRefreshValueParameters data)
		{
			_haContext.CallService("zwave_js", "refresh_value", null, data);
		}

		///<summary>Force update value(s) for a Z-Wave entity</summary>
		///<param name="entityId">Entity whose value(s) should be refreshed eg: sensor.family_room_motion</param>
		///<param name="refreshAllValues">Whether to refresh all values (true) or just the primary value (false)</param>
		public void RefreshValue(string @entityId, bool? @refreshAllValues = null)
		{
			_haContext.CallService("zwave_js", "refresh_value", null, new ZwaveJsRefreshValueParameters{EntityId = @entityId, RefreshAllValues = @refreshAllValues});
		}

		///<summary>Resets the meter(s) on a node.</summary>
		///<param name="target">The target for this service call</param>
		public void ResetMeter(ServiceTarget target, ZwaveJsResetMeterParameters data)
		{
			_haContext.CallService("zwave_js", "reset_meter", target, data);
		}

		///<summary>Resets the meter(s) on a node.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="meterType">The type of meter to reset. Not all meters support the ability to pick a meter type to reset. eg: 1</param>
		///<param name="value">The value that meter(s) should be reset to. Not all meters support the ability to be reset to a specific value. eg: 5</param>
		public void ResetMeter(ServiceTarget target, string? @meterType = null, string? @value = null)
		{
			_haContext.CallService("zwave_js", "reset_meter", target, new ZwaveJsResetMeterParameters{MeterType = @meterType, Value = @value});
		}

		///<summary>Allow for changing configuration parameters of your Z-Wave devices.</summary>
		///<param name="target">The target for this service call</param>
		public void SetConfigParameter(ServiceTarget target, ZwaveJsSetConfigParameterParameters data)
		{
			_haContext.CallService("zwave_js", "set_config_parameter", target, data);
		}

		///<summary>Allow for changing configuration parameters of your Z-Wave devices.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="parameter">The (name or id of the) configuration parameter you want to configure. eg: Minimum brightness level</param>
		///<param name="value">The new value to set for this configuration parameter. eg: 5</param>
		///<param name="bitmask">Target a specific bitmask (see the documentation for more information).</param>
		public void SetConfigParameter(ServiceTarget target, string @parameter, string @value, string? @bitmask = null)
		{
			_haContext.CallService("zwave_js", "set_config_parameter", target, new ZwaveJsSetConfigParameterParameters{Parameter = @parameter, Value = @value, Bitmask = @bitmask});
		}

		///<summary>Allow for changing any value that Z-Wave JS recognizes on a Z-Wave device. This service has minimal validation so only use this service if you know what you are doing.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, ZwaveJsSetValueParameters data)
		{
			_haContext.CallService("zwave_js", "set_value", target, data);
		}

		///<summary>Allow for changing any value that Z-Wave JS recognizes on a Z-Wave device. This service has minimal validation so only use this service if you know what you are doing.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="commandClass">The ID of the command class for the value. eg: 117</param>
		///<param name="endpoint">The endpoint for the value. eg: 1</param>
		///<param name="property">The ID of the property for the value. eg: currentValue</param>
		///<param name="propertyKey">The ID of the property key for the value eg: 1</param>
		///<param name="value">The new value to set. eg: ffbb99</param>
		///<param name="options">Set value options map. Refer to the Z-Wave JS documentation for more information on what options can be set.</param>
		///<param name="waitForResult">Whether or not to wait for a response from the node. If not included in the payload, the integration will decide whether to wait or not. If set to `true`, note that the service call can take a while if setting a value on an asleep battery device.</param>
		public void SetValue(ServiceTarget target, string @commandClass, string @property, object @value, string? @endpoint = null, string? @propertyKey = null, object? @options = null, bool? @waitForResult = null)
		{
			_haContext.CallService("zwave_js", "set_value", target, new ZwaveJsSetValueParameters{CommandClass = @commandClass, Endpoint = @endpoint, Property = @property, PropertyKey = @propertyKey, Value = @value, Options = @options, WaitForResult = @waitForResult});
		}
	}

	public record ZwaveJsBulkSetPartialConfigParametersParameters
	{
		///<summary>The id of the configuration parameter you want to configure. eg: 9</summary>
		[JsonPropertyName("parameter")]
		public string? Parameter { get; init; }

		///<summary>The new value(s) to set for this configuration parameter. Can either be a raw integer value to represent the bulk change or a mapping where the key is the bitmask (either in hex or integer form) and the value is the new value you want to set for that partial parameter. eg: {"0x1":1,"0x10":1,"0x20":1,"0x40":1}</summary>
		[JsonPropertyName("value")]
		public object? Value { get; init; }
	}

	public record ZwaveJsMulticastSetValueParameters
	{
		///<summary>Whether command should be broadcast to all devices on the network. eg: True</summary>
		[JsonPropertyName("broadcast")]
		public bool? Broadcast { get; init; }

		///<summary>The ID of the command class for the value. eg: 117</summary>
		[JsonPropertyName("command_class")]
		public string? CommandClass { get; init; }

		///<summary>The endpoint for the value. eg: 1</summary>
		[JsonPropertyName("endpoint")]
		public string? Endpoint { get; init; }

		///<summary>The ID of the property for the value. eg: currentValue</summary>
		[JsonPropertyName("property")]
		public string? Property { get; init; }

		///<summary>The ID of the property key for the value eg: 1</summary>
		[JsonPropertyName("property_key")]
		public string? PropertyKey { get; init; }

		///<summary>Set value options map. Refer to the Z-Wave JS documentation for more information on what options can be set.</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }

		///<summary>The new value to set. eg: ffbb99</summary>
		[JsonPropertyName("value")]
		public object? Value { get; init; }
	}

	public record ZwaveJsRefreshValueParameters
	{
		///<summary>Entity whose value(s) should be refreshed eg: sensor.family_room_motion</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Whether to refresh all values (true) or just the primary value (false)</summary>
		[JsonPropertyName("refresh_all_values")]
		public bool? RefreshAllValues { get; init; }
	}

	public record ZwaveJsResetMeterParameters
	{
		///<summary>The type of meter to reset. Not all meters support the ability to pick a meter type to reset. eg: 1</summary>
		[JsonPropertyName("meter_type")]
		public string? MeterType { get; init; }

		///<summary>The value that meter(s) should be reset to. Not all meters support the ability to be reset to a specific value. eg: 5</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public record ZwaveJsSetConfigParameterParameters
	{
		///<summary>The (name or id of the) configuration parameter you want to configure. eg: Minimum brightness level</summary>
		[JsonPropertyName("parameter")]
		public string? Parameter { get; init; }

		///<summary>The new value to set for this configuration parameter. eg: 5</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }

		///<summary>Target a specific bitmask (see the documentation for more information).</summary>
		[JsonPropertyName("bitmask")]
		public string? Bitmask { get; init; }
	}

	public record ZwaveJsSetValueParameters
	{
		///<summary>The ID of the command class for the value. eg: 117</summary>
		[JsonPropertyName("command_class")]
		public string? CommandClass { get; init; }

		///<summary>The endpoint for the value. eg: 1</summary>
		[JsonPropertyName("endpoint")]
		public string? Endpoint { get; init; }

		///<summary>The ID of the property for the value. eg: currentValue</summary>
		[JsonPropertyName("property")]
		public string? Property { get; init; }

		///<summary>The ID of the property key for the value eg: 1</summary>
		[JsonPropertyName("property_key")]
		public string? PropertyKey { get; init; }

		///<summary>The new value to set. eg: ffbb99</summary>
		[JsonPropertyName("value")]
		public object? Value { get; init; }

		///<summary>Set value options map. Refer to the Z-Wave JS documentation for more information on what options can be set.</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }

		///<summary>Whether or not to wait for a response from the node. If not included in the payload, the integration will decide whether to wait or not. If set to `true`, note that the service call can take a while if setting a value on an asleep battery device.</summary>
		[JsonPropertyName("wait_for_result")]
		public bool? WaitForResult { get; init; }
	}

	public static class AlarmControlPanelEntityExtensionMethods
	{
		///<summary>Send the alarm the command for arm away.</summary>
		public static void AlarmArmAway(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			target.CallService("alarm_arm_away", data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		public static void AlarmArmAway(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			target.CallService("alarm_arm_away", data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public static void AlarmArmAway(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_away", new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public static void AlarmArmAway(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_away", new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		public static void AlarmArmCustomBypass(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			target.CallService("alarm_arm_custom_bypass", data);
		}

		///<summary>Send arm custom bypass command.</summary>
		public static void AlarmArmCustomBypass(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			target.CallService("alarm_arm_custom_bypass", data);
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public static void AlarmArmCustomBypass(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_custom_bypass", new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public static void AlarmArmCustomBypass(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_custom_bypass", new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		public static void AlarmArmHome(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			target.CallService("alarm_arm_home", data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		public static void AlarmArmHome(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			target.CallService("alarm_arm_home", data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public static void AlarmArmHome(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_home", new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public static void AlarmArmHome(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_home", new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		public static void AlarmArmNight(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmNightParameters data)
		{
			target.CallService("alarm_arm_night", data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		public static void AlarmArmNight(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmNightParameters data)
		{
			target.CallService("alarm_arm_night", data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public static void AlarmArmNight(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_night", new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public static void AlarmArmNight(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_night", new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		public static void AlarmArmVacation(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			target.CallService("alarm_arm_vacation", data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		public static void AlarmArmVacation(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			target.CallService("alarm_arm_vacation", data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public static void AlarmArmVacation(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_vacation", new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public static void AlarmArmVacation(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_vacation", new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		public static void AlarmDisarm(this AlarmControlPanelEntity target, AlarmControlPanelAlarmDisarmParameters data)
		{
			target.CallService("alarm_disarm", data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		public static void AlarmDisarm(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmDisarmParameters data)
		{
			target.CallService("alarm_disarm", data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public static void AlarmDisarm(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_disarm", new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public static void AlarmDisarm(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_disarm", new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		public static void AlarmTrigger(this AlarmControlPanelEntity target, AlarmControlPanelAlarmTriggerParameters data)
		{
			target.CallService("alarm_trigger", data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		public static void AlarmTrigger(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmTriggerParameters data)
		{
			target.CallService("alarm_trigger", data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public static void AlarmTrigger(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_trigger", new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public static void AlarmTrigger(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_trigger", new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}
	}

	public static class AlertEntityExtensionMethods
	{
		///<summary>Toggle alert's notifications.</summary>
		public static void Toggle(this AlertEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle alert's notifications.</summary>
		public static void Toggle(this IEnumerable<AlertEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Silence alert's notifications.</summary>
		public static void TurnOff(this AlertEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Silence alert's notifications.</summary>
		public static void TurnOff(this IEnumerable<AlertEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Reset alert's notifications.</summary>
		public static void TurnOn(this AlertEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Reset alert's notifications.</summary>
		public static void TurnOn(this IEnumerable<AlertEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class AndroidtvEntityExtensionMethods
	{
		///<summary>Send an ADB command to an Android TV / Fire TV device.</summary>
		public static void AdbCommand(this MediaPlayerEntity target, AndroidtvAdbCommandParameters data)
		{
			target.CallService("adb_command", data);
		}

		///<summary>Send an ADB command to an Android TV / Fire TV device.</summary>
		public static void AdbCommand(this IEnumerable<MediaPlayerEntity> target, AndroidtvAdbCommandParameters data)
		{
			target.CallService("adb_command", data);
		}

		///<summary>Send an ADB command to an Android TV / Fire TV device.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="command">Either a key command or an ADB shell command. eg: HOME</param>
		public static void AdbCommand(this MediaPlayerEntity target, string @command)
		{
			target.CallService("adb_command", new AndroidtvAdbCommandParameters{Command = @command});
		}

		///<summary>Send an ADB command to an Android TV / Fire TV device.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="command">Either a key command or an ADB shell command. eg: HOME</param>
		public static void AdbCommand(this IEnumerable<MediaPlayerEntity> target, string @command)
		{
			target.CallService("adb_command", new AndroidtvAdbCommandParameters{Command = @command});
		}

		///<summary>Download a file from your Android TV / Fire TV device to your Home Assistant instance.</summary>
		public static void Download(this MediaPlayerEntity target, AndroidtvDownloadParameters data)
		{
			target.CallService("download", data);
		}

		///<summary>Download a file from your Android TV / Fire TV device to your Home Assistant instance.</summary>
		public static void Download(this IEnumerable<MediaPlayerEntity> target, AndroidtvDownloadParameters data)
		{
			target.CallService("download", data);
		}

		///<summary>Download a file from your Android TV / Fire TV device to your Home Assistant instance.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="devicePath">The filepath on the Android TV / Fire TV device. eg: /storage/emulated/0/Download/example.txt</param>
		///<param name="localPath">The filepath on your Home Assistant instance. eg: /config/www/example.txt</param>
		public static void Download(this MediaPlayerEntity target, string @devicePath, string @localPath)
		{
			target.CallService("download", new AndroidtvDownloadParameters{DevicePath = @devicePath, LocalPath = @localPath});
		}

		///<summary>Download a file from your Android TV / Fire TV device to your Home Assistant instance.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="devicePath">The filepath on the Android TV / Fire TV device. eg: /storage/emulated/0/Download/example.txt</param>
		///<param name="localPath">The filepath on your Home Assistant instance. eg: /config/www/example.txt</param>
		public static void Download(this IEnumerable<MediaPlayerEntity> target, string @devicePath, string @localPath)
		{
			target.CallService("download", new AndroidtvDownloadParameters{DevicePath = @devicePath, LocalPath = @localPath});
		}

		///<summary>Translate a key press on a remote into ADB 'sendevent' commands.  You must press one button on the remote within 8 seconds of calling this service.</summary>
		public static void LearnSendevent(this MediaPlayerEntity target)
		{
			target.CallService("learn_sendevent");
		}

		///<summary>Translate a key press on a remote into ADB 'sendevent' commands.  You must press one button on the remote within 8 seconds of calling this service.</summary>
		public static void LearnSendevent(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("learn_sendevent");
		}

		///<summary>Upload a file from your Home Assistant instance to an Android TV / Fire TV device.</summary>
		public static void Upload(this MediaPlayerEntity target, AndroidtvUploadParameters data)
		{
			target.CallService("upload", data);
		}

		///<summary>Upload a file from your Home Assistant instance to an Android TV / Fire TV device.</summary>
		public static void Upload(this IEnumerable<MediaPlayerEntity> target, AndroidtvUploadParameters data)
		{
			target.CallService("upload", data);
		}

		///<summary>Upload a file from your Home Assistant instance to an Android TV / Fire TV device.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="devicePath">The filepath on the Android TV / Fire TV device. eg: /storage/emulated/0/Download/example.txt</param>
		///<param name="localPath">The filepath on your Home Assistant instance. eg: /config/www/example.txt</param>
		public static void Upload(this MediaPlayerEntity target, string @devicePath, string @localPath)
		{
			target.CallService("upload", new AndroidtvUploadParameters{DevicePath = @devicePath, LocalPath = @localPath});
		}

		///<summary>Upload a file from your Home Assistant instance to an Android TV / Fire TV device.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="devicePath">The filepath on the Android TV / Fire TV device. eg: /storage/emulated/0/Download/example.txt</param>
		///<param name="localPath">The filepath on your Home Assistant instance. eg: /config/www/example.txt</param>
		public static void Upload(this IEnumerable<MediaPlayerEntity> target, string @devicePath, string @localPath)
		{
			target.CallService("upload", new AndroidtvUploadParameters{DevicePath = @devicePath, LocalPath = @localPath});
		}
	}

	public static class AutomationEntityExtensionMethods
	{
		///<summary>Toggle (enable / disable) an automation.</summary>
		public static void Toggle(this AutomationEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle (enable / disable) an automation.</summary>
		public static void Toggle(this IEnumerable<AutomationEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Trigger the actions of an automation.</summary>
		public static void Trigger(this AutomationEntity target, AutomationTriggerParameters data)
		{
			target.CallService("trigger", data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		public static void Trigger(this IEnumerable<AutomationEntity> target, AutomationTriggerParameters data)
		{
			target.CallService("trigger", data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The AutomationEntity to call this service for</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public static void Trigger(this AutomationEntity target, bool? @skipCondition = null)
		{
			target.CallService("trigger", new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public static void Trigger(this IEnumerable<AutomationEntity> target, bool? @skipCondition = null)
		{
			target.CallService("trigger", new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		public static void TurnOff(this AutomationEntity target, AutomationTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Disable an automation.</summary>
		public static void TurnOff(this IEnumerable<AutomationEntity> target, AutomationTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The AutomationEntity to call this service for</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public static void TurnOff(this AutomationEntity target, bool? @stopActions = null)
		{
			target.CallService("turn_off", new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public static void TurnOff(this IEnumerable<AutomationEntity> target, bool? @stopActions = null)
		{
			target.CallService("turn_off", new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		public static void TurnOn(this AutomationEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Enable an automation.</summary>
		public static void TurnOn(this IEnumerable<AutomationEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class ButtonEntityExtensionMethods
	{
		///<summary>Press the button entity.</summary>
		public static void Press(this ButtonEntity target)
		{
			target.CallService("press");
		}

		///<summary>Press the button entity.</summary>
		public static void Press(this IEnumerable<ButtonEntity> target)
		{
			target.CallService("press");
		}
	}

	public static class CameraEntityExtensionMethods
	{
		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this CameraEntity target)
		{
			target.CallService("disable_motion_detection");
		}

		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this IEnumerable<CameraEntity> target)
		{
			target.CallService("disable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this CameraEntity target)
		{
			target.CallService("enable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this IEnumerable<CameraEntity> target)
		{
			target.CallService("enable_motion_detection");
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this CameraEntity target, CameraPlayStreamParameters data)
		{
			target.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this IEnumerable<CameraEntity> target, CameraPlayStreamParameters data)
		{
			target.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this CameraEntity target, string @mediaPlayer, string? @format = null)
		{
			target.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this IEnumerable<CameraEntity> target, string @mediaPlayer, string? @format = null)
		{
			target.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this CameraEntity target, CameraRecordParameters data)
		{
			target.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this IEnumerable<CameraEntity> target, CameraRecordParameters data)
		{
			target.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this CameraEntity target, string @filename, long? @duration = null, long? @lookback = null)
		{
			target.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this IEnumerable<CameraEntity> target, string @filename, long? @duration = null, long? @lookback = null)
		{
			target.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this CameraEntity target, CameraSnapshotParameters data)
		{
			target.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this IEnumerable<CameraEntity> target, CameraSnapshotParameters data)
		{
			target.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this CameraEntity target, string @filename)
		{
			target.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this IEnumerable<CameraEntity> target, string @filename)
		{
			target.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this CameraEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this IEnumerable<CameraEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this CameraEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this IEnumerable<CameraEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class ClimateEntityExtensionMethods
	{
		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this ClimateEntity target, ClimateSetAuxHeatParameters data)
		{
			target.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, ClimateSetAuxHeatParameters data)
		{
			target.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this ClimateEntity target, bool @auxHeat)
		{
			target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, bool @auxHeat)
		{
			target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this ClimateEntity target, ClimateSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this IEnumerable<ClimateEntity> target, ClimateSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this ClimateEntity target, string @fanMode)
		{
			target.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this IEnumerable<ClimateEntity> target, string @fanMode)
		{
			target.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this ClimateEntity target, ClimateSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this IEnumerable<ClimateEntity> target, ClimateSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this ClimateEntity target, long @humidity)
		{
			target.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this IEnumerable<ClimateEntity> target, long @humidity)
		{
			target.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this ClimateEntity target, ClimateSetHvacModeParameters data)
		{
			target.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this IEnumerable<ClimateEntity> target, ClimateSetHvacModeParameters data)
		{
			target.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this ClimateEntity target, string? @hvacMode = null)
		{
			target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this IEnumerable<ClimateEntity> target, string? @hvacMode = null)
		{
			target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this ClimateEntity target, ClimateSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this IEnumerable<ClimateEntity> target, ClimateSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this ClimateEntity target, string @presetMode)
		{
			target.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this IEnumerable<ClimateEntity> target, string @presetMode)
		{
			target.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this ClimateEntity target, ClimateSetSwingModeParameters data)
		{
			target.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this IEnumerable<ClimateEntity> target, ClimateSetSwingModeParameters data)
		{
			target.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this ClimateEntity target, string @swingMode)
		{
			target.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this IEnumerable<ClimateEntity> target, string @swingMode)
		{
			target.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this ClimateEntity target, ClimateSetTemperatureParameters data)
		{
			target.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this IEnumerable<ClimateEntity> target, ClimateSetTemperatureParameters data)
		{
			target.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this ClimateEntity target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, string? @hvacMode = null)
		{
			target.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this IEnumerable<ClimateEntity> target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, string? @hvacMode = null)
		{
			target.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this ClimateEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this IEnumerable<ClimateEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this ClimateEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this IEnumerable<ClimateEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class CoverEntityExtensionMethods
	{
		///<summary>Close all or specified cover.</summary>
		public static void CloseCover(this CoverEntity target)
		{
			target.CallService("close_cover");
		}

		///<summary>Close all or specified cover.</summary>
		public static void CloseCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("close_cover");
		}

		///<summary>Close all or specified cover tilt.</summary>
		public static void CloseCoverTilt(this CoverEntity target)
		{
			target.CallService("close_cover_tilt");
		}

		///<summary>Close all or specified cover tilt.</summary>
		public static void CloseCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("close_cover_tilt");
		}

		///<summary>Open all or specified cover.</summary>
		public static void OpenCover(this CoverEntity target)
		{
			target.CallService("open_cover");
		}

		///<summary>Open all or specified cover.</summary>
		public static void OpenCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("open_cover");
		}

		///<summary>Open all or specified cover tilt.</summary>
		public static void OpenCoverTilt(this CoverEntity target)
		{
			target.CallService("open_cover_tilt");
		}

		///<summary>Open all or specified cover tilt.</summary>
		public static void OpenCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("open_cover_tilt");
		}

		///<summary>Move to specific position all or specified cover.</summary>
		public static void SetCoverPosition(this CoverEntity target, CoverSetCoverPositionParameters data)
		{
			target.CallService("set_cover_position", data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		public static void SetCoverPosition(this IEnumerable<CoverEntity> target, CoverSetCoverPositionParameters data)
		{
			target.CallService("set_cover_position", data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The CoverEntity to call this service for</param>
		///<param name="position">Position of the cover</param>
		public static void SetCoverPosition(this CoverEntity target, long @position)
		{
			target.CallService("set_cover_position", new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The IEnumerable<CoverEntity> to call this service for</param>
		///<param name="position">Position of the cover</param>
		public static void SetCoverPosition(this IEnumerable<CoverEntity> target, long @position)
		{
			target.CallService("set_cover_position", new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		public static void SetCoverTiltPosition(this CoverEntity target, CoverSetCoverTiltPositionParameters data)
		{
			target.CallService("set_cover_tilt_position", data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		public static void SetCoverTiltPosition(this IEnumerable<CoverEntity> target, CoverSetCoverTiltPositionParameters data)
		{
			target.CallService("set_cover_tilt_position", data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The CoverEntity to call this service for</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public static void SetCoverTiltPosition(this CoverEntity target, long @tiltPosition)
		{
			target.CallService("set_cover_tilt_position", new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The IEnumerable<CoverEntity> to call this service for</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public static void SetCoverTiltPosition(this IEnumerable<CoverEntity> target, long @tiltPosition)
		{
			target.CallService("set_cover_tilt_position", new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCover(this CoverEntity target)
		{
			target.CallService("stop_cover");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("stop_cover");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCoverTilt(this CoverEntity target)
		{
			target.CallService("stop_cover_tilt");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("stop_cover_tilt");
		}

		///<summary>Toggle a cover open/closed.</summary>
		public static void Toggle(this CoverEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle a cover open/closed.</summary>
		public static void Toggle(this IEnumerable<CoverEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		public static void ToggleCoverTilt(this CoverEntity target)
		{
			target.CallService("toggle_cover_tilt");
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		public static void ToggleCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("toggle_cover_tilt");
		}
	}

	public static class DeebotEntityExtensionMethods
	{
		///<summary>Manually request a refresh</summary>
		public static void Refresh(this VacuumEntity target, DeebotRefreshParameters data)
		{
			target.CallService("refresh", data);
		}

		///<summary>Manually request a refresh</summary>
		public static void Refresh(this IEnumerable<VacuumEntity> target, DeebotRefreshParameters data)
		{
			target.CallService("refresh", data);
		}

		///<summary>Manually request a refresh</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="part">Which part should be refreshed? eg: Status</param>
		public static void Refresh(this VacuumEntity target, string @part)
		{
			target.CallService("refresh", new DeebotRefreshParameters{Part = @part});
		}

		///<summary>Manually request a refresh</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="part">Which part should be refreshed? eg: Status</param>
		public static void Refresh(this IEnumerable<VacuumEntity> target, string @part)
		{
			target.CallService("refresh", new DeebotRefreshParameters{Part = @part});
		}
	}

	public static class HumidifierEntityExtensionMethods
	{
		///<summary>Set target humidity of humidifier device.</summary>
		public static void SetHumidity(this HumidifierEntity target, HumidifierSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of humidifier device.</summary>
		public static void SetHumidity(this IEnumerable<HumidifierEntity> target, HumidifierSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The HumidifierEntity to call this service for</param>
		///<param name="humidity">New target humidity for humidifier device.</param>
		public static void SetHumidity(this HumidifierEntity target, long @humidity)
		{
			target.CallService("set_humidity", new HumidifierSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The IEnumerable<HumidifierEntity> to call this service for</param>
		///<param name="humidity">New target humidity for humidifier device.</param>
		public static void SetHumidity(this IEnumerable<HumidifierEntity> target, long @humidity)
		{
			target.CallService("set_humidity", new HumidifierSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set mode for humidifier device.</summary>
		public static void SetMode(this HumidifierEntity target, HumidifierSetModeParameters data)
		{
			target.CallService("set_mode", data);
		}

		///<summary>Set mode for humidifier device.</summary>
		public static void SetMode(this IEnumerable<HumidifierEntity> target, HumidifierSetModeParameters data)
		{
			target.CallService("set_mode", data);
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The HumidifierEntity to call this service for</param>
		///<param name="mode">New mode eg: away</param>
		public static void SetMode(this HumidifierEntity target, string @mode)
		{
			target.CallService("set_mode", new HumidifierSetModeParameters{Mode = @mode});
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The IEnumerable<HumidifierEntity> to call this service for</param>
		///<param name="mode">New mode eg: away</param>
		public static void SetMode(this IEnumerable<HumidifierEntity> target, string @mode)
		{
			target.CallService("set_mode", new HumidifierSetModeParameters{Mode = @mode});
		}

		///<summary>Toggles a humidifier device.</summary>
		public static void Toggle(this HumidifierEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a humidifier device.</summary>
		public static void Toggle(this IEnumerable<HumidifierEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn humidifier device off.</summary>
		public static void TurnOff(this HumidifierEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn humidifier device off.</summary>
		public static void TurnOff(this IEnumerable<HumidifierEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn humidifier device on.</summary>
		public static void TurnOn(this HumidifierEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn humidifier device on.</summary>
		public static void TurnOn(this IEnumerable<HumidifierEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class InputBooleanEntityExtensionMethods
	{
		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this InputBooleanEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this InputBooleanEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this InputBooleanEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class InputDatetimeEntityExtensionMethods
	{
		///<summary>This can be used to dynamically set the date and/or time.</summary>
		public static void SetDatetime(this InputDatetimeEntity target, InputDatetimeSetDatetimeParameters data)
		{
			target.CallService("set_datetime", data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		public static void SetDatetime(this IEnumerable<InputDatetimeEntity> target, InputDatetimeSetDatetimeParameters data)
		{
			target.CallService("set_datetime", data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The InputDatetimeEntity to call this service for</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public static void SetDatetime(this InputDatetimeEntity target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			target.CallService("set_datetime", new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The IEnumerable<InputDatetimeEntity> to call this service for</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public static void SetDatetime(this IEnumerable<InputDatetimeEntity> target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			target.CallService("set_datetime", new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public static class InputNumberEntityExtensionMethods
	{
		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		public static void Decrement(this InputNumberEntity target)
		{
			target.CallService("decrement");
		}

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		public static void Decrement(this IEnumerable<InputNumberEntity> target)
		{
			target.CallService("decrement");
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		public static void Increment(this InputNumberEntity target)
		{
			target.CallService("increment");
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		public static void Increment(this IEnumerable<InputNumberEntity> target)
		{
			target.CallService("increment");
		}

		///<summary>Set the value of an input number entity.</summary>
		public static void SetValue(this InputNumberEntity target, InputNumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input number entity.</summary>
		public static void SetValue(this IEnumerable<InputNumberEntity> target, InputNumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The InputNumberEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to.</param>
		public static void SetValue(this InputNumberEntity target, double @value)
		{
			target.CallService("set_value", new InputNumberSetValueParameters{Value = @value});
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The IEnumerable<InputNumberEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to.</param>
		public static void SetValue(this IEnumerable<InputNumberEntity> target, double @value)
		{
			target.CallService("set_value", new InputNumberSetValueParameters{Value = @value});
		}
	}

	public static class InputSelectEntityExtensionMethods
	{
		///<summary>Select the first option of an input select entity.</summary>
		public static void SelectFirst(this InputSelectEntity target)
		{
			target.CallService("select_first");
		}

		///<summary>Select the first option of an input select entity.</summary>
		public static void SelectFirst(this IEnumerable<InputSelectEntity> target)
		{
			target.CallService("select_first");
		}

		///<summary>Select the last option of an input select entity.</summary>
		public static void SelectLast(this InputSelectEntity target)
		{
			target.CallService("select_last");
		}

		///<summary>Select the last option of an input select entity.</summary>
		public static void SelectLast(this IEnumerable<InputSelectEntity> target)
		{
			target.CallService("select_last");
		}

		///<summary>Select the next options of an input select entity.</summary>
		public static void SelectNext(this InputSelectEntity target, InputSelectSelectNextParameters data)
		{
			target.CallService("select_next", data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		public static void SelectNext(this IEnumerable<InputSelectEntity> target, InputSelectSelectNextParameters data)
		{
			target.CallService("select_next", data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public static void SelectNext(this InputSelectEntity target, bool? @cycle = null)
		{
			target.CallService("select_next", new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public static void SelectNext(this IEnumerable<InputSelectEntity> target, bool? @cycle = null)
		{
			target.CallService("select_next", new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select an option of an input select entity.</summary>
		public static void SelectOption(this InputSelectEntity target, InputSelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an input select entity.</summary>
		public static void SelectOption(this IEnumerable<InputSelectEntity> target, InputSelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this InputSelectEntity target, string @option)
		{
			target.CallService("select_option", new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this IEnumerable<InputSelectEntity> target, string @option)
		{
			target.CallService("select_option", new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		public static void SelectPrevious(this InputSelectEntity target, InputSelectSelectPreviousParameters data)
		{
			target.CallService("select_previous", data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		public static void SelectPrevious(this IEnumerable<InputSelectEntity> target, InputSelectSelectPreviousParameters data)
		{
			target.CallService("select_previous", data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public static void SelectPrevious(this InputSelectEntity target, bool? @cycle = null)
		{
			target.CallService("select_previous", new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public static void SelectPrevious(this IEnumerable<InputSelectEntity> target, bool? @cycle = null)
		{
			target.CallService("select_previous", new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Set the options of an input select entity.</summary>
		public static void SetOptions(this InputSelectEntity target, InputSelectSetOptionsParameters data)
		{
			target.CallService("set_options", data);
		}

		///<summary>Set the options of an input select entity.</summary>
		public static void SetOptions(this IEnumerable<InputSelectEntity> target, InputSelectSetOptionsParameters data)
		{
			target.CallService("set_options", data);
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public static void SetOptions(this InputSelectEntity target, object @options)
		{
			target.CallService("set_options", new InputSelectSetOptionsParameters{Options = @options});
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public static void SetOptions(this IEnumerable<InputSelectEntity> target, object @options)
		{
			target.CallService("set_options", new InputSelectSetOptionsParameters{Options = @options});
		}
	}

	public static class InputTextEntityExtensionMethods
	{
		///<summary>Set the value of an input text entity.</summary>
		public static void SetValue(this InputTextEntity target, InputTextSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input text entity.</summary>
		public static void SetValue(this IEnumerable<InputTextEntity> target, InputTextSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The InputTextEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public static void SetValue(this InputTextEntity target, string @value)
		{
			target.CallService("set_value", new InputTextSetValueParameters{Value = @value});
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The IEnumerable<InputTextEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public static void SetValue(this IEnumerable<InputTextEntity> target, string @value)
		{
			target.CallService("set_value", new InputTextSetValueParameters{Value = @value});
		}
	}

	public static class KodiEntityExtensionMethods
	{
		///<summary>Add music to the default playlist (i.e. playlistid=0).</summary>
		public static void AddToPlaylist(this MediaPlayerEntity target, KodiAddToPlaylistParameters data)
		{
			target.CallService("add_to_playlist", data);
		}

		///<summary>Add music to the default playlist (i.e. playlistid=0).</summary>
		public static void AddToPlaylist(this IEnumerable<MediaPlayerEntity> target, KodiAddToPlaylistParameters data)
		{
			target.CallService("add_to_playlist", data);
		}

		///<summary>Add music to the default playlist (i.e. playlistid=0).</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="mediaType">Media type identifier. It must be one of SONG or ALBUM. eg: ALBUM</param>
		///<param name="mediaId">Unique Id of the media entry to add (`songid` or albumid`). If not defined, `media_name` and `artist_name` are needed to search the Kodi music library. eg: 123456</param>
		///<param name="mediaName">Optional media name for filtering media. Can be 'ALL' when `media_type` is 'ALBUM' and `artist_name` is specified, to add all songs from one artist. eg: Highway to Hell</param>
		///<param name="artistName">Optional artist name for filtering media. eg: AC/DC</param>
		public static void AddToPlaylist(this MediaPlayerEntity target, string @mediaType, string? @mediaId = null, string? @mediaName = null, string? @artistName = null)
		{
			target.CallService("add_to_playlist", new KodiAddToPlaylistParameters{MediaType = @mediaType, MediaId = @mediaId, MediaName = @mediaName, ArtistName = @artistName});
		}

		///<summary>Add music to the default playlist (i.e. playlistid=0).</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="mediaType">Media type identifier. It must be one of SONG or ALBUM. eg: ALBUM</param>
		///<param name="mediaId">Unique Id of the media entry to add (`songid` or albumid`). If not defined, `media_name` and `artist_name` are needed to search the Kodi music library. eg: 123456</param>
		///<param name="mediaName">Optional media name for filtering media. Can be 'ALL' when `media_type` is 'ALBUM' and `artist_name` is specified, to add all songs from one artist. eg: Highway to Hell</param>
		///<param name="artistName">Optional artist name for filtering media. eg: AC/DC</param>
		public static void AddToPlaylist(this IEnumerable<MediaPlayerEntity> target, string @mediaType, string? @mediaId = null, string? @mediaName = null, string? @artistName = null)
		{
			target.CallService("add_to_playlist", new KodiAddToPlaylistParameters{MediaType = @mediaType, MediaId = @mediaId, MediaName = @mediaName, ArtistName = @artistName});
		}

		///<summary>Call a Kodi JSONRPC API method with optional parameters. Results of the Kodi API call will be redirected in a Home Assistant event: `kodi_call_method_result`.</summary>
		public static void CallMethod(this MediaPlayerEntity target, KodiCallMethodParameters data)
		{
			target.CallService("call_method", data);
		}

		///<summary>Call a Kodi JSONRPC API method with optional parameters. Results of the Kodi API call will be redirected in a Home Assistant event: `kodi_call_method_result`.</summary>
		public static void CallMethod(this IEnumerable<MediaPlayerEntity> target, KodiCallMethodParameters data)
		{
			target.CallService("call_method", data);
		}

		///<summary>Call a Kodi JSONRPC API method with optional parameters. Results of the Kodi API call will be redirected in a Home Assistant event: `kodi_call_method_result`.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="method">Name of the Kodi JSONRPC API method to be called. eg: VideoLibrary.GetRecentlyAddedEpisodes</param>
		public static void CallMethod(this MediaPlayerEntity target, string @method)
		{
			target.CallService("call_method", new KodiCallMethodParameters{Method = @method});
		}

		///<summary>Call a Kodi JSONRPC API method with optional parameters. Results of the Kodi API call will be redirected in a Home Assistant event: `kodi_call_method_result`.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="method">Name of the Kodi JSONRPC API method to be called. eg: VideoLibrary.GetRecentlyAddedEpisodes</param>
		public static void CallMethod(this IEnumerable<MediaPlayerEntity> target, string @method)
		{
			target.CallService("call_method", new KodiCallMethodParameters{Method = @method});
		}
	}

	public static class LightEntityExtensionMethods
	{
		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this LightEntity target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this IEnumerable<LightEntity> target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this LightEntity target, long? @transition = null, object? @rgbColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this LightEntity target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this IEnumerable<LightEntity> target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this LightEntity target, long? @transition = null, string? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this IEnumerable<LightEntity> target, long? @transition = null, string? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this LightEntity target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this IEnumerable<LightEntity> target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public static class MediaPlayerEntityExtensionMethods
	{
		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this MediaPlayerEntity target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this MediaPlayerEntity target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</param>
		public static void Join(this MediaPlayerEntity target, object? @groupMembers = null)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</param>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, object? @groupMembers = null)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this MediaPlayerEntity target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this MediaPlayerEntity target)
		{
			target.CallService("media_play");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this MediaPlayerEntity target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this MediaPlayerEntity target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this MediaPlayerEntity target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this MediaPlayerEntity target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this MediaPlayerEntity target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		public static void PlayMedia(this MediaPlayerEntity target, string @mediaContentId, string @mediaContentType)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType});
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, string @mediaContentId, string @mediaContentType)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType});
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this MediaPlayerEntity target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this MediaPlayerEntity target, string @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, string @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this MediaPlayerEntity target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this MediaPlayerEntity target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this MediaPlayerEntity target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this MediaPlayerEntity target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this MediaPlayerEntity target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this MediaPlayerEntity target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this MediaPlayerEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this MediaPlayerEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this MediaPlayerEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_on");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this MediaPlayerEntity target)
		{
			target.CallService("unjoin");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("unjoin");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this MediaPlayerEntity target)
		{
			target.CallService("volume_down");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_down");
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this MediaPlayerEntity target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this MediaPlayerEntity target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this MediaPlayerEntity target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this MediaPlayerEntity target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this MediaPlayerEntity target)
		{
			target.CallService("volume_up");
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_up");
		}
	}

	public static class NumberEntityExtensionMethods
	{
		///<summary>Set the value of a Number entity.</summary>
		public static void SetValue(this NumberEntity target, NumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of a Number entity.</summary>
		public static void SetValue(this IEnumerable<NumberEntity> target, NumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The NumberEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public static void SetValue(this NumberEntity target, string? @value = null)
		{
			target.CallService("set_value", new NumberSetValueParameters{Value = @value});
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The IEnumerable<NumberEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public static void SetValue(this IEnumerable<NumberEntity> target, string? @value = null)
		{
			target.CallService("set_value", new NumberSetValueParameters{Value = @value});
		}
	}

	public static class OnvifEntityExtensionMethods
	{
		///<summary>If your ONVIF camera supports PTZ, you will be able to pan, tilt or zoom your camera.</summary>
		public static void Ptz(this CameraEntity target, OnvifPtzParameters data)
		{
			target.CallService("ptz", data);
		}

		///<summary>If your ONVIF camera supports PTZ, you will be able to pan, tilt or zoom your camera.</summary>
		public static void Ptz(this IEnumerable<CameraEntity> target, OnvifPtzParameters data)
		{
			target.CallService("ptz", data);
		}

		///<summary>If your ONVIF camera supports PTZ, you will be able to pan, tilt or zoom your camera.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="tilt">Tilt direction.</param>
		///<param name="pan">Pan direction.</param>
		///<param name="zoom">Zoom.</param>
		///<param name="distance">Distance coefficient. Sets how much PTZ should be executed in one request.</param>
		///<param name="speed">Speed coefficient. Sets how fast PTZ will be executed.</param>
		///<param name="continuousDuration">Set ContinuousMove delay in seconds before stopping the move</param>
		///<param name="preset">PTZ preset profile token. Sets the preset profile token which is executed with GotoPreset eg: 1</param>
		///<param name="moveMode">PTZ moving mode.</param>
		public static void Ptz(this CameraEntity target, string? @tilt = null, string? @pan = null, string? @zoom = null, double? @distance = null, double? @speed = null, double? @continuousDuration = null, string? @preset = null, string? @moveMode = null)
		{
			target.CallService("ptz", new OnvifPtzParameters{Tilt = @tilt, Pan = @pan, Zoom = @zoom, Distance = @distance, Speed = @speed, ContinuousDuration = @continuousDuration, Preset = @preset, MoveMode = @moveMode});
		}

		///<summary>If your ONVIF camera supports PTZ, you will be able to pan, tilt or zoom your camera.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="tilt">Tilt direction.</param>
		///<param name="pan">Pan direction.</param>
		///<param name="zoom">Zoom.</param>
		///<param name="distance">Distance coefficient. Sets how much PTZ should be executed in one request.</param>
		///<param name="speed">Speed coefficient. Sets how fast PTZ will be executed.</param>
		///<param name="continuousDuration">Set ContinuousMove delay in seconds before stopping the move</param>
		///<param name="preset">PTZ preset profile token. Sets the preset profile token which is executed with GotoPreset eg: 1</param>
		///<param name="moveMode">PTZ moving mode.</param>
		public static void Ptz(this IEnumerable<CameraEntity> target, string? @tilt = null, string? @pan = null, string? @zoom = null, double? @distance = null, double? @speed = null, double? @continuousDuration = null, string? @preset = null, string? @moveMode = null)
		{
			target.CallService("ptz", new OnvifPtzParameters{Tilt = @tilt, Pan = @pan, Zoom = @zoom, Distance = @distance, Speed = @speed, ContinuousDuration = @continuousDuration, Preset = @preset, MoveMode = @moveMode});
		}
	}

	public static class OpenhomeEntityExtensionMethods
	{
		///<summary>Invoke a pin on the specified device.</summary>
		public static void InvokePin(this MediaPlayerEntity target, OpenhomeInvokePinParameters data)
		{
			target.CallService("invoke_pin", data);
		}

		///<summary>Invoke a pin on the specified device.</summary>
		public static void InvokePin(this IEnumerable<MediaPlayerEntity> target, OpenhomeInvokePinParameters data)
		{
			target.CallService("invoke_pin", data);
		}

		///<summary>Invoke a pin on the specified device.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="pin">Which pin to invoke</param>
		public static void InvokePin(this MediaPlayerEntity target, long @pin)
		{
			target.CallService("invoke_pin", new OpenhomeInvokePinParameters{Pin = @pin});
		}

		///<summary>Invoke a pin on the specified device.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="pin">Which pin to invoke</param>
		public static void InvokePin(this IEnumerable<MediaPlayerEntity> target, long @pin)
		{
			target.CallService("invoke_pin", new OpenhomeInvokePinParameters{Pin = @pin});
		}
	}

	public static class RemoteEntityExtensionMethods
	{
		///<summary>Deletes a command or a list of commands from the database.</summary>
		public static void DeleteCommand(this RemoteEntity target, RemoteDeleteCommandParameters data)
		{
			target.CallService("delete_command", data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		public static void DeleteCommand(this IEnumerable<RemoteEntity> target, RemoteDeleteCommandParameters data)
		{
			target.CallService("delete_command", data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public static void DeleteCommand(this RemoteEntity target, object @command, string? @device = null)
		{
			target.CallService("delete_command", new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public static void DeleteCommand(this IEnumerable<RemoteEntity> target, object @command, string? @device = null)
		{
			target.CallService("delete_command", new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		public static void LearnCommand(this RemoteEntity target, RemoteLearnCommandParameters data)
		{
			target.CallService("learn_command", data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		public static void LearnCommand(this IEnumerable<RemoteEntity> target, RemoteLearnCommandParameters data)
		{
			target.CallService("learn_command", data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public static void LearnCommand(this RemoteEntity target, string? @device = null, object? @command = null, string? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			target.CallService("learn_command", new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public static void LearnCommand(this IEnumerable<RemoteEntity> target, string? @device = null, object? @command = null, string? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			target.CallService("learn_command", new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		public static void SendCommand(this RemoteEntity target, RemoteSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		public static void SendCommand(this IEnumerable<RemoteEntity> target, RemoteSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public static void SendCommand(this RemoteEntity target, object @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			target.CallService("send_command", new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public static void SendCommand(this IEnumerable<RemoteEntity> target, object @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			target.CallService("send_command", new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Toggles a device.</summary>
		public static void Toggle(this RemoteEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a device.</summary>
		public static void Toggle(this IEnumerable<RemoteEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Sends the Power Off Command.</summary>
		public static void TurnOff(this RemoteEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Sends the Power Off Command.</summary>
		public static void TurnOff(this IEnumerable<RemoteEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Sends the Power On Command.</summary>
		public static void TurnOn(this RemoteEntity target, RemoteTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Sends the Power On Command.</summary>
		public static void TurnOn(this IEnumerable<RemoteEntity> target, RemoteTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public static void TurnOn(this RemoteEntity target, string? @activity = null)
		{
			target.CallService("turn_on", new RemoteTurnOnParameters{Activity = @activity});
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public static void TurnOn(this IEnumerable<RemoteEntity> target, string? @activity = null)
		{
			target.CallService("turn_on", new RemoteTurnOnParameters{Activity = @activity});
		}
	}

	public static class SceneEntityExtensionMethods
	{
		///<summary>Activate a scene.</summary>
		public static void TurnOn(this SceneEntity target, SceneTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Activate a scene.</summary>
		public static void TurnOn(this IEnumerable<SceneEntity> target, SceneTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The SceneEntity to call this service for</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public static void TurnOn(this SceneEntity target, long? @transition = null)
		{
			target.CallService("turn_on", new SceneTurnOnParameters{Transition = @transition});
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The IEnumerable<SceneEntity> to call this service for</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public static void TurnOn(this IEnumerable<SceneEntity> target, long? @transition = null)
		{
			target.CallService("turn_on", new SceneTurnOnParameters{Transition = @transition});
		}
	}

	public static class ScriptEntityExtensionMethods
	{
		///<summary>Toggle script</summary>
		public static void Toggle(this ScriptEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle script</summary>
		public static void Toggle(this IEnumerable<ScriptEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn off script</summary>
		public static void TurnOff(this ScriptEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off script</summary>
		public static void TurnOff(this IEnumerable<ScriptEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on script</summary>
		public static void TurnOn(this ScriptEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on script</summary>
		public static void TurnOn(this IEnumerable<ScriptEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class SelectEntityExtensionMethods
	{
		///<summary>Select an option of an select entity.</summary>
		public static void SelectOption(this SelectEntity target, SelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an select entity.</summary>
		public static void SelectOption(this IEnumerable<SelectEntity> target, SelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The SelectEntity to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this SelectEntity target, string @option)
		{
			target.CallService("select_option", new SelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The IEnumerable<SelectEntity> to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this IEnumerable<SelectEntity> target, string @option)
		{
			target.CallService("select_option", new SelectSelectOptionParameters{Option = @option});
		}
	}

	public static class SwitchEntityExtensionMethods
	{
		///<summary>Toggles a switch state</summary>
		public static void Toggle(this SwitchEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a switch state</summary>
		public static void Toggle(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this SwitchEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this SwitchEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class TimerEntityExtensionMethods
	{
		///<summary>Cancel a timer.</summary>
		public static void Cancel(this TimerEntity target)
		{
			target.CallService("cancel");
		}

		///<summary>Cancel a timer.</summary>
		public static void Cancel(this IEnumerable<TimerEntity> target)
		{
			target.CallService("cancel");
		}

		///<summary>Finish a timer.</summary>
		public static void Finish(this TimerEntity target)
		{
			target.CallService("finish");
		}

		///<summary>Finish a timer.</summary>
		public static void Finish(this IEnumerable<TimerEntity> target)
		{
			target.CallService("finish");
		}

		///<summary>Pause a timer.</summary>
		public static void Pause(this TimerEntity target)
		{
			target.CallService("pause");
		}

		///<summary>Pause a timer.</summary>
		public static void Pause(this IEnumerable<TimerEntity> target)
		{
			target.CallService("pause");
		}

		///<summary>Start a timer</summary>
		public static void Start(this TimerEntity target, TimerStartParameters data)
		{
			target.CallService("start", data);
		}

		///<summary>Start a timer</summary>
		public static void Start(this IEnumerable<TimerEntity> target, TimerStartParameters data)
		{
			target.CallService("start", data);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The TimerEntity to call this service for</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public static void Start(this TimerEntity target, string? @duration = null)
		{
			target.CallService("start", new TimerStartParameters{Duration = @duration});
		}

		///<summary>Start a timer</summary>
		///<param name="target">The IEnumerable<TimerEntity> to call this service for</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public static void Start(this IEnumerable<TimerEntity> target, string? @duration = null)
		{
			target.CallService("start", new TimerStartParameters{Duration = @duration});
		}
	}

	public static class VacuumEntityExtensionMethods
	{
		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		public static void CleanSpot(this VacuumEntity target)
		{
			target.CallService("clean_spot");
		}

		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		public static void CleanSpot(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("clean_spot");
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		public static void Locate(this VacuumEntity target)
		{
			target.CallService("locate");
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		public static void Locate(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("locate");
		}

		///<summary>Pause the cleaning task.</summary>
		public static void Pause(this VacuumEntity target)
		{
			target.CallService("pause");
		}

		///<summary>Pause the cleaning task.</summary>
		public static void Pause(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("pause");
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		public static void ReturnToBase(this VacuumEntity target)
		{
			target.CallService("return_to_base");
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		public static void ReturnToBase(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("return_to_base");
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		public static void SendCommand(this VacuumEntity target, VacuumSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		public static void SendCommand(this IEnumerable<VacuumEntity> target, VacuumSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public static void SendCommand(this VacuumEntity target, string @command, object? @params = null)
		{
			target.CallService("send_command", new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public static void SendCommand(this IEnumerable<VacuumEntity> target, string @command, object? @params = null)
		{
			target.CallService("send_command", new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		public static void SetFanSpeed(this VacuumEntity target, VacuumSetFanSpeedParameters data)
		{
			target.CallService("set_fan_speed", data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		public static void SetFanSpeed(this IEnumerable<VacuumEntity> target, VacuumSetFanSpeedParameters data)
		{
			target.CallService("set_fan_speed", data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public static void SetFanSpeed(this VacuumEntity target, string @fanSpeed)
		{
			target.CallService("set_fan_speed", new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public static void SetFanSpeed(this IEnumerable<VacuumEntity> target, string @fanSpeed)
		{
			target.CallService("set_fan_speed", new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		public static void Start(this VacuumEntity target)
		{
			target.CallService("start");
		}

		///<summary>Start or resume the cleaning task.</summary>
		public static void Start(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("start");
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		public static void StartPause(this VacuumEntity target)
		{
			target.CallService("start_pause");
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		public static void StartPause(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("start_pause");
		}

		///<summary>Stop the current cleaning task.</summary>
		public static void Stop(this VacuumEntity target)
		{
			target.CallService("stop");
		}

		///<summary>Stop the current cleaning task.</summary>
		public static void Stop(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("stop");
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		public static void TurnOff(this VacuumEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		public static void TurnOff(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Start a new cleaning task.</summary>
		public static void TurnOn(this VacuumEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Start a new cleaning task.</summary>
		public static void TurnOn(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class YamahaEntityExtensionMethods
	{
		///<summary>Enable or disable an output port</summary>
		public static void EnableOutput(this MediaPlayerEntity target, YamahaEnableOutputParameters data)
		{
			target.CallService("enable_output", data);
		}

		///<summary>Enable or disable an output port</summary>
		public static void EnableOutput(this IEnumerable<MediaPlayerEntity> target, YamahaEnableOutputParameters data)
		{
			target.CallService("enable_output", data);
		}

		///<summary>Enable or disable an output port</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="port">Name of port to enable/disable. eg: hdmi1</param>
		///<param name="enabled">Indicate if port should be enabled or not.</param>
		public static void EnableOutput(this MediaPlayerEntity target, string @port, bool @enabled)
		{
			target.CallService("enable_output", new YamahaEnableOutputParameters{Port = @port, Enabled = @enabled});
		}

		///<summary>Enable or disable an output port</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="port">Name of port to enable/disable. eg: hdmi1</param>
		///<param name="enabled">Indicate if port should be enabled or not.</param>
		public static void EnableOutput(this IEnumerable<MediaPlayerEntity> target, string @port, bool @enabled)
		{
			target.CallService("enable_output", new YamahaEnableOutputParameters{Port = @port, Enabled = @enabled});
		}

		///<summary>Control the cursor in a menu</summary>
		public static void MenuCursor(this MediaPlayerEntity target, YamahaMenuCursorParameters data)
		{
			target.CallService("menu_cursor", data);
		}

		///<summary>Control the cursor in a menu</summary>
		public static void MenuCursor(this IEnumerable<MediaPlayerEntity> target, YamahaMenuCursorParameters data)
		{
			target.CallService("menu_cursor", data);
		}

		///<summary>Control the cursor in a menu</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="cursor">Name of the cursor key to press ('up', 'down', 'left', 'right', 'select', 'return') eg: down</param>
		public static void MenuCursor(this MediaPlayerEntity target, string? @cursor = null)
		{
			target.CallService("menu_cursor", new YamahaMenuCursorParameters{Cursor = @cursor});
		}

		///<summary>Control the cursor in a menu</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="cursor">Name of the cursor key to press ('up', 'down', 'left', 'right', 'select', 'return') eg: down</param>
		public static void MenuCursor(this IEnumerable<MediaPlayerEntity> target, string? @cursor = null)
		{
			target.CallService("menu_cursor", new YamahaMenuCursorParameters{Cursor = @cursor});
		}

		///<summary>Select a scene on the receiver</summary>
		public static void SelectScene(this MediaPlayerEntity target, YamahaSelectSceneParameters data)
		{
			target.CallService("select_scene", data);
		}

		///<summary>Select a scene on the receiver</summary>
		public static void SelectScene(this IEnumerable<MediaPlayerEntity> target, YamahaSelectSceneParameters data)
		{
			target.CallService("select_scene", data);
		}

		///<summary>Select a scene on the receiver</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="scene">Name of the scene. Standard for RX-V437 is 'BD/DVD Movie Viewing', 'TV Viewing', 'NET Audio Listening' or 'Radio Listening' eg: TV Viewing</param>
		public static void SelectScene(this MediaPlayerEntity target, string @scene)
		{
			target.CallService("select_scene", new YamahaSelectSceneParameters{Scene = @scene});
		}

		///<summary>Select a scene on the receiver</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="scene">Name of the scene. Standard for RX-V437 is 'BD/DVD Movie Viewing', 'TV Viewing', 'NET Audio Listening' or 'Radio Listening' eg: TV Viewing</param>
		public static void SelectScene(this IEnumerable<MediaPlayerEntity> target, string @scene)
		{
			target.CallService("select_scene", new YamahaSelectSceneParameters{Scene = @scene});
		}
	}

	public static class YeelightEntityExtensionMethods
	{
		///<summary>Turns the light on to the specified brightness and sets a timer to turn it back off after the given number of minutes. If the light is off, Set a color scene, if light is off, it will be turned on.</summary>
		public static void SetAutoDelayOffScene(this LightEntity target, YeelightSetAutoDelayOffSceneParameters data)
		{
			target.CallService("set_auto_delay_off_scene", data);
		}

		///<summary>Turns the light on to the specified brightness and sets a timer to turn it back off after the given number of minutes. If the light is off, Set a color scene, if light is off, it will be turned on.</summary>
		public static void SetAutoDelayOffScene(this IEnumerable<LightEntity> target, YeelightSetAutoDelayOffSceneParameters data)
		{
			target.CallService("set_auto_delay_off_scene", data);
		}

		///<summary>Turns the light on to the specified brightness and sets a timer to turn it back off after the given number of minutes. If the light is off, Set a color scene, if light is off, it will be turned on.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="minutes">The time to wait before automatically turning the light off.</param>
		///<param name="brightness">The brightness value to set.</param>
		public static void SetAutoDelayOffScene(this LightEntity target, long? @minutes = null, long? @brightness = null)
		{
			target.CallService("set_auto_delay_off_scene", new YeelightSetAutoDelayOffSceneParameters{Minutes = @minutes, Brightness = @brightness});
		}

		///<summary>Turns the light on to the specified brightness and sets a timer to turn it back off after the given number of minutes. If the light is off, Set a color scene, if light is off, it will be turned on.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="minutes">The time to wait before automatically turning the light off.</param>
		///<param name="brightness">The brightness value to set.</param>
		public static void SetAutoDelayOffScene(this IEnumerable<LightEntity> target, long? @minutes = null, long? @brightness = null)
		{
			target.CallService("set_auto_delay_off_scene", new YeelightSetAutoDelayOffSceneParameters{Minutes = @minutes, Brightness = @brightness});
		}

		///<summary>starts a color flow. If the light is off, it will be turned on.</summary>
		public static void SetColorFlowScene(this LightEntity target, YeelightSetColorFlowSceneParameters data)
		{
			target.CallService("set_color_flow_scene", data);
		}

		///<summary>starts a color flow. If the light is off, it will be turned on.</summary>
		public static void SetColorFlowScene(this IEnumerable<LightEntity> target, YeelightSetColorFlowSceneParameters data)
		{
			target.CallService("set_color_flow_scene", data);
		}

		///<summary>starts a color flow. If the light is off, it will be turned on.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="count">The number of times to run this flow (0 to run forever).</param>
		///<param name="action">The action to take after the flow stops.</param>
		///<param name="transitions">Array of transitions, for desired effect. Examples https://yeelight.readthedocs.io/en/stable/flow.html eg: [{ "TemperatureTransition": [1900, 1000, 80] }, { "TemperatureTransition": [1900, 1000, 10] }]</param>
		public static void SetColorFlowScene(this LightEntity target, long? @count = null, string? @action = null, object? @transitions = null)
		{
			target.CallService("set_color_flow_scene", new YeelightSetColorFlowSceneParameters{Count = @count, Action = @action, Transitions = @transitions});
		}

		///<summary>starts a color flow. If the light is off, it will be turned on.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="count">The number of times to run this flow (0 to run forever).</param>
		///<param name="action">The action to take after the flow stops.</param>
		///<param name="transitions">Array of transitions, for desired effect. Examples https://yeelight.readthedocs.io/en/stable/flow.html eg: [{ "TemperatureTransition": [1900, 1000, 80] }, { "TemperatureTransition": [1900, 1000, 10] }]</param>
		public static void SetColorFlowScene(this IEnumerable<LightEntity> target, long? @count = null, string? @action = null, object? @transitions = null)
		{
			target.CallService("set_color_flow_scene", new YeelightSetColorFlowSceneParameters{Count = @count, Action = @action, Transitions = @transitions});
		}

		///<summary>Changes the light to the specified RGB color and brightness. If the light is off, it will be turned on.</summary>
		public static void SetColorScene(this LightEntity target, YeelightSetColorSceneParameters data)
		{
			target.CallService("set_color_scene", data);
		}

		///<summary>Changes the light to the specified RGB color and brightness. If the light is off, it will be turned on.</summary>
		public static void SetColorScene(this IEnumerable<LightEntity> target, YeelightSetColorSceneParameters data)
		{
			target.CallService("set_color_scene", data);
		}

		///<summary>Changes the light to the specified RGB color and brightness. If the light is off, it will be turned on.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="brightness">The brightness value to set.</param>
		public static void SetColorScene(this LightEntity target, object? @rgbColor = null, long? @brightness = null)
		{
			target.CallService("set_color_scene", new YeelightSetColorSceneParameters{RgbColor = @rgbColor, Brightness = @brightness});
		}

		///<summary>Changes the light to the specified RGB color and brightness. If the light is off, it will be turned on.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="brightness">The brightness value to set.</param>
		public static void SetColorScene(this IEnumerable<LightEntity> target, object? @rgbColor = null, long? @brightness = null)
		{
			target.CallService("set_color_scene", new YeelightSetColorSceneParameters{RgbColor = @rgbColor, Brightness = @brightness});
		}

		///<summary>Changes the light to the specified color temperature. If the light is off, it will be turned on.</summary>
		public static void SetColorTempScene(this LightEntity target, YeelightSetColorTempSceneParameters data)
		{
			target.CallService("set_color_temp_scene", data);
		}

		///<summary>Changes the light to the specified color temperature. If the light is off, it will be turned on.</summary>
		public static void SetColorTempScene(this IEnumerable<LightEntity> target, YeelightSetColorTempSceneParameters data)
		{
			target.CallService("set_color_temp_scene", data);
		}

		///<summary>Changes the light to the specified color temperature. If the light is off, it will be turned on.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">The brightness value to set.</param>
		public static void SetColorTempScene(this LightEntity target, long? @kelvin = null, long? @brightness = null)
		{
			target.CallService("set_color_temp_scene", new YeelightSetColorTempSceneParameters{Kelvin = @kelvin, Brightness = @brightness});
		}

		///<summary>Changes the light to the specified color temperature. If the light is off, it will be turned on.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">The brightness value to set.</param>
		public static void SetColorTempScene(this IEnumerable<LightEntity> target, long? @kelvin = null, long? @brightness = null)
		{
			target.CallService("set_color_temp_scene", new YeelightSetColorTempSceneParameters{Kelvin = @kelvin, Brightness = @brightness});
		}

		///<summary>Changes the light to the specified HSV color and brightness. If the light is off, it will be turned on.</summary>
		public static void SetHsvScene(this LightEntity target, YeelightSetHsvSceneParameters data)
		{
			target.CallService("set_hsv_scene", data);
		}

		///<summary>Changes the light to the specified HSV color and brightness. If the light is off, it will be turned on.</summary>
		public static void SetHsvScene(this IEnumerable<LightEntity> target, YeelightSetHsvSceneParameters data)
		{
			target.CallService("set_hsv_scene", data);
		}

		///<summary>Changes the light to the specified HSV color and brightness. If the light is off, it will be turned on.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-359 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="brightness">The brightness value to set.</param>
		public static void SetHsvScene(this LightEntity target, object? @hsColor = null, long? @brightness = null)
		{
			target.CallService("set_hsv_scene", new YeelightSetHsvSceneParameters{HsColor = @hsColor, Brightness = @brightness});
		}

		///<summary>Changes the light to the specified HSV color and brightness. If the light is off, it will be turned on.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-359 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="brightness">The brightness value to set.</param>
		public static void SetHsvScene(this IEnumerable<LightEntity> target, object? @hsColor = null, long? @brightness = null)
		{
			target.CallService("set_hsv_scene", new YeelightSetHsvSceneParameters{HsColor = @hsColor, Brightness = @brightness});
		}

		///<summary>Set a operation mode.</summary>
		public static void SetMode(this LightEntity target, YeelightSetModeParameters data)
		{
			target.CallService("set_mode", data);
		}

		///<summary>Set a operation mode.</summary>
		public static void SetMode(this IEnumerable<LightEntity> target, YeelightSetModeParameters data)
		{
			target.CallService("set_mode", data);
		}

		///<summary>Set a operation mode.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="mode">Operation mode.</param>
		public static void SetMode(this LightEntity target, string @mode)
		{
			target.CallService("set_mode", new YeelightSetModeParameters{Mode = @mode});
		}

		///<summary>Set a operation mode.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="mode">Operation mode.</param>
		public static void SetMode(this IEnumerable<LightEntity> target, string @mode)
		{
			target.CallService("set_mode", new YeelightSetModeParameters{Mode = @mode});
		}

		///<summary>Enable or disable music_mode</summary>
		public static void SetMusicMode(this LightEntity target, YeelightSetMusicModeParameters data)
		{
			target.CallService("set_music_mode", data);
		}

		///<summary>Enable or disable music_mode</summary>
		public static void SetMusicMode(this IEnumerable<LightEntity> target, YeelightSetMusicModeParameters data)
		{
			target.CallService("set_music_mode", data);
		}

		///<summary>Enable or disable music_mode</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="musicMode">Use true or false to enable / disable music_mode</param>
		public static void SetMusicMode(this LightEntity target, bool @musicMode)
		{
			target.CallService("set_music_mode", new YeelightSetMusicModeParameters{MusicMode = @musicMode});
		}

		///<summary>Enable or disable music_mode</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="musicMode">Use true or false to enable / disable music_mode</param>
		public static void SetMusicMode(this IEnumerable<LightEntity> target, bool @musicMode)
		{
			target.CallService("set_music_mode", new YeelightSetMusicModeParameters{MusicMode = @musicMode});
		}

		///<summary>Start a custom flow, using transitions from https://yeelight.readthedocs.io/en/stable/yeelight.html#flow-objects</summary>
		public static void StartFlow(this LightEntity target, YeelightStartFlowParameters data)
		{
			target.CallService("start_flow", data);
		}

		///<summary>Start a custom flow, using transitions from https://yeelight.readthedocs.io/en/stable/yeelight.html#flow-objects</summary>
		public static void StartFlow(this IEnumerable<LightEntity> target, YeelightStartFlowParameters data)
		{
			target.CallService("start_flow", data);
		}

		///<summary>Start a custom flow, using transitions from https://yeelight.readthedocs.io/en/stable/yeelight.html#flow-objects</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="count">The number of times to run this flow (0 to run forever).</param>
		///<param name="action">The action to take after the flow stops.</param>
		///<param name="transitions">Array of transitions, for desired effect. Examples https://yeelight.readthedocs.io/en/stable/flow.html eg: [{ "TemperatureTransition": [1900, 1000, 80] }, { "TemperatureTransition": [1900, 1000, 10] }]</param>
		public static void StartFlow(this LightEntity target, long? @count = null, string? @action = null, object? @transitions = null)
		{
			target.CallService("start_flow", new YeelightStartFlowParameters{Count = @count, Action = @action, Transitions = @transitions});
		}

		///<summary>Start a custom flow, using transitions from https://yeelight.readthedocs.io/en/stable/yeelight.html#flow-objects</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="count">The number of times to run this flow (0 to run forever).</param>
		///<param name="action">The action to take after the flow stops.</param>
		///<param name="transitions">Array of transitions, for desired effect. Examples https://yeelight.readthedocs.io/en/stable/flow.html eg: [{ "TemperatureTransition": [1900, 1000, 80] }, { "TemperatureTransition": [1900, 1000, 10] }]</param>
		public static void StartFlow(this IEnumerable<LightEntity> target, long? @count = null, string? @action = null, object? @transitions = null)
		{
			target.CallService("start_flow", new YeelightStartFlowParameters{Count = @count, Action = @action, Transitions = @transitions});
		}
	}

	public static class ZwaveJsEntityExtensionMethods
	{
		///<summary>Resets the meter(s) on a node.</summary>
		public static void ResetMeter(this SensorEntity target, ZwaveJsResetMeterParameters data)
		{
			target.CallService("reset_meter", data);
		}

		///<summary>Resets the meter(s) on a node.</summary>
		public static void ResetMeter(this IEnumerable<SensorEntity> target, ZwaveJsResetMeterParameters data)
		{
			target.CallService("reset_meter", data);
		}

		///<summary>Resets the meter(s) on a node.</summary>
		///<param name="target">The SensorEntity to call this service for</param>
		///<param name="meterType">The type of meter to reset. Not all meters support the ability to pick a meter type to reset. eg: 1</param>
		///<param name="value">The value that meter(s) should be reset to. Not all meters support the ability to be reset to a specific value. eg: 5</param>
		public static void ResetMeter(this SensorEntity target, string? @meterType = null, string? @value = null)
		{
			target.CallService("reset_meter", new ZwaveJsResetMeterParameters{MeterType = @meterType, Value = @value});
		}

		///<summary>Resets the meter(s) on a node.</summary>
		///<param name="target">The IEnumerable<SensorEntity> to call this service for</param>
		///<param name="meterType">The type of meter to reset. Not all meters support the ability to pick a meter type to reset. eg: 1</param>
		///<param name="value">The value that meter(s) should be reset to. Not all meters support the ability to be reset to a specific value. eg: 5</param>
		public static void ResetMeter(this IEnumerable<SensorEntity> target, string? @meterType = null, string? @value = null)
		{
			target.CallService("reset_meter", new ZwaveJsResetMeterParameters{MeterType = @meterType, Value = @value});
		}
	}
}