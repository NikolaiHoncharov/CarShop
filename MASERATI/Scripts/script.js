function setImg(selected_url){
    var item = document.getElementById('preview');
    item.src=selected_url;
}



/*Ajax jQuery*/
$(document).on('submit','form', (e)=>{
    e.preventDefault();
    var UserName = $('#name').val();
    var UserTel= $('#phone').val();
    var CarId=$('select').val();
    //Валидация введенных данных.
    if (UserName.length > 2)
    {
    //Проверяем номер телефона
        var regular = /^\+38[0-9]{10}/;
        if (regular.test(UserTel) == true)
        {
            SubmitForm(UserName, UserTel, CarId);
        }
        else
        {
            alert("Вы неверно указали номер телефона" + UserTel);
            e.preventDefault;
        }
    }
    else{
        alert("Вы забыли указать имя");
        e.preventDefault;
    }
});

/*Ajax jQuery*/
function SubmitForm(name, tel, CarId)
{
   $.ajax({
  method: "POST",
  url: "/Home/Index",
  data: { name: name, phone: tel, Car: CarId }
})
  .done(function( msg ) {
    alert( msg );
  }).fail(function() {
    alert( "При передачи данных произошла ошибка" );
  }); 
}