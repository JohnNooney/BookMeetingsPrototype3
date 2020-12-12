﻿using BookMeetingsPrototype2.Views;
using BookMeetingsPrototype2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BookMeetingsPrototype2.ViewModels.ModelClasses; //used for setting the user as a Participant object
using BookMeetingsPrototype2.Views.DialogBox;

namespace BookMeetingsPrototype2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //set up connection object
        TayMarkDataDataContext db = new TayMarkDataDataContext(Properties.Settings.Default.sql1803534ConnectionString);

        public MainWindow() //add parameter later for user login****
        {
            InitializeComponent();
            startingView();
            User();
            
        }


        //sets up the user ID 
        private Participant User()
        {
            //*** remove later but this will set the user as first user in database
            //var userInfo = (from emps in db.TayMarkEmployees
            //              select emps);

            var userInfo = db.TayMarkEmployees.OrderBy(emp => emp.empId).Skip(1).Take(1).FirstOrDefault();

            Participant _user = new Participant() { EmpId = userInfo.empId, Name = userInfo.name};

            return _user;
        }

        private void startingView()
        {
            //set the display name
            //displayName.Text = name;

            //set defualt display menu to the home view
            UserControl usc = new UserControlHome();
            GridMain.Children.Add(usc);
            //set the starting data context to the home view
            this.DataContext = new HomeModel(User());
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //update name of the account 
            //query the db for the name associate with the account
            //var acc = (from ac in db.Accounts
            //           where ac.account_id == accountId
            //           select ac).Single();

            //update the display name
            //displayName.Text = acc.name;

            //create the user control object to be used for changing the views
            UserControl usc = null;
            GridMain.Children.Clear();


            //DataContext = new UserHomeModel();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemHome":
                    usc = new UserControlHome();
                    GridMain.Children.Add(usc);
                    DataContext = new HomeModel(User()); //send the user data to home model to be used
                    break;
                case "ItemNotify":
                    usc = new UserControlNotify();
                    GridMain.Children.Add(usc);
                    DataContext = new NotifyModel(User()); //send the user data to notify model to be used
                    break;
                case "ItemBook":
                    usc = new UserControlBooking();
                    GridMain.Children.Add(usc);
                    DataContext = new BookingModel(User()); //send the user data to booking model to be used
                    break;
                default:

                    break;
            }
        }

        private void ButtonPopUpAdmin_Click(object sender, RoutedEventArgs e)
        {
            //query the db if the logged in user is a verified admin
            var adminCheck = (from admin in db.TayMarkAdmins
                              where admin.empId == User().EmpId
                              select admin);

            //check that the user is a verified admin
            if(adminCheck.Any())
            {
                //bring up message box that prompts to enter admin password 
                //in order to access admin panel
                var dialog = new AdminDialog();
                if (dialog.ShowDialog() == true)
                {
                    //MessageBox.Show("You said: " + dialog.Password);
                    UserControl usc = new UserControlAdmin();
                    GridMain.Children.Add(usc);
                    DataContext = new AdminModel(User());
                }
            }
            else
            {
                MessageBox.Show("Admin status required to proceed.");
            }
        }
    }
}

