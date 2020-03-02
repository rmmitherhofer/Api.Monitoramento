using System.Xml.Serialization;

namespace Api.Monitoramento.Domain.DTO
{

    [XmlType("HardwareMonitoramentoApi")]
    public class HardwareMonitoramentoApi
    {
        public string Computer_Name { get; set; }
        public string Department_Name { get; set; }
        public string SO_String { get; set; }
        public string System_Manufacturer { get; set; }
        public string Computer_Type { get; set; }
        public string Machine_Net_IPAddress { get; set; }
        public string Bios_Release_Date { get; set; }
        public string Machine_IPDomain { get; set; }
        public string Is_Virtual_Machine { get; set; }
        public string System_Product_Name { get; set; }
        public string System_Serial_Number { get; set; }
        public string Machine_ID { get; set; }
        public string OS_Bits { get; set; }
        public string Login_Name { get; set; }
        public string CPU_Identity { get; set; }
        public string CPU_Generation { get; set; }
        public string CPU_Type { get; set; }
        public string CPU_Clock { get; set; }
        public string Core_Num { get; set; }
        public string Physical_CPU_Amount { get; set; }
        public string Logical_CPU { get; set; }
        public string Memory_Range { get; set; }
        public string Disk_Total { get; set; }
        public string Disk_Used { get; set; }
        public string Top_User { get; set; }
        public string Percent_Top_User { get; set; }
        public string DNS_Servers { get; set; }
        public string Machine_Gateway { get; set; }
        public string Collect_Date { get; set; }
        public string Update_Date { get; set; }
        public string Last_Login { get; set; }
    }
}