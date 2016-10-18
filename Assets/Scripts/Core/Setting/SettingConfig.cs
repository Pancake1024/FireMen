﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SettingConfig 
{
    #region PageCard
    public enum Page
    {
        HomePage,
        SettingPage,
        CalibrationPage,
        AccountPage,
        BusinessRecord_Page,
        TotalRecord_Page,
        DataReset_Page,
        ShootingCalibration_Page
    };

    public enum HomePageItem
    {
        Set     = 0,
        Account = 1,
        Exit    = 2
    };

    public enum SettingPageItem
    {
        Money           = 0,
        Volume          = 1,
        Difficulity     = 2,
        Lanuage         = 3,
        Calibration     = 4,
        OutTicket       = 5,
        Exit            = 6,
        WaterShow       = 7,
        ClearCoin       = 8,
    };

    public enum CalibrationPageItem
    {
        Player1         = 0,
        Player2         = 1,
        Player3         = 2,
        Exit            = 3
    }

    public enum AccountPageItem
    {
        BusinessRecords     = 0,
        TotalRecords        = 1,
        DataReset           = 2,
        Exit                = 3
    }

    public enum DataResetItem
    {
        Yes         = 0,
        No          = 1
    }

    public enum ComdOfButA
    {
        Enter   = 0,
        Sure    = 1
    };

    public enum ComdOfButB
    {
        UpDown = 0,
        Change = 1
    };

   public struct MonthData
    {
      public int month;
      public int coins_month;
      public int tickets_month;
      public int gameTimes_month;
      public int upTimes_month;
    };

    #endregion

    public static string _savePath = Application.streamingAssetsPath + "//settingCoinfig.json";

    #region ----------------------------------------------------------各个页面信息-------------------------------------------------------------
    public static int confitshootingcalibreation    = 128;
    public static string[] screenes                 = { "GAME_CONFIG_SCREEN_WIDTH", "GAME_CONFIG_SCREEN_HEIGHT" };                         
    public static string isfirsetopengame           = "GAME_CONFIG_IS_FIRST_OPEN";
    public static string numberofgame               = "GAME_CONFIG_NUMBER_OF_GAME";
    public static string[] monthInfo                = { "GAME_CONFIG_THIS_MONTH","GAME_CONFIG_ONE_MONTH_AGO","GAME_CONFIG_TWO_MONTH_AGO"};
    public static string[] settingpageInfo          = { "GAME_CONFIG_PER_USE_COIN", "GAME_CONFIG_VOLUME", "GAME_CONFIG_DIFFICULTY",
                                                      "GAME_CONFIG_LANGUAGE","GAME_CONFIG_PER_TICKET_SCORE","GAME_CONFIG_WATER_SHOW" };
    public static string[] coins_month              = { "GAME_CONFIG_THIS_MONTH_COINS","GAME_CONFIG_ONE_MONTH_AGO_COINS","GAME_CONFIG_TWO_AGO_COINS"};
    public static string[] tickets_month            = { "GAME_CONFIG_THIS_MONTH_TICKETS","GAME_CONFIG_ONE_MONTH_AGO_TICKETS","GAME_CONFIG_TWO_MONTH_AGO_TICKETS"};
    public static string[] gametimes_month          = { "GAME_CONFIG_THIS_MONTH_GAME_TIMES", "GAME_CONFIG_ONE_MONTH_AGO_GAME_TIMES", "GAME_CONFIG_TWO_MONTH_AGO_GAME_TIMES" };
    public static string[] uptimes_month            = { "GAME_CONFIG_THIS_MONTH_UP_TIMES", "GAME_CONFIG_ONE_MONTH_AGO_UP_TIMES", "GAME_CONFIG_TOW_MONTH_AGO_UP_TIMES" };
    public static string[] englishmonthes           = { "January", "February", "march", "April", "May", "June", "July", 
                                                       "August", "September", "October", "November", "December" };
    public static int[] money                       = { 1, 2, 3, 4, 5, 6, 0 };
    public static int[] level                       = { 1, 2, 3 };
    public static int[] volume                      = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    public static string[] language                 = { "中文", "英文" };
    public static string[] watershow                = { "NO", "OFF" };
    public static string[,] clearcoin               = { { "是", "否" }, { "Yes", "No" } };
    public static string[,] homeName                = { { "    设定", "    查账", "    退出"}, { "  Set", "  Account", "  Exit" } };
    public static string[,] setName                 = { {"    游戏币率","    游戏音量","    游戏难度","    游戏语言","    射击校验","    出票设置",
                                                         "    退出","    显示水标", "    清除投币","设定"},
                                                      {"    Coin","    Volume","    Level","    Language","    Shooting Calibration",
                                                                         "    Ticket Settings","    Exit","    Water Show",     "    Clear Coin","Set"} };
    public static string[,] calibrationName         = { { "    玩家 1" ,  "    玩家 2" ,"    玩家 3","    退出","设定校准"},
                                                        {"    Player 1","    Player 2","    Player 3","    Exit","Shooting Calibration"}};
    public static string[,] accountName             = { { "    营业记录", "    总记录", "    数据清零", "    退出", "    查账" },
                                                      { "    Business Records", "    Total Record", "    Data Rest", "    Exit", "    Account" } };
    public static string[] setTicketLanguage        = { "分/1票","Scores/1 tickets"};
    public static int[] scorePreTicket              = { 2000,2500,3000,4000};
    public static string[,] businessRecordName      = { {"营业记录", "最近三个月记录", "投币数", "彩票数", "游戏时间", "开机时间","月记录", "月记录", "月记录"},
                                                        {"Business Record","Records The Last Three Months","Coins","Tickets","Game Time","Uptime","","",""}};
    public static string[,] totalRecordName         = { { "总记录", "游戏次数：", "总游戏时间：", "总开机时间：", "总投币数：", "总出票数：" },
                                                        { "Total Records", "Game Times:", "Total Game Times:", "Uptime:", "Total Coins:", "Total Tickets:"} };
    public static string[,] dataResetName           = { {"    是", "    否","数据清零？" },{    "    Yes","    No","Data Rest?"}};

    public static string[] playerCoin               = { "GAME_COINFIG_PLEYER0_COIN", "GAME_COINFIG_PLEYER1_COIN", "GAME_COINFIG_PLEYER2_COIN" };

    #endregion  --------------------------------------------------------------------------------------------------------------------
}
