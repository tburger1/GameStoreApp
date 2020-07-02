/*************************************************************************/
/* Program Name:     ProjectGUI.cs                                       */
/* Date:             3/20/2019                                           */
/* Programmer:       Tyler Burger                                        */
/* Class:            CSCI 234                                            */
/*                                                                       */
/* Program Description: This app allows users to access the database for */
/*                      a fictional game store that keeps track of the   */
/*                      point of sales for video games, customers who    */
/*                      are memebers of the store, and the orders        */
/*                      placed by the customer.                          */
/*                                                                       */
/* Input:   User interacts with menu items, textboxes, buttons, and      */
/*          comboboxes.		                                             */
/*                                                                       */
/* Output:  Modifications to the database; save, open, delete, undelete, */
/*          purge, and exit application.                                 */
/*                                                                       */
/* Givens:  Example: Sample ProjectGUI                                   */
/*                                                                       */
/* Testing Data: Everything on the form is interactable, all controlled  */
/*               by user input.                                          */
/*************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGUI
{
    static class ProjectGUI
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OrderForm());
        }
    }
}
