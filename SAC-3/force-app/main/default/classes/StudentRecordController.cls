// Apex Class
public class StudentRecordController {

    @AuraEnabled
    public static Student__c saveStudentRecord(Student__c student){
        if(validateStudentRecord(student) == false){
            throw new AuraHandledException('Validation Error - Please check your input and try again.');
        }
        upsert student;
        return student;
    }

    @AuraEnabled
    private static Boolean validateStudentRecord(Student__c student){
        if(String.isBlank(student.Name)){
            return false;
        }
        if(String.isBlank(student.Student_ID__c)){
            return false;
        }
        if(String.isBlank(student.Grade__c)){
            return false;
        }
        return true;
    }
}

// Lightning Web Component
<template>
    <lightning-record-edit-form object-api-name="Student__c" 
        onsuccess={handleSuccess}>
        <lightning-messages>
        </lightning-messages>
        <lightning-input-field field-name="Name">
        </lightning-input-field>
        <lightning-input-field field-name="Student_ID__c">
        </lightning-input-field>
        <lightning-input-field field-name="Grade__c">
        </lightning-input-field>
        <lightning-button class="slds-m-top_small" type="submit" label="Save">
        </lightning-button>
    </lightning-record-edit-form>
</template>

import { LightningElement, api } from 'lwc';
import { ShowToastEvent } from 'lightning/platformShowToastEvent';
import saveStudentRecord from '@salesforce/apex/StudentRecordController.saveStudentRecord';

export default class StudentRecordEditForm extends LightningElement {
    @api recordId;
    handleSuccess(event) {
        const studentRecord = event.detail.id;
        saveStudentRecord({ studentRecord })
            .then(() => {
                this.dispatchEvent(
                    new ShowToastEvent({
                        title: 'Success',
                        message: 'Student record saved',
                        variant: 'success'
                    })
                );
            })
            .catch(error => {
                this.dispatchEvent(
                    new ShowToastEvent({
                        title: 'Error creating record',
                        message: error.body.message,
                        variant: 'error'
                    })
                );
            });
    }
}