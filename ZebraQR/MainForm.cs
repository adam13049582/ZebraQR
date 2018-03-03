/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 26.02.2018
 * Time: 21:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;           
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace ZebraQR
{

	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		} 
		
		   
		static string []ZPLString;
         static string []row1;
         static string []row2;
         static string []row3;
         static string []row4;
         static string []row5;
         static int rw = 0;
         static int cl = 0;
         static int pocz = 0;   
         static int kon = 0;   
         static int licz = 0; 
     static string plik;
     static Thread watek;
     
   Microsoft.Office.Interop.Excel.Application xlApp;
             Workbook xlWorkBook;
            _Worksheet xlWorkSheet;
            Range xlRange;     
     
public bool SendStringToPrinter( String printerName)
        {
    int port = 9100;
    
    licz=kon-pocz;
    ZPLString=new string[licz+1];

    for(int j=0;j<licz+1;j++){
        ZPLString[j] =
"^XA"+
"^POI"+
"^CI28"+
"^FO40,110"+                            //położenie QR code
"^BQ,2,9^"+                                //wielkość kodu
"FDQA,"+row1[j]+"^FS"+                 //zawartość  QR
 "^FO270,120"+                            //położenie kodu tego samego co w QR
 "^A0N35,35"+                             //wielkość czcionki kodu tego samego co w QR
 "^FD"+row1[j]+"^FS"+                    //zawartość kodu tego samego co w QR
 "^FO270,160"+                            //położenie urządzenia
 "^A0N30,30"+                             //wielkość czcionki urządzenia
"^FD"+row2[j]+"^FS"+        //zawartość urządzenia
"^FO270,200"+                            //położenie IT TEAM
 "^A0N32,32"+                             //wielkość IT TEAM
"^FD"+row3[j]+"^FS"+
"^FO270,240"+                            //położenie ASSET TAG
 "^A0N45,45"+                             //wielkość ASSET TAG
"^FD"+row4[j]+"^FS"+
"^FO270,290"+                            //położenie serialnumber
 "^A0N32,32"+                             //wielkość czcionki serialnumber
"^FD"+row5[j]+"^FS"+
 "^XZ";

  }
    
   
try
{
    System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient();
    client.Connect(printerName, port);  
    
      // Write ZPL String to connection
    System.IO.StreamWriter writer = new System.IO.StreamWriter(client.GetStream());

    for(int i=0;i<ZPLString.Length;i++){
        writer.Write(ZPLString[i]);
        writer.Flush();
    }
    // Close Connection
    writer.Close();
    client.Close();
    
    MessageBox.Show("Połączono z drukarką","Połączono",MessageBoxButtons.OK,MessageBoxIcon.Information);
}catch{ MessageBox.Show("Nie można nawiązać połączenia z drukarką","Nie połączono",MessageBoxButtons.OK,MessageBoxIcon.Information);}
      
            return true; }
            
public  void potwierdzenie(){
	  status.Invoke(new System.Action(delegate(){status.Text="Trwa przetwarzanie...";}));
            status.Invoke(new System.Action(delegate(){druk.Enabled=false;}));
    getExcelFile();
    
           DialogResult dialogButton=MessageBox.Show("Czy na pewno chcesz drukować "+(licz+1)+" naklejek?","Potwierdzenie",MessageBoxButtons.YesNo,MessageBoxIcon.Information);


  
           string adress=Convert.ToString(adres.Text);
    
            if(dialogButton==DialogResult.Yes){
               SendStringToPrinter(adress);
               }
        
            status.Invoke(new System.Action(delegate(){druk.Enabled=true;}));
             status.Invoke(new System.Action(delegate(){status.Text="";}));
}
public void getExcelFile()
        {

 plik=sciezka.Text;
    bool udane=false;
          
           try{
            xlApp = new Microsoft.Office.Interop.Excel.Application ();
            xlWorkBook = xlApp.Workbooks.Open (plik, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "" , false, false, 0, true, 1, 0);
xlWorkSheet = (_Worksheet) xlWorkBook.Worksheets.get_Item (1);    
            xlRange= xlWorkSheet.UsedRange;
            udane=true;
          
                        rw = xlRange.Rows.Count;
            cl = xlRange.Columns.Count;

            row1=new string[rw];
            row2=new string[rw];
            row3=new string[rw];
            row4=new string[rw];
            row5=new string[rw];
            
           

            pocz=Convert.ToInt32(pwiersz.Text);
            
            string ko=Convert.ToString(owiersz.Text);
    int porko=String.Compare(ko,"MAX",true);
    if(porko==0){
        kon=rw;
    }
    else{
    kon=int.Parse(ko);
    if(kon>rw){
        MessageBox.Show("Podałeś indeks numer większy niż ostatni indeks w tabeli, dlatego wydrukowane zostaną wszystkie wiersze od podanego przez Ciebie pierwszego, aż do końca tabeli.Jeśli tego nie chcesz zamknij aplikację, lub potem nie wyraź zgody na drukowanie","Zbyt duży numer ostatniego wiersza",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        kon=rw;
    }
    }
    licz=kon-pocz;
            
    //tworzenie tablic z elementami, które zostaną wydrukowane, w nawiasie kwadratowym pierwszy parametr to wiersz, a drugi to kolumna
    //QR code i ten obok ten sam

    			for(int i=0;i<licz+1;i++){
    			try{
    					row1[i] = (string) (xlRange.Cells [i+pocz, 1] as Range).Value2.ToString();
    			}catch{
    				row1[i]="";
    			}
              }
               //Urządzenie
              for(int i=0;i<licz+1;i++){
               	try{ 
               		row2[i] = (string) (xlRange.Cells [i+pocz, 2] as Range).Value2.ToString();
               	}catch{
               		row2[i]="";
               	}
               }
//IT TEAM
            for(int i=0;i<licz+1;i++){
				try{
					row3[i] = (string) (xlRange.Cells [i+pocz, 3] as Range).Value2.ToString();}
				catch{
					row3[i]="";}
			}

//ASSET TAG
     		for(int i=0;i<licz+1;i++){
				try{
                     row4[i] = (string) (xlRange.Cells [i+pocz, 4] as Range).Value2.ToString();
				}catch{
					row4[i]="";
				}
             }
                //SerialNumber
                for(int i=0;i<licz+1;i++){
                	try{  row5[i] = (string) (xlRange.Cells [i+pocz, 5] as Range).Value2.ToString();
                	}catch{
                		row5[i]="";
                	}
                }
  
           xlApp.Quit ();
          zakoncz(xlApp);
          Thread.Sleep(100);
           Marshal.ReleaseComObject (xlWorkSheet);
            Marshal.ReleaseComObject (xlWorkBook);
            Marshal.ReleaseComObject (xlApp); 
            xlWorkBook=null;
            xlApp=null;
            }
            catch{
                 MessageBox.Show("Nie można odnaleźć pliku, sprawdź czy podałeś poprawną lokalizację, nazwę oraz rozszerzenie","Nie można odnaleźć pliku",MessageBoxButtons.OK,MessageBoxIcon.Warning);          
      status.Invoke(new System.Action(delegate(){status.Text="";}));
            status.Invoke(new System.Action(delegate(){druk.Enabled=true;}));
            zakoncz(xlApp);
            watek.Join();
             
            }
           
}
		void drukuj(object sender, EventArgs e)
		{
		watek=new Thread(new ThreadStart(potwierdzenie));
		watek.Start();

		}
		void Close(object sender, FormClosedEventArgs e)
		{
		
	  System.Diagnostics.Process.GetCurrentProcess().Kill();
		}
		
		 [DllImport("User32.dll")]
    public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int ProcessId);
    private static void zakoncz(Microsoft.Office.Interop.Excel.Application app)
    {
        int id = 0;
        IntPtr intptr = new IntPtr(app.Hwnd);
        System.Diagnostics.Process p = null;
        try
        {
            GetWindowThreadProcessId(intptr, out id);
            p = System.Diagnostics.Process.GetProcessById(id);
            if (p != null)
            {
                p.Kill();
                p.Dispose();
            }
        }
        catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show("KillExcel:" + ex.Message);
        }
    }

	
	}
}
