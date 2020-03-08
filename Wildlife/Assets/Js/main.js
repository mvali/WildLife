addEventListener("load", function () {
    setTimeout(hideURLbar, 0);
}, false);

function hideURLbar() {
    window.scrollTo(0, 1);
}

//<!-- script for password match -->
    window.onload = function () {
        document.getElementById("password1").onchange = validatePassword;
        document.getElementById("password2").onchange = validatePassword;
}

    function validatePassword() {
        var pass2 = document.getElementById("password2").value;
        var pass1 = document.getElementById("password1").value;
        if (pass1 != pass2)
            document.getElementById("password2").setCustomValidity("Passwords Don't Match");
else
            document.getElementById("password2").setCustomValidity('');
    //empty string means no validation error
}
//<!-- script for password match -->js/responsiveslides.min.js
// You can also use"
//$(window).load(function() {"
$(function () {
    // Slideshow 4
    $("#slider3").responsiveSlides({
        auto: true,
        pager: true,
        nav: false,
        speed: 500,
        namespace: "callbacks",
        before: function () {
            $('.events').append("<li>before event fired.</li>");
        },
        after: function () {
            $('.events').append("<li>after event fired.</li>");
        }
    });

});
//<!-- //Banner  Responsiveslides -->
//<!-- Scrolling Nav JavaScript -->scrolling-nav.js counter.js
//<!-- portfolio -->jquery.picEyes.js
    $(function () {
        //picturesEyes($('.demo li'));
        $('.demo li').picEyes();
    });
//<!-- //portfolio -->
//<!-- start-smooth-scrolling -->move-top.js easing.js
    jQuery(document).ready(function ($) {
        $(".scroll").click(function (event) {
            event.preventDefault();

            $('html,body').animate({
                scrollTop: $(this.hash).offset().top
            }, 1000);
        });
    });
//<!-- //end-smooth-scrolling -->
//<!-- smooth-scrolling-of-move-up -->
    $(document).ready(function () {
        /*
        var defaults = {
            containerID: 'toTop', // fading element id
            containerHoverID: 'toTopHover', // fading element hover id
            scrollSpeed: 1200,
            easingType: 'linear' 
        };
        */
        $().UItoTop({
            easingType: 'easeOutQuart'
        });

    });
//SmoothScroll.min.js
//<!-- //smooth-scrolling-of-move-up -->
//<!-- color switch -->blast.min.js
//<!-- Bootstrap core JavaScript
//================================================== -->
//<!-- Placed at the end of the document so the pages load faster -->
//<script src="bootstrap.js"></script>
