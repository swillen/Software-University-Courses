<?php
function compLang(){
    for ($i = 0; $i <count($_POST['complang[]']); $i++) {
        echo $i;
    }
}

?>
<h1>CV</h1>
<table border="1">
    <tr>
        <td colspan="2" style="font-weight: bold;text-align: center">Personal Information</td>

    </tr>
    <tr>
        <td>First Name</td>
        <td><?php  echo $_POST['fname'] ?></td>
    </tr>
    <tr>
        <td>Last Name</td>
        <td><?php  echo $_POST['lname'] ?></td>
    </tr>
    <tr>
        <td>Email</td>
        <td><?php  echo $_POST['mail']   ?></td>
    </tr>
    <tr>
        <td>Phone Number</td>
        <td><?php  echo $_POST['phone']   ?></td>
    </tr>
    <tr>
        <td>Gender</td>
        <td><?php  echo $_POST['sex']   ?></td>
    </tr>
    <tr>
        <td>Birth Date</td>
        <td><?php  echo $_POST['birth']   ?></td>
    </tr>
    <tr>
        <td>Nationality</td>
        <td><?php  echo $_POST['nat']   ?></td>
    </tr>
</table>
<br/>
<table border="1">
    <tr>
        <td colspan="2" style="font-weight: bold;text-align: center">Last Work Position</td>
    </tr>
    <tr>
        <td>Company Name</td>
        <td><?php  echo $_POST['company']   ?></td>
    </tr>
    <tr>
        <td>From</td>
        <td><?php  echo $_POST['from']   ?></td>
    </tr>
    <tr>
        <td>To</td>
        <td> <?php  echo $_POST['to']   ?></td>
    </tr>

</table>
<br/>
<table border="1">
    <tr>
        <td colspan="2" style="font-weight: bold;text-align: center">Computer Skills</td>
    </tr>
    <tr>
        <td>Programming Languages</td>
    </tr>
    <tr>
        <td><?php compLang()?></td>
    </tr>
</table>
<!--to do .. -->