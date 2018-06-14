using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheSystem {
	// public Person person {get; set;}
	public List<Person> people {get; set;}
	public TheSystem(List<Person> people){
		this.people = people;
	}
}

// public class LearningPath {
// 	List<LearningExperience> learningExperienceList;
// 	List<NonLearningExperience> nonLearningExperienceList;
// 	List<WorkingExperience> workingExperienceList;
// 	List<NonLearningExperience> InformalLearningExperienceList;
// 	List<WorkingExperience> HobbyExperienceList;
// 	public LearningPath(List<LearningExperience> learningExperienceList, 
// 						List<NonLearningExperience> nonLearningExperienceList, 
// 						List<WorkingExperience> workingExperienceList, 
// 						List<WorkingExperience> InformalLearningExperienceList,
// 						List<WorkingExperience> HobbyExperienceList){
// 		this.learningExperienceList = learningExperienceList;
// 		this.nonLearningExperienceList = nonLearningExperienceList;
// 		this.workingExperienceList = workingExperienceList;
// 	}
// }

// public class LearningPath {


// 	public LearningPath(List<LearningExperience> learningExperienceList, 
// 						List<NonLearningExperience> nonLearningExperienceList, 
// 						List<WorkingExperience> workingExperienceList, 
// 						List<WorkingExperience> InformalLearningExperienceList,
// 						List<WorkingExperience> HobbyExperienceList){
// 		this.learningExperienceList = learningExperienceList;
// 		this.nonLearningExperienceList = nonLearningExperienceList;
// 		this.workingExperienceList = workingExperienceList;
// 	}
// }

public class Person {
	public string name {get; set;}
	public string surname {get; set;}
	public string birthdate {get; set;}
	public List<Experience> learningpath {get; set;}


	public Person(string name, string surname, string birthdate, List<Experience> learningpath
					) {
						this.name = name;
						this.surname = surname;
						this.birthdate = birthdate;
						this.learningpath = learningpath;
					}
}

public class Experience {
	public string name {get;set;}
	public string type {get;set;}
	public string startingYear{get;set;}
	public string where{get;set;}
	public List<string> skills_tags{get;set;}

	public Experience(string name, string type, string startingYear, string where, List<string> skills_tags){
		this.name = name;
		this.type = type;
		this.startingYear = startingYear;
		this.where = where;
		this.skills_tags = skills_tags;
	}
}

// public class LearningExperience {
// 	public string name {get;set;}
// 	public string type {get;set;}
// 	public string startingYear{get;set;}
// 	public string where{get;set;}
// 	public List<string> skills_tags{get;set;}

// 	public LearningExperience(string name, string type, string startingYear, string where, List<string> skills_tags){
// 		this.name = name;
// 		this.type = type;
// 		this.startingYear = startingYear;
// 		this.where = where;
// 		this.skills_tags = skills_tags;
// 	}
// }

// public class InformalLearningExperience {
// 	public string name {get;set;}
// 	public string type {get;set;}
// 	public string startingYear{get;set;}
// 	public string where{get;set;}
// 	public List<string> skills_tags{get;set;}

// 	public InformalLearningExperience(string name, string type, string startingYear, string where, List<string> skills_tags){
// 		this.name = name;
// 		this.type = type;
// 		this.startingYear = startingYear;
// 		this.where = where;
// 		this.skills_tags = skills_tags;
// 	}
// }

// public class NonLearningExperience {
// 	public string name {get;set;}
// 	public string startingYear{get;set;}
// 	public string where{get;set;}
// 	public List<string> skills_tags{get;set;}

// 	public NonLearningExperience(string name, string startingYear, string where, List<string> skills_tags){
// 		this.name = name;
// 		this.startingYear = startingYear;
// 		this.where = where;
// 		this.skills_tags = skills_tags;
// 	}
// }

// public class WorkingExperience {
// 	public string companyName {get;set;}
// 	public string startingYear{get;set;}
// 	public string where{get;set;}
// 	public List<string> skills_tags{get;set;}

// 	public WorkingExperience(string companyName, string startingYear, string where, List<string> skills_tags){
// 		this.companyName = companyName;
// 		this.startingYear = startingYear;
// 		this.where = where;
// 		this.skills_tags = skills_tags;
// 	}
// }

// public class HobbyExperience {
// 	public string name {get;set;}
// 	public string year{get;set;}
// 	public string where{get;set;}
// 	public List<string> skills_tags{get;set;}

// 	public HobbyExperience(string name, string year, string where, List<string> skills_tags){
// 		this.name = name;
// 		this.year = year;
// 		this.where = where;
// 		this.skills_tags = skills_tags;
// 	}
// }