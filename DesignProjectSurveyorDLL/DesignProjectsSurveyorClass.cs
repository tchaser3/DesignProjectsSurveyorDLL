/* Title:           Design Projects Surveyor Class
 * Date:            1-17-19
 * Author:          Terry Holmes
 * 
 * Description:     This class is used for the WOV Report */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace DesignProjectSurveyorDLL
{
    public class DesignProjectsSurveyorClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        DesignProjectsSurveyorDataSet aDesignProjectsSurveyorDataSet;
        DesignProjectsSurveyorDataSetTableAdapters.designprojectsurveyorTableAdapter aDesignProjectsSurveyorTableAdapter;

        InsertDesignProjectSurveyorEntryTableAdapters.QueriesTableAdapter aInsertDesignProjectSurveyorTableAdapter;

        UpdateDesignProjectSurveyorWOVStatusEntryTableAdapters.QueriesTableAdapter aUpdateDesignProjectSurveyorWOVStatusTableAdapter;

        UpdateDesignProjectSurveyorNotesEntryTableAdapters.QueriesTableAdapter aUpdateDesignProjectSurveyorNotesTableAdapter;

        CloseDesignProjectSurveyorRecordEntryTableAdapters.QueriesTableAdapter aCloseDesignProjectSurveyorRecordTableAdapter;

        FindOpenDesignProjectSurveyorRecordsDataSet aFindOpenDesignProjectSurveyorRecordsDataSet;
        FindOpenDesignProjectSurveyorRecordsDataSetTableAdapters.FindOpenDesignProjectSurveyorRecordsTableAdapter aFindOpenDesignProjectSurveyorRecordsTableAdapter;

        FindCurrentDesignProjectRecordDataSet aFindCurrentDesignProjectRecordDataSet;
        FindCurrentDesignProjectRecordDataSetTableAdapters.FindCurrentDesignProjectSurveyorRecordTableAdapter aFindCurrentDesignProjectRecordTableAdatper;

        FindDesignProjectSurveyorByProjectIDDataSet aFindDesignProjectSurveyorByProjectIDDataSet;
        FindDesignProjectSurveyorByProjectIDDataSetTableAdapters.FindDesignProjectSurveyorByProjectIDTableAdapter aFindDesignProjectSurveyorByProjectIDTableAdapter;

        FindOpenDesignProjectSurveyorBySurveyorIDDataSet aFindOpenDesignProjectSurveyorBySurveyorIDDataSet;
        FindOpenDesignProjectSurveyorBySurveyorIDDataSetTableAdapters.FindOpenDesignProjectSurveyorBySurveyorIDTableAdapter aFindOpenDesignProjectSurveyorBySurveyorIDTableAdapter;

        FindOpenDesignProjectSurveyorByProjectIDDataSet aFindOpenDesignProjectSurveyorByProjectIDDataSet;
        FindOpenDesignProjectSurveyorByProjectIDDataSetTableAdapters.FindOpenDesignProjectSurveryorByProjectIDTableAdapter aFindOpenDesignProjectSurveyorByProjectIDTableAdapter;

        FindDesignEmployeeWOVCountDataSet aFindDesignEmployeeWOVCountDataSet;
        FindDesignEmployeeWOVCountDataSetTableAdapters.FindDesignEmployeeWOVCountTableAdapter aFindDesignEmployeeWOVCountTableAdapter;

        FindDesignDepartmentWOVCountDataSet aFindDesignDepartmentWOVCountDataSet;
        FindDesignDepartmentWOVCountDataSetTableAdapters.FindDesignDepartmentWOVCountTableAdapter aFindDesignDepartmentWOVCountTableAdapter;

        public FindDesignDepartmentWOVCountDataSet FindDesignDepartmentWOVCount(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDesignDepartmentWOVCountDataSet = new FindDesignDepartmentWOVCountDataSet();
                aFindDesignDepartmentWOVCountTableAdapter = new FindDesignDepartmentWOVCountDataSetTableAdapters.FindDesignDepartmentWOVCountTableAdapter();
                aFindDesignDepartmentWOVCountTableAdapter.Fill(aFindDesignDepartmentWOVCountDataSet.FindDesignDepartmentWOVCount, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Project Surveryor Class // Find Design Department WOV Count " + Ex.Message);
            }

            return aFindDesignDepartmentWOVCountDataSet;
        }
        public FindDesignEmployeeWOVCountDataSet FindDesignEmployeeWOVCount(int intEmployeeID, DateTime datStartDate, DateTime dateEndDate)
        {
            try
            {
                aFindDesignEmployeeWOVCountDataSet = new FindDesignEmployeeWOVCountDataSet();
                aFindDesignEmployeeWOVCountTableAdapter = new FindDesignEmployeeWOVCountDataSetTableAdapters.FindDesignEmployeeWOVCountTableAdapter();
                aFindDesignEmployeeWOVCountTableAdapter.Fill(aFindDesignEmployeeWOVCountDataSet.FindDesignEmployeeWOVCount, intEmployeeID, datStartDate, dateEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Projects Surveyor Class // Find Design Employee WOV Count " + Ex.Message);
            }

            return aFindDesignEmployeeWOVCountDataSet;
        }
        public FindOpenDesignProjectSurveyorByProjectIDDataSet FindOpenDesignProjectSurveyorByProjectID(int intProjectID)
        {
            try
            {
                aFindOpenDesignProjectSurveyorByProjectIDDataSet = new FindOpenDesignProjectSurveyorByProjectIDDataSet();
                aFindOpenDesignProjectSurveyorByProjectIDTableAdapter = new FindOpenDesignProjectSurveyorByProjectIDDataSetTableAdapters.FindOpenDesignProjectSurveryorByProjectIDTableAdapter();
                aFindOpenDesignProjectSurveyorByProjectIDTableAdapter.Fill(aFindOpenDesignProjectSurveyorByProjectIDDataSet.FindOpenDesignProjectSurveryorByProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Project Surveyor Class // Find Open Design Project Surveyor By Project ID " + Ex.Message);
            }

            return aFindOpenDesignProjectSurveyorByProjectIDDataSet;
        }
        public FindOpenDesignProjectSurveyorBySurveyorIDDataSet FindOpenDesignProjectSurveyorBySurveyorID(int intSurveyorID)
        {
            try
            {
                aFindOpenDesignProjectSurveyorBySurveyorIDDataSet = new FindOpenDesignProjectSurveyorBySurveyorIDDataSet();
                aFindOpenDesignProjectSurveyorBySurveyorIDTableAdapter = new FindOpenDesignProjectSurveyorBySurveyorIDDataSetTableAdapters.FindOpenDesignProjectSurveyorBySurveyorIDTableAdapter();
                aFindOpenDesignProjectSurveyorBySurveyorIDTableAdapter.Fill(aFindOpenDesignProjectSurveyorBySurveyorIDDataSet.FindOpenDesignProjectSurveyorBySurveyorID, intSurveyorID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Project Surveyor Class // Find Open Design Project Surveyor By Surveyor ID " + Ex.Message);
            }

            return aFindOpenDesignProjectSurveyorBySurveyorIDDataSet;
        }
        public FindDesignProjectSurveyorByProjectIDDataSet FindDesignProjectSurveyorByProjectID(int intProjectID)
        {
            try
            {
                aFindDesignProjectSurveyorByProjectIDDataSet = new FindDesignProjectSurveyorByProjectIDDataSet();
                aFindDesignProjectSurveyorByProjectIDTableAdapter = new FindDesignProjectSurveyorByProjectIDDataSetTableAdapters.FindDesignProjectSurveyorByProjectIDTableAdapter();
                aFindDesignProjectSurveyorByProjectIDTableAdapter.Fill(aFindDesignProjectSurveyorByProjectIDDataSet.FindDesignProjectSurveyorByProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Projects Surveyor Class // Find Design Project Surveyor By Project ID " + Ex.Message);
            }

            return aFindDesignProjectSurveyorByProjectIDDataSet;
        }
        public FindCurrentDesignProjectRecordDataSet FindCurrentDesignProjectRecord(int intProjectID)
        {
            try
            {
                aFindCurrentDesignProjectRecordDataSet = new FindCurrentDesignProjectRecordDataSet();
                aFindCurrentDesignProjectRecordTableAdatper = new FindCurrentDesignProjectRecordDataSetTableAdapters.FindCurrentDesignProjectSurveyorRecordTableAdapter();
                aFindCurrentDesignProjectRecordTableAdatper.Fill(aFindCurrentDesignProjectRecordDataSet.FindCurrentDesignProjectSurveyorRecord, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, " Design Project Surveyor Class // Find Current Design Project Record " + Ex.Message);
            }

            return aFindCurrentDesignProjectRecordDataSet;
        }
        public FindOpenDesignProjectSurveyorRecordsDataSet FindOpenDesignProjectSurveyorRecords()
        {
            try
            {
                aFindOpenDesignProjectSurveyorRecordsDataSet = new FindOpenDesignProjectSurveyorRecordsDataSet();
                aFindOpenDesignProjectSurveyorRecordsTableAdapter = new FindOpenDesignProjectSurveyorRecordsDataSetTableAdapters.FindOpenDesignProjectSurveyorRecordsTableAdapter();
                aFindOpenDesignProjectSurveyorRecordsTableAdapter.Fill(aFindOpenDesignProjectSurveyorRecordsDataSet.FindOpenDesignProjectSurveyorRecords);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Projects Surveyor Class // Find Open Design Project Surveyor Records " + Ex.Message);
            }

            return aFindOpenDesignProjectSurveyorRecordsDataSet;
        }
        public bool CloseDesignProjectSurveyorRecord(int intTransactionID, DateTime datCompletionDate, string strSurveyorNotes)
        {
            bool blnFatalError = false;

            try
            {
                aCloseDesignProjectSurveyorRecordTableAdapter = new CloseDesignProjectSurveyorRecordEntryTableAdapters.QueriesTableAdapter();
                aCloseDesignProjectSurveyorRecordTableAdapter.CloseDesignProjectSurveyorRecord(intTransactionID, datCompletionDate, strSurveyorNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Close Design Project Surveyor Record " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateDesignSurveyorNotes(int intTransactionID, string strSurveyorNotes)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateDesignProjectSurveyorNotesTableAdapter = new UpdateDesignProjectSurveyorNotesEntryTableAdapters.QueriesTableAdapter();
                aUpdateDesignProjectSurveyorNotesTableAdapter.UpdateDesignProjectSurveyorNotes(intTransactionID, strSurveyorNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Project Surveyor Class // Update Design Surveyor Notes " + Ex.Message);

                blnFatalError = true; 
            }

            return blnFatalError;
        }
        public bool UpdateDesignProjectSurveyorWOVStatus(int intTransactionID, string strWOVStatus, string strSurveyorNotes)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateDesignProjectSurveyorWOVStatusTableAdapter = new UpdateDesignProjectSurveyorWOVStatusEntryTableAdapters.QueriesTableAdapter();
                aUpdateDesignProjectSurveyorWOVStatusTableAdapter.UpdateDesignProjectSurveyorWOVStatus(intTransactionID, strWOVStatus, strSurveyorNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Project Surveryor Class // Update Design Project Surveyor WOV " + Ex.Message);

                blnFatalError = true;
            }             

            return blnFatalError;
        }
        public bool InsertProjectSurveyor(int intProjectID, int intSurveyorID, int intEmployeeID, DateTime datAssignedDate, string strSurveyorNotes, string strWOVStatus)
        {
            bool blnFatalError = false;

            try
            {
                aInsertDesignProjectSurveyorTableAdapter = new InsertDesignProjectSurveyorEntryTableAdapters.QueriesTableAdapter();
                aInsertDesignProjectSurveyorTableAdapter.InsertDesignProjectSurveyor(intProjectID, intSurveyorID, intEmployeeID, datAssignedDate, strSurveyorNotes, strWOVStatus);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Projects Surveyor // Insert Design Project Surveyor " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public DesignProjectsSurveyorDataSet GetDesignProjectsSurveyorInfo()
        {
            try
            {
                aDesignProjectsSurveyorDataSet = new DesignProjectsSurveyorDataSet();
                aDesignProjectsSurveyorTableAdapter = new DesignProjectsSurveyorDataSetTableAdapters.designprojectsurveyorTableAdapter();
                aDesignProjectsSurveyorTableAdapter.Fill(aDesignProjectsSurveyorDataSet.designprojectsurveyor);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Surveyor Class // Get Design Projects Surveyor Info " + Ex.Message);
            }

            return aDesignProjectsSurveyorDataSet;
        }
        public void UpdateDesignProjectsSurveyorDB(DesignProjectsSurveyorDataSet aDesignProjectsSurveyorDataSet)
        {
            try
            {
                aDesignProjectsSurveyorTableAdapter = new DesignProjectsSurveyorDataSetTableAdapters.designprojectsurveyorTableAdapter();
                aDesignProjectsSurveyorTableAdapter.Update(aDesignProjectsSurveyorDataSet.designprojectsurveyor);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Surveyor Class // Update Design Projects Surveyor DB" + Ex.Message);
            }
        }
    }
}
