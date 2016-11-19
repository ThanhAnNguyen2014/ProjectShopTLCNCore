﻿var user = {
	init:function(){
		user.registerEvents();
	},
	registerEvents: function () {
		$('.btn-active').off('click').on('click', function (e) {
			e.preventDefault();
			var btn = $(this);
			var id = btn.data('id');
			$.ajax({
				url: "/Admin/Users/ChangeIsDisplay/" + id,
				data: { id: id },
				dataType: "json",
				type: "post",
				success: function (response) {
					console.log(response);
					if (response.status == true) {
						btn.text('Kích hoạt');
					} else {
						btn.text('Khóa');
					}
						
				}
			});

		});
	}
}
user.init();

