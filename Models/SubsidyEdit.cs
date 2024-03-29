﻿using System;
using System.Web;

namespace WebApplication1.Models
{
    public class SubsidyEdit
    {
        //核准金額
        public int s_approved_amount {  get; set; }
        //補件資料3審核狀態
        public string s_review_else3 { get; set; }
        //補件資料2審核狀態
        public string s_review_else2 { get; set; }
        //補件資料1審核狀態
        public string s_review_else { get; set; }
        //申請補助人員清冊審核狀態
        public string s_review_applicants { get; set; }
        //建立全公司勞保清冊審核狀態
        public string s_review_emp_lst { get; set; }
        //全公司勞保明細審核狀態
        public string s_review_insur_member { get; set; }
        //申請書審核狀態
        public string s_review_application {  get; set; }
        //補件資料2
        public HttpPostedFileBase s_else_two { get; set; }
        //補件資料名稱2
        public string s_else_two_name { get; set; }
        //補件資料2檔案名稱
        public string s_else_two_file { get; set; }
        //補件資料3
        public HttpPostedFileBase s_else_three { get; set; }
        //補件資料名稱3
        public string s_else_three_name { get; set; }
        //補件資料3檔案名稱
        public string s_else_three_file { get; set; }
        //申請日期(迄)
        public Nullable<System.DateTime> s_date_time_end { get; set; }
        //案號
        public string s_no { get; set; }
        //旅宿名稱
        public string id_name { get; set; }
        // 申請ID
        public int? s_id { get; set; }
        // 旅宿ID
        public int? id_id { get; set; }
        // 申請人數
        public int? EmpCount { get; set; }
        // 申請金額
        public int? Money { get; set; }
        // 申請日期
        public DateTime Date { get; set; }
        // 申請書
        public HttpPostedFileBase Application { get; set; }
        //申請書(檔案亂數名稱)
        public string ApplicationFile { get; set; }
        // 申請書(檔案名稱)
        public string ApplicationName { get; set; }
        // 勞保名冊
        public HttpPostedFileBase Labor { get; set; }
        //勞保名冊(檔案亂數名稱)
        public string LaborFile { get; set; }
        // 勞保名冊(檔案名稱)
        public string LaborName { get; set; }
        // 申請人員清冊
        public HttpPostedFileBase ApplicantsList { get; set; }
        // 申請人員清冊(檔案亂數名稱)
        public string ApplicantsListFile { get; set; }
        // 申請人員清冊(檔案名稱)
        public string ApplicantsListName { get; set; }
        // 切結書
        public HttpPostedFileBase Affidavit { get; set; }
        // 切結書(檔案亂數名稱)
        public string AffidavitFile { get; set; }
        // 切結書(檔案名稱)
        public string AffidavitName { get; set; }
        // 領據
        public HttpPostedFileBase Receipt { get; set; }
        // 領據(檔案亂數名稱)
        public string ReceiptFile { get; set; }
        // 領據(檔案名稱)
        public string ReceiptName { get; set; }
        // 員工清冊
        public HttpPostedFileBase EmployeeList { get; set; }
        // 員工清冊(檔案亂數名稱)
        public string EmployeeListFile { get; set; }
        // 員工清冊(檔案名稱)
        public string EmployeeListName { get; set; }
        // 其他檔案
        public HttpPostedFileBase OtherFile { get; set; }
        // 其他檔案(檔案亂數名稱)
        public string OtherFileFile { get; set; }
        // 其他檔案(檔案名稱)
        public string OtherFileName { get; set; }
        //審核狀態
        public string Review {  get; set; }

    }
}
