

// function sendEmail() {
//     const emailInput = document.getElementById('email').value;

//     if (!validateEmail(emailInput)) {
//         alert('Please enter a valid email address.');
//         return;
//     }

    
//     const url = '//';

//     fetch(url, {
//         method: 'POST',
//         headers: {
//             'Content-Type': 'application/json',
//         },
//         body: JSON.stringify({ email: emailInput }),
//     })
//     .then(response => response.json())
//     .then(data => {
//         if (data.success) {
//             alert('Email sent successfully!');
//         } else {
//             alert('Error sending email.');
//         }
//     })
//     .catch(error => {
//         console.error('Error:', error);
//         alert('There was an error sending the email.');
//     });
// }

// function validateEmail(email) {
//     const re = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
//     return re.test(String(email).toLowerCase());
// }
