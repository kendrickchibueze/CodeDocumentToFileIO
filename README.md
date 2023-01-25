# In-House Code Documentation To File, JSON and  PDF  for Bank Developers in C#🤷‍♀️🤷‍♂️👌😎😃

In this project,I created an in-house code-documentation tool for a
 Mini Bank group of developers such that Classes, Methods,Properties, Enums etc. are annotated with a Document Attribute. This is a documented code so that each developer in the team can easily understand each steps taken and can in turn contribute to the repository. The Document Attribute takes one required parameter *"Description" and two optional Parameters "Input" and "Output"*
respectively. When **GetDocs()** is called it displays details of all codes documented throughout the assembly. We created a class library namespace and used it to define  our **DocumentAttribute** which is being referenced in the  executable project folder.

This is a retrofit to our former app on In House code documentation. But now, we can write the output of GetDocs() method to text file and to JSON file and read their contents to the console. We can seamlessly create write the output of the GetDocs() method  to a PDF file.



The screenshot of the sample display of our output code shows the following:

![](https://github.com/kendrickchibueze/-Modern-Node-on-AWS/blob/main/Screenshot%20(480).png?raw=true)


Depending on the user's choice, the output can be displayed to a PDF,  text file, or a JSON file and back to the console as shown below: 


!["1st screenshot"](https://github.com/kendrickchibueze/-Modern-Node-on-AWS/blob/main/Screenshot%20(475).png?raw=true)
!["2nd screenshot](https://github.com/kendrickchibueze/-Modern-Node-on-AWS/blob/main/Screenshot%20(476).png?raw=true)

## Software Development Summary😃👓👓
* **Technology**: C#👓
* **Framework**: .NET6
* **Project Type**: Console
* **IDE**: Visual Studio (Version 2022)
* **Paradigm or pattern of programming**: Object-Oriented Programming (OOP)
* **Data**:Documented code


**NOTE**:We have used the power of **reflection** in C# to get information about our documented code in the assembly. This repo is subject to future modifications.











