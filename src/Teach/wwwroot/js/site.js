// Write your Javascript code.
$(document).ready(function () {
    $('#sidenav-menu').accordion();
    initialiseLoginForm();
});

function initialiseLoginForm() {
    $('#login-form').form({
        inline: true,
        fields: {
            username: {
                identifier: 'email',
                rules: [
                    {
                        type: 'empty',
                        prompt: 'Please enter your email'
                    },
                    {
                        type: 'email',
                        prompt: 'Please enter a valid email'
                    }
                ]
            },
            password: {
                identifier: 'password',
                rules: [
                    {
                        type: 'empty',
                        prompt: 'Please enter your password'
                    },
                    {
                        type: 'length[6]',
                        prompt: 'Your password must be at least 6 characters'
                    }
                ]
            }
        }
    });
}
