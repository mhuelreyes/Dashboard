using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Pages
{
	public class IndexBase : ComponentBase
	{

		public static string ThisYear { get; set; } = DateTime.Now.Year.ToString();

		public string TodaySales_Column1_Label { get; set; } = "Room Sales";
		public string TodaySales_Column1_Data { get; set; } = "1,123.00";
		public string TodaySales_Column2_Label { get; set; } = "TNOG";
		public string TodaySales_Column2_Data { get; set; } = "10";
		public string TodaySales_Column3_Label { get; set; } = "FNB";
		public string TodaySales_Column3_Data { get; set; } = "1,232.00";
		public string TodaySales_Column4_Label { get; set; } = "FOG";
		public string TodaySales_Column4_Data { get; set; } = "20";
		public string TodaySales_Column5_Label { get; set; } = "Net Sales";
		public string TodaySales_Column5_Data { get; set; } = "1,323.00";


		public string ThisYearSales_Column1_Label { get; set; } = "Room Sales";
		public string ThisYearSales_Column1_Data { get; set; } = "1,523,123.00";
		public string ThisYearSales_Column2_Label { get; set; } = "TNOG";
		public string ThisYearSales_Column2_Data { get; set; } = "120";
		public string ThisYearSales_Column3_Label { get; set; } = "FNB";
		public string ThisYearSales_Column3_Data { get; set; } = "131,232.00";
		public string ThisYearSales_Column4_Label { get; set; } = "FOG";
		public string ThisYearSales_Column4_Data { get; set; } = "230";
		public string ThisYearSales_Column5_Label { get; set; } = "Net Sales";
		public string ThisYearSales_Column5_Data { get; set; } = "1,751,123.00";



		public string RoomStatus_Column1_Label { get; set; } = "Occupied";
		public string RoomStatus_Column1_Data { get; set; } = "10";
		public string RoomStatus_Column2_Label { get; set; } = "Dirty";
		public string RoomStatus_Column2_Data { get; set; } = "5";
		public string RoomStatus_Column3_Label { get; set; } = "Defective";
		public string RoomStatus_Column3_Data { get; set; } = "0";
		public string RoomStatus_Column4_Label { get; set; } = "Clean";
		public string RoomStatus_Column4_Data { get; set; } = "13";
		public string RoomStatus_Column5_Label { get; set; } = "Renovation";
		public string RoomStatus_Column5_Data { get; set; } = "0";

	}
}
