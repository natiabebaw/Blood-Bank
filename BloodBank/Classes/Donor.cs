﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBank;
using BloodBank;

namespace BloodBank
{
    //Donor class contains donor's attributes
    //Donor class inherit all properties and method from Person class according to their visiblity
    class Donor : Person 
    {
        private MySqlCommand cmd;
        private MySqlDataAdapter adapter;
        private string occupation, donation_date;
        Blood bl = new Blood();
        //set and get method to set values and to return the value of defind variables
        public string Occupation { 
            get => occupation; 
            set => occupation = value;
        }
        public string Donation_date { get => donation_date; set => donation_date = value; }


        //method to insert values to database
        #region INSERT DONOR
        public void addDonner(Donor ob)
        {
            //SQL STMT
            string sql = "INSERT INTO `blood_bank`.`donor`(first_name, last_name,sex, dob, abo_group, rh, weight, phone_no,email, address, occupation, last_time_donation,date) VALUES('" + ob.FName+"', '"+ob.LName+"', '"+ob.Sex+"', '"+ob.DOB1+"', '"+ob.AboGroup+"', '"+ob.RH1+"', '"+ob.Weight+"', '"+ob.PhoneNo+"', '"+ob.Email+"', '"+ob.Address+"', '"+ob.occupation+"', '"+ob.Date+"', '"+ob.donation_date+"')";
            //This is command class which will handle the query and connection object.  
            cmd = new MySqlCommand(sql, DBConnection.get_conn());
            //open con and exec insert
            try
            {
                DBConnection.get_conn().Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfully Inserted into Donor Database!", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
                DBConnection.get_conn().Close();
                if (ob.AboGroup == "A")
                {
                    bl.update(1, 1, "no_of_donation");
                }
                else if (ob.AboGroup == "B")
                {
                    bl.update(2, 1, "no_of_donation");
                }
                if (ob.AboGroup == "AB")
                {
                    bl.update(3, 1, "no_of_donation");
                }
                if (ob.AboGroup == "O")
                {
                    bl.update(4, 1, "no_of_donation");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DBConnection.get_conn().Close();
            }

            
        }
        #endregion

        #region RETRIEVE DATA FROM DB
        public DataSet retrieve()
        {
            //string connectionString = ""; //Set your MySQL connection string here.
            string sql = "SELECT * FROM `blood_bank`.`donor`;"; // set query to fetch data "Select * from  tabelname"; 
            
            adapter = new MySqlDataAdapter(sql, DBConnection.get_conn());
                
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    return ds;
        }
        #endregion

        #region UPDATE THE DATABASE
        public void update(Donor ob,int id)
        {
            string sql = "UPDATE `blood_bank`.`donor` SET first_name='" + ob.FName+ "',last_name='"+ob.LName+ "',sex='"+ob.Sex+ "',dob='"+ob.DOB1+ "',abo_group='"+ob.AboGroup+ "',rh='"+ob.RH1+ "',weight='"+ob.Weight+ "',phone_no='"+ob.PhoneNo+ "',email='"+ob.Email+ "',address='"+ob.Address+ "',occupation='"+ob.occupation+ "',last_time_donation='"+ob.Date+"', date='"+ob.Donation_date+"' WHERE donor_id = '"+id+"';";
            cmd = new MySqlCommand(sql, DBConnection.get_conn());

            try
            {
                DBConnection.get_conn().Open();
                adapter = new MySqlDataAdapter(cmd);

                adapter.UpdateCommand = DBConnection.get_conn().CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    if(MessageBox.Show("Successfully Updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                         //Dashboard db = new Dashboard();
                        // db.btn_donorView.Click;
                    }
                }
                DBConnection.get_conn().Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                DBConnection.get_conn().Close();
            }
        }
        #endregion

        #region DELETE FROM DATABASE
        public void delete(int id, string aboGroup)
        {

            string sql = "DELETE FROM `blood_bank`.`donor` WHERE donor_id = '" + id + "';";
            cmd = new MySqlCommand(sql, DBConnection.get_conn());

            try
            {
                DBConnection.get_conn().Open();
                adapter = new MySqlDataAdapter(cmd);

                adapter.DeleteCommand = DBConnection.get_conn().CreateCommand();
                adapter.DeleteCommand.CommandText = sql;

                if (MessageBox.Show($"Are you sure you want to Delete id {id}?", "Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                }
                DBConnection.get_conn().Close();
                if (aboGroup == "A")
                {
                    bl.update(1, 0, "no_of_donation");
                }
                else if (aboGroup == "B")
                {
                    bl.update(2, 0, "no_of_donation");
                }
                if (aboGroup == "AB")
                {
                    bl.update(3, 0, "no_of_donation");
                }
                if (aboGroup == "O")
                {
                    bl.update(4, 0, "no_of_donation");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DBConnection.get_conn().Close();
            }
        }
        #endregion


    }
}
