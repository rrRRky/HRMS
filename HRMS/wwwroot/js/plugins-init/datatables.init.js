(function ($) {
    "use strict";

   // to add search on each table head 

    $('table.dataTable tfoot').each(function () {
        $(this).insertAfter($(this).siblings('tbody'));
    });

})(jQuery);
