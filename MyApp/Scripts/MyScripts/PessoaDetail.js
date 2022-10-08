




    
const SaveDataAsync = async function (data) {
    await $.ajax({
        //url: 'http://www.myapiapp.com:81/Api/Pessoa/Save',
        url: 'http://myapiappparodie.azurewebsites.net/Api/Pessoa/Save',
        method: 'POST',
        contentType: 'application/json',
        data: data,
        success: function(result) {
            alert("Sucesso");
        },
        error: function (e,v,error) {
            if (e.responseJSON?.ExceptionMessage !== undefined)
            {
                alert(e.responseJSON.ExceptionMessage);
            }
            else{
                alert("Error->"+error);
        }
    }  
    });
};

const SerializeFormToJson = function () {
    let result = {};
    $.each($('form').first().serializeArray(),
        function (i, v) {
            result[v.name] = v.value
        });
    return result
}



$(document).ready(function () {

    //    $(".btneditajax").click(x =>(await SaveDataAsync(JSON.stringify(SerializeFormToJson()))));  

    $(".btneditajax").click(async () => {
        if ($("form").first().valid())
        {
            await SaveDataAsync(JSON.stringify(SerializeFormToJson()));
            window.location.href = '/Pessoas';
        }
        else
        {
            $('#exampleModal').modal('toggle');
        }
    })
});