public with sharing class AdminSurveyController {
    // Variables to store survey information
    private String surveyDomain;
    private String surveyTitle;
    private String surveyDescription;
    private Integer delayTime;
    private String surveyStatus;
    private String surveyState;
    private String pageName;
    private Date startDate;
    private Date endDate;
    private String targetUsers;
    private String specialty;
    private String preferences;
    private String country;
    private String region;
    private String city;
    private List<User> selectedUsers;
    private List<SurveyQuestion> surveyQuestions;

    // Getters and Setters
    public String getSurveyDomain() { return surveyDomain; }
    public void setSurveyDomain(String surveyDomain) { this.surveyDomain = surveyDomain; }

    public String getSurveyTitle() { return surveyTitle; }
    public void setSurveyTitle(String surveyTitle) { this.surveyTitle = surveyTitle; }

    public String getSurveyDescription() { return surveyDescription; }
    public void setSurveyDescription(String surveyDescription) { this.surveyDescription = surveyDescription; }

    public Integer getDelayTime() { return delayTime; }
    public void setDelayTime(Integer delayTime) { this.delayTime = delayTime; }

    public String getSurveyStatus() { return surveyStatus; }
    public void setSurveyStatus(String surveyStatus) { this.surveyStatus = surveyStatus; }

    public String getSurveyState() { return surveyState; }
    public void setSurveyState(String surveyState) { this.surveyState = surveyState; }

    public String getPageName() { return pageName; }
    public void setPageName(String pageName) { this.pageName = pageName; }

    public Date getStartDate() { return startDate; }
    public void setStartDate(Date startDate) { this.startDate = startDate; }

    public Date getEndDate() { return endDate; }
    public void setEndDate(Date endDate) { this.endDate = endDate; }

    public String getTargetUsers() { return targetUsers; }
    public void setTargetUsers(String targetUsers) { this.targetUsers = targetUsers; }

    public String getSpecialty() { return specialty; }
    public void setSpecialty(String specialty) { this.specialty = specialty; }

    public String getPreferences() { return preferences; }
    public void setPreferences(String preferences) { this.preferences = preferences; }

    public String getCountry() { return country; }
    public void setCountry(String country) { this.country = country; }

    public String getRegion() { return region; }
    public void setRegion(String region) { this.region = region; }

    public String getCity() { return city; }
    public void setCity(String city) { this.city = city; }

    public List<User> getSelectedUsers() { return selectedUsers; }
    public void setSelectedUsers(List<User> selectedUsers) { this.selectedUsers = selectedUsers; }

    public List<SurveyQuestion> getSurveyQuestions() { return surveyQuestions; }
    public void setSurveyQuestions(List<SurveyQuestion> surveyQuestions) { this.surveyQuestions = surveyQuestions; }

    // Constructor
    public AdminSurveyController() {
        surveyDomain = null;
        surveyTitle = null;
        surveyDescription = null;
        delayTime = 0;
        surveyStatus = null;
        surveyState = null;
        pageName = null;
        startDate = null;
        endDate = null;
        targetUsers = null;
        specialty = null;
        preferences = null;
        country = null;
        region = null;
        city = null;
        selectedUsers = new List<User>();
        surveyQuestions = new List<SurveyQuestion>();
    }

    // Method to create a survey
    public void createSurvey() {
        // Create a new survey
        Survey__c survey = new Survey__c();
        // Set survey fields
        survey.Domain__c = surveyDomain;
        survey.Title__c = surveyTitle;
        survey.Description__c = surveyDescription;
        survey.Delay_Time__c = delayTime;
        survey.Status__c = surveyStatus;
        survey.State__