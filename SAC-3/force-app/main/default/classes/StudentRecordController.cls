Apex Class

public with sharing class StudentRecordController {

    @AuraEnabled(cacheable=true)
    public static Student__c getStudentRecord(Id studentId) {
        return [SELECT Id, Name, Student_ID__c, Grade__c FROM Student__c WHERE Id = :studentId];
    }

    @AuraEnabled(cacheable=true)
    public static Student__c updateStudentRecord(Student__c studentRecord) {
        Student__c updatedStudent = new Student__c(
            Id = studentRecord.Id,
            Name = studentRecord.Name,
            Student_ID__c = studentRecord.Student_ID__c,
            Grade__c = studentRecord.Grade__c
        );
        try {
            // Perform any necessary validation
            if (validateStudentRecord(updatedStudent)) {
                upsert updatedStudent;
            }
        } catch (Exception e) {
            // Display any validation errors in a clear and user-friendly manner
            throw new AuraHandledException(e.getMessage());
        }
        return updatedStudent;
    }

    @AuraEnabled(cacheable=true)
    private static Boolean validateStudentRecord(Student__c studentRecord) {
        // Perform any necessary validation
        if (String.isBlank(studentRecord.Name)) {
            throw new AuraHandledException('Student Name must not be blank');
        }
        if (String.isBlank(studentRecord.Student_ID__c)) {
            throw new AuraHandledException('Student ID must not be blank');
        }
        if (String.isBlank(studentRecord.Grade__c)) {
            throw new AuraHandledException('Student Grade must not be blank');
        }
        return true;
    }
}

Lightning Web Component

<template>
    <lightning-record-edit-form object-api-name="Student__c" record-id={studentId} onsuccess={handleSuccess}>
        <lightning-messages class="slds-m-around_medium"></lightning-messages>
        <lightning-input-field field-name="Name" required>
        </lightning-input-field>
        <lightning-input-field field-name="Student_ID__c" required>
        </lightning-input-field>
        <lightning-input-field field-name="Grade__c" required>
        </lightning-input-field>
        <lightning-button class="slds-m-top_small" variant="brand" type="submit" name="update" label="Update">
        </lightning-button>
    </lightning-record-edit-form>
</template>

<!-- JS code -->
import { LightningElement, api, track } from 'lwc';
import { ShowToastEvent } from 'lightning/platformShowToastEvent';
import { updateRecord } from 'lightning/uiRecordApi';
import getStudentRecord from '@salesforce/apex/StudentRecordController.getStudentRecord';

export default class StudentRecordEditor extends LightningElement {
    @api studentId;
    @track studentRecord;

    connectedCallback() {
        this.loadStudentRecord();
    }

    // Load student record
    loadStudentRecord() {
        getStudentRecord({ studentId: this.studentId })
            .then(result => {
                this.studentRecord = result;
            })
            .catch(error => {
                this.showToast('Error loading student record', 'Error', 'error');
            });
    }

    // Handle form submission
    handleSuccess(event) {
        this.showToast('Student record updated', 'Success', 'success');
    }

    // Show toast with custom message
    showToast(message, title, variant) {
        const evt = new ShowToastEvent({
            title: title,
            message: message,
            variant: variant,
        });
        this.dispatchEvent(evt);
    }
}