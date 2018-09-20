function createCommentItem(form, path) {
    var service = new ItemService({ url: '/sitecore/api/ssc/item' });
    var obj = {
        ItemName: 'comment - ' + form.email.value,
        TemplateID: '{D3811C46-133B-4DBC-87BA-5858F4535908}',
        Name: form.email.value,
        Comment: form.comment.value
    }
    service.create(obj)
        .path(path)
        .execute()
        .then(function (item) {
            form.email.value = form.comment.value = '';
            window.alert("Thanks, your message  will appear on the site shortly");
        })
        .fail(function (err) { window.alert(err); });
    event.preventDefault();
    return false;
}