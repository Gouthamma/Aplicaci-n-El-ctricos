using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook;
using System.Reflection;

namespace CapaNegocio
{
    public class NCorreo
    {
        public static int Main(string[] args)
        {
            try
            {
                // Create the Outlook application.
                // in-line initialization
                Outlook.Application oApp = new Outlook.Application();

                // Get the MAPI namespace.
                Outlook.NameSpace oNS = oApp.GetNamespace("mapi");

                // Log on by using the default profile or existing session (no dialog box).
                oNS.Logon(Missing.Value, Missing.Value, false, true);

                // Alternate logon method that uses a specific profile name.
                // TODO: If you use this logon method, specify the correct profile name
                // and comment the previous Logon line.
                //oNS.Logon("profilename",Missing.Value,false,true);

                //Get the Inbox folder.
                Outlook.MAPIFolder oInbox = oNS.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox);

                //Get the Items collection in the Inbox folder.
                Outlook.Items oItems = oInbox.Items;

                // Get the first message.
                // Because the Items folder may contain different item types,
                // use explicit typecasting with the assignment.
                Outlook.MailItem oMsg = (Outlook.MailItem)oItems.GetFirst();

                //Output some common properties.
                Console.WriteLine(oMsg.Subject);
                Console.WriteLine(oMsg.SenderName);
                Console.WriteLine(oMsg.ReceivedTime);
                Console.WriteLine(oMsg.Body);

                //Check for attachments.
                int AttachCnt = oMsg.Attachments.Count;
                Console.WriteLine("Attachments: " + AttachCnt.ToString());

                //TO DO: If you use the Microsoft Outlook 10.0 Object Library, uncomment the following lines.
                /*if (AttachCnt > 0) 
				{
					for (int i = 1; i <= AttachCnt; i++) 
						 Console.WriteLine(i.ToString() + "-" + oMsg.Attachments.Item(i).DisplayName);
				}*/

                //TO DO: If you use the Microsoft Outlook 11.0 Object Library, uncomment the following lines.
                /*if (AttachCnt > 0) 
				{
					for (int i = 1; i <= AttachCnt; i++) 
						 Console.WriteLine(i.ToString() + "-" + oMsg.Attachments[i].DisplayName);
				}*/


                //Display the message.
                oMsg.Display(true);  //modal

                //Log off.
                oNS.Logoff();

                //Explicitly release objects.
                oMsg = null;
                oItems = null;
                oInbox = null;
                oNS = null;
                oApp = null;
            }

            //Error handler.
            catch (SystemException e)
            {
                Console.WriteLine("{0} Exception caught: ", e);
            }

            // Return value.	
            return 0;

        }
    }
}
