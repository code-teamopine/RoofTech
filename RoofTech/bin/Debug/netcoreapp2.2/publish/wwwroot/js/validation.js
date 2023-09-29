function valid_careers()
{
	var c_name=document.getElementById('c_name');
	var c_email=document.getElementById('c_email');
	var c_mobile_no=document.getElementById('c_mobile_no');
	var resume=document.getElementById('resume');
	
	if(c_name.value=='')
	{
		alert('Please Enter Name.');
		c_name.focus();
		return false;
	}
	var digit = c_name.value;
	var alpha = /^[a-zA-Z-,]+(\s{0,1}[a-zA-Z-, ])+(\s{0,1}[a-zA-Z-, ])*$/;
	if(!alpha.test(digit)) {
		alert('Invalid Name: ' + c_name.value);
		c_name.value = '';
		c_name.focus();
		return false;
	}
	
	if(c_email.value=='')
	{
		alert('Please Enter Email ID.');
		c_email.focus();
		return false;
	}
	var reg = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
	var address = c_email.value;
	if(reg.test(address) == false) {
		alert('Invalid Email ID: ' + c_email.value);
		c_email.value = '';
		c_email.focus();
		return false;
	}
	
	if(c_mobile_no.value=='')
	{
		alert('Please Enter 10 Digits Mobile No.');
		c_mobile_no.focus();
		return false;
	}
	var mobile = c_mobile_no.value;
	var pattern = /^\d{10}$/;
	if (!pattern.test(mobile)) {
		alert('Invalid Mobile No.: ' + c_mobile_no.value);
		c_mobile_no.value = '';
        c_mobile_no.focus();
		return false;
	}

	if(resume.value=='')
	{
		alert('Please Upload Resume.');
		resume.focus();
		return false;
	}
	
	var cv_reg = /(.doc|.docx|.DOC|.DOCX|.pdf|.PDF)$/i;
	var cv = resume.value;
	if(cv_reg.test(cv) == false)
	{
		alert('Please Upload Resume Only .DOC, .DOCX, .PDF File.');
		resume.focus();
		return false;
	}
	
	var cv_size=resume.files[0].size;
	cv_size=(cv_size/1024);
	if(cv_size!=null)
	{
		if(cv_size<=1024)
		{
			return true;
		}
		else
		{
			alert("Maximum Upload Size Of Photo Is 1 MB.");
			return false;
		}
	}
	
	/*if($("#RecaptchaField2").length)
	{
		var v = grecaptcha.getResponse(document.getElementById(RecaptchaField2));
		if ($("#RecaptchaField2 .g-recaptcha-response").val() == '')
		  {
			alert('Please select re-captcha');
			return false;
		  }
	}
	else
	{
		var no_idcaptcha= grecaptcha.getResponse();
		if(no_idcaptcha.length==0)
		{
			alert('Please Select re-Captcha');
			return false;
		}
	} */
	

	return true;
	
}
/*---------------------------------------- */
/*-----------Contact Form Validation------------*/
function valid_contact()
{
	var c_name=document.getElementById('c_name');
	var c_email=document.getElementById('c_email');
	var c_mobile_no=document.getElementById('c_mobile_no');   
   
	if(c_name.value=='')
	{
		alert('Please Enter Name.');
		c_name.focus();
		return false;
	}
	var digit = document.getElementById('c_name').value;
	var alpha = /^[a-zA-Z-,]+(\s{0,1}[a-zA-Z-, ])+(\s{0,1}[a-zA-Z-, ])*$/;
	if(!alpha.test(digit)) {
		alert('Invalid Name: ' + c_name.value);
		c_name.value = '';
		c_name.focus();
		return false;
	}
	
	
	
	if(c_email.value=='')
	{
		alert('Please Enter Email ID.');
		c_email.focus();
		return false;
	}
	var c_reg = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
	var c_address = c_email.value;
	if(c_reg.test(c_address) == false) {
		alert('Invalid Email ID: ' + c_email.value);
		c_email.value = '';
		c_email.focus();
		return false;
	}
	
	if(c_mobile_no.value=='')
	{
		alert('Please Enter 10 Digits Mobile No.');
		c_mobile_no.focus();
		return false;
	}
	var c_mobile = c_mobile_no.value;
	var c_pattern = /^\d{10}$/;
	if (!c_pattern.test(c_mobile)) {
		alert('Invalid Mobile No.: ' + c_mobile_no.value);
		c_mobile_no.value = '';
        c_mobile_no.focus();
		return false;
	}
	
	
	/*if($("#RecaptchaField2").length)
	{
		var v = grecaptcha.getResponse(document.getElementById(RecaptchaField2));
		if ($("#RecaptchaField2 .g-recaptcha-response").val() == '')
		  {
			alert('Please select re-captcha');
			return false;
		  }
	}
	else
	{
		var no_idcaptcha= grecaptcha.getResponse();
		if(no_idcaptcha.length==0)
		{
			alert('Please Select re-Captcha');
			return false;
		}
	} 
	
	if(c_enquiry.value=='')
	{
		alert('Please Enter Enquiry.');
		c_enquiry.focus();
		return false;
	}*/
	
	return true;
	
}


/*---------------------------------------- */
/*-----------Quick Inquiry Form Validation------------*/
function valid_quick_inquiry()
{
	var i_name=document.getElementById('i_name');
	var i_email=document.getElementById('i_email');	
		
	if(i_name.value=='')
	{
		alert('Please Enter Name.');
		i_name.focus();
		return false;
	}
	var digit_inquiry = document.getElementById('i_name').value;
	var alpha_inquiry = /^[a-zA-Z-,]+(\s{0,1}[a-zA-Z-, ])+(\s{0,1}[a-zA-Z-, ])*$/;
	if(!alpha_inquiry.test(digit_inquiry)) {
		alert('Invalid Name: ' + i_name.value);
		i_name.value = '';
		i_name.focus();
		return false;
	}  
  
	if(i_email.value=='')
	{
		alert('Please Enter Email ID.');
		i_email.focus();
		return false;
	}
	var i_reg = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
	var i_address = i_email.value;
	if(i_reg.test(i_address) == false) {
		alert('Invalid Email ID: ' + i_email.value);
		i_email.value = '';
		i_email.focus();
		return false;
	}
		
/*if($("#RecaptchaField2").length)
	{
		var v = grecaptcha.getResponse(document.getElementById(RecaptchaField2));
		if ($("#RecaptchaField2 .g-recaptcha-response").val() == '')
		  {
			alert('Please select re-captcha');
			return false;
		  }
	}
	else
	{
		var no_idcaptcha= grecaptcha.getResponse();
		if(no_idcaptcha.length==0)
		{
			alert('Please Select re-Captcha');
			return false;
		}
	} 
*/
	return true;
	
}


/*---------------------------------------- */
/*-----------Inquiry Form Validation------------*/

function valid_inquiry()
{
	var p_name=document.getElementById('p_name');
	var p_email=document.getElementById('p_email');	
	var p_mobile=document.getElementById('p_mobile');		

	var product_offering=document.getElementById('product_offering');			
	
	if(p_name.value=='')
	{
		alert('Please Enter Name.');
		p_name.focus();
		return false;
	}
	var digit_inquiry = document.getElementById('p_name').value;
	var alpha_inquiry = /^[a-zA-Z-,]+(\s{0,1}[a-zA-Z-, ])+(\s{0,1}[a-zA-Z-, ])*$/;
	if(!alpha_inquiry.test(digit_inquiry)) {
		alert('Invalid Name: ' + p_name.value);
		p_name.value = '';
		p_name.focus();
		return false;
	}  
  
	if(p_email.value=='')
	{
		alert('Please Enter Email ID.');
		p_email.focus();
		return false;
	}
	var p_reg = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
	var p_address = p_email.value;
	if(p_reg.test(p_address) == false) {
		alert('Invalid Email ID: ' + p_email.value);
		p_email.value = '';
		p_email.focus();
		return false;
	}
	
	if(p_mobile.value=='')
	{
		alert('Please Enter 10 Digits Mobile No.');
		p_mobile.focus();
		return false;
	}
	var p_mobile_no = p_mobile.value;
	var c_pattern = /^\d{10}$/;
	if (!c_pattern.test(p_mobile_no)) {
		alert('Invalid Mobile No.: ' + p_mobile.value);
		p_mobile.value = '';
        p_mobile.focus();
		return false;
	}
	
	
	if(product_offering.value=='')
	{
		alert('Please Select Product Offering.');
		product_offering.focus();
		return false;
	}
		
/*if($("#RecaptchaField2").length)
	{
		var v = grecaptcha.getResponse(document.getElementById(RecaptchaField2));
		if ($("#RecaptchaField2 .g-recaptcha-response").val() == '')
		  {
			alert('Please select re-captcha');
			return false;
		  }
	}
	else
	{
		var no_idcaptcha= grecaptcha.getResponse();
		if(no_idcaptcha.length==0)
		{
			alert('Please Select re-Captcha');
			return false;
		}
	} 
*/
	return true;
	
}



/*---------------------------------------- */
/*-----------Get in Touch Form Validation------------*/

function valid_get_in_touch()
{
	var gname=document.getElementById('gname');
	var gemail=document.getElementById('gemail');
	var gphone=document.getElementById('gphone');
	
	
	
	if(gname.value=='')
	{
		alert('Please Enter Name.');
		gname.focus();
		return false;
	}
	var digit = name.value;

	var alpha = /^[a-zA-Z]*$/;
	if(!alpha.test(digit)) {
		alert('Invalid Name: ' + gname.value);
		gname.value = '';
		gname.focus();
		return false;
	}
	
	if(gemail.value=='')
	{
		alert('Please Enter Email ID.');
		gemail.focus();
		return false;
	}
	var reg = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
	var address = gemail.value;
	if(reg.test(address) == false) {
		alert('Invalid Email ID: ' + gemail.value);
		gemail.value = '';
		gemail.focus();
		return false;
	}
	
	if(gphone.value=='')
	{
		alert('Please Enter 10 Digits Mobile No.');
		gphone.focus();
		return false;
	}
	var mobile1 = gphone.value;
	var pattern = /^\d{10}$/;
	if (!pattern.test(mobile1)) {
		alert('Invalid Mobile No.: ' + gphone.value);
		gphone.value = '';
        gphone.focus();
		return false;
	}
	
	return true;
	
}

/*---------------------------------------- */
/*-----------Download Form Validation------------*/

function valid_download()
{
	var name=document.getElementById('d_name');
	var email=document.getElementById('d_email');
	var mobile_no=document.getElementById('d_mobile_no');
	
	
		
	if(name.value=='')
	{
		alert('Please Enter Name.');
		name.focus();
		return false;
	}
	var digit = name.value;
	var alpha = /^[a-zA-Z-,]+(\s{0,1}[a-zA-Z-, ])+(\s{0,1}[a-zA-Z-, ])*$/;
	if(!alpha.test(digit)) {
		alert('Invalid Name: ' + name.value);
		name.value = '';
		name.focus();
		return false;
	}
	
	if(email.value=='')
	{
		alert('Please Enter Email ID.');
		email.focus();
		return false;
	}
	var reg = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
	var address = email.value;
	if(reg.test(address) == false) {
		alert('Invalid Email ID: ' + email.value);
		email.value = '';
		email.focus();
		return false;
	}
	
	if(mobile_no.value=='')
	{
		alert('Please Enter 10 Digits Mobile No.');
		mobile_no.focus();
		return false;
	}
	var mobile = mobile_no.value;
	var pattern = /^\d{10}$/;
	if (!pattern.test(mobile)) {
		alert('Invalid Mobile No.: ' + mobile_no.value);
		mobile_no.value = '';
        mobile_no.focus();
		return false;
	}
	if($("#project").length)
	{
		var project=document.getElementById('project');	
			if(project.value=='')
		{
			alert('Please Select Brochure.');
			project.focus();
			return false;
		}
	
	}	
	if($("#RecaptchaField1").length)
	{
		var v = grecaptcha.getResponse(document.getElementById(RecaptchaField1));
		if ($("#RecaptchaField1 .g-recaptcha-response").val() == '')
		  {
			alert('Please select re-captcha');
			return false;
		  }
	}
	else
	{
		var no_idcaptcha= grecaptcha.getResponse();
		if(no_idcaptcha.length==0)
		{
			alert('Please Select re-Captcha');
			return false;
		}
	} 

	
	
	
	
	
	
	return true;
}
