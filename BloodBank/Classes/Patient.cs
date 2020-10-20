﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BloodBank
{
    //patient class contains patient's attributes
    //Patient class inherit all properties and method from Person class according to their visiblity
    class Patient : Person
    {
       private string hospitalName, doctor, history, requiredBloodUnit, hospitalPhoneNo, patientRegdNo;
       private int noRequiredUnit;
        //set and get method to set values and to return the value of defind variables
        public string HospitalName { get => hospitalName; set => hospitalName = value; }
        public string Doctor { get => doctor; set => doctor = value; }
        public string History { get => history; set => history = value; }
        public string RequiredBloodUnit { get => requiredBloodUnit; set => requiredBloodUnit = value; }
        public string HospitalPhoneNo { get => hospitalPhoneNo; set => hospitalPhoneNo = value; }
        public string PatientRegdNo { get => patientRegdNo; set => patientRegdNo = value; }
        public int NoRequiredUnit { get => noRequiredUnit; set => noRequiredUnit = value; }

        private MySqlCommand cmd;
        private MySqlDataAdapter adapter;
        
        //method to insert values to database
        #region INSERT DONOR
        public void addPatient(Patient ob)
        {
            //SQL STMT
            string sql = "INSERT INTO blood_bank.patient(first_name, last_name, sex, dob, weight, abo_group, rh, hospital_name, hospital_phone_no, patient_regd,doctor_incharge, previous_transfusion, blood_unit, no_of_unit, phone_no, email, patient_address, date) VALUES('" + ob.FName + "', '" + ob.LName + "', '" + ob.Sex + "', '" + ob.DOB1 + "', '" + ob.Weight + "','" + ob.AboGroup + "', '" + ob.RH1 + "', '" + ob.HospitalName+ "', '" + ob.HospitalPhoneNo + "', '" + ob.PatientRegdNo + "', '" + ob.Doctor + "', '" + ob.History + "', '" + ob.requiredBloodUnit + "', '" + ob.NoRequiredUnit + "','" + ob.PhoneNo + "', '" + ob.Email + "', '" + ob.Address + "', '" + ob.Date + "')";
            //This is command class which will handle the query and connection object.  
            cmd = new MySqlCommand(sql, DBConnection.get_conn());
            //open con and exec insert
            try
            {
                DBConnection.get_conn().Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfully Inserted!");
                }

                DBConnection.get_conn().Close();
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
            string sql = "SELECT * FROM blood_bank.patient;"; // set query to fetch data "Select * from  tabelname"; 

            adapter = new MySqlDataAdapter(sql, DBConnection.get_conn());

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
        #endregion
        /*
       #region UPDATE THE DATABASE
       public void update(Donor ob, int id)
       {
           string sql = "UPDATE blood_bank.patient SET first_name='" + ob.FName + "',last_name='" + ob.LName + "',sex='" + ob.Sex + "',dob='" + ob.DOB1 + "',abo_group='" + ob.AboGroup + "',rh='" + ob.RH1 + "',weight='" + ob.Weight + "',phone_no='" + ob.PhoneNo + "',email='" + ob.Email + "',address='" + ob.Address + "',occupation='" + ob.occupation + "',last_time_donation='" + ob.Date + "' WHERE donor_id = '" + id + "';";
           cmd = new MySqlCommand(sql, DBConnection.get_conn());

           try
           {
               DBConnection.get_conn().Open();
               adapter = new MySqlDataAdapter(cmd);

               adapter.UpdateCommand = DBConnection.get_conn().CreateCommand();
               adapter.UpdateCommand.CommandText = sql;

               if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
               {
                   if (MessageBox.Show("Successfully Updated!") == DialogResult.OK)
                   {
                       //Dashboard db = new Dashboard();
                       // db.btn_donorView.Click;
                   }
               }
               DBConnection.get_conn().Close();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
               DBConnection.get_conn().Close();
           }
       }
       #endregion

       #region DELETE FROM DATABASE
       public void delete(int id)
       {

           string sql = "DELETE FROM blood_bank.patient WHERE donor_id = '" + id + "';";
           cmd = new MySqlCommand(sql, DBConnection.get_conn());

           try
           {
               DBConnection.get_conn().Open();
               adapter = new MySqlDataAdapter(cmd);

               adapter.DeleteCommand = DBConnection.get_conn().CreateCommand();
               adapter.DeleteCommand.CommandText = sql;

               if (MessageBox.Show("Sure?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
               {
                   if (cmd.ExecuteNonQuery() > 0)
                   {
                       MessageBox.Show("Successfully Deleted!");
                   }
               }
               DBConnection.get_conn().Close();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
               DBConnection.get_conn().Close();
           }
           retrieve();
       }
       #endregion
   */

    }
}
