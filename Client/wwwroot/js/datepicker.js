window.datepicker = {
    initiate: function() {

        $(document).ready(function() {
            $("#input-persian-date").hide();
        })
               
        $('#persian-date').MdPersianDateTimePicker({
            targetTextSelector: '#input-persian-date',
            monthsToShow: [0, 2],
            rangeSelector: true,
            inLine: true
        });

    }
}