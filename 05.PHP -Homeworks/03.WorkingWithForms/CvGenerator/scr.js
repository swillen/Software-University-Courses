var counter = 0;
var secCount = 0;
function addLang() {
    var createDiv = document.createElement('div');
    createDiv.id=counter;
    createDiv.name=counter;
    createDiv.innerHTML = "<input type='text' name='complang[]'>" +
    "<select name='complevel' >" +
    "<option value='beginner'>Beginner</option>" +
    "<option value='beginner'>Programmer</option>" +
    "<option value='ninja'>Ninja</option>" +
    "</select><br>";
    document.getElementById('parent').appendChild(createDiv);
    counter++;
}
function remLang() {
   var inputB = document.getElementById('parent').lastChild;
    if(inputB.tagName.toLowerCase()==="div"){
        document.getElementById('parent').removeChild(inputB);
        counter--;
    }
}
function addOtherLang(){
    var createInput  = document.createElement('div');
    createInput.id=secCount;
    createInput.innerHTML="<input type='text' name='enterLang'  >"+
    "<select name='comprehension' >"+
    "<option value=''  style='display:none' selected='on' disabled='on' >-Comprehension-</option>"+
    "<option value=''>Beginner</option>"+
    "<option value=''>Intermediate</option>"+
    "<option value=''>Advanced</option>"+
    "</select>"+
    "<select name='read' >"+
    "<option value=''  style='display:none' selected='on' disabled='on' >-Reading-</option>"+
    "<option value=''>Beginner</option>"+
    "<option value=''>Intermediate</option>"+
    "<option value=''>Advanced</option>"+
    "</select>"+
    "<select name='writing' >"+
        "<option value=''  style='display:none' selected='on' disabled='on' >-Writing-</option>"+
        "<option value=''>Beginner</option>"+
        "<option value=''>Intermediate</option>"+
        "<option value=''>Advanced</option>"+
    "</select><br>"
    document.getElementById('parentt').appendChild(createInput);
    secCount++;
}
function removeOtherLang(){
    var elementToRemove =document.getElementById('parentt').lastChild;
    if(elementToRemove.tagName.toLowerCase()=="div"){
        document.getElementById('parentt').removeChild(elementToRemove);
        secCount--;
    }
}