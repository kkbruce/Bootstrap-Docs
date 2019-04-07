$(function () {
    document.addEventListener('copy', onCopy.bind(this), false);
    document.addEventListener('cut', onCut.bind(this), false);
    // 初始化
    $("img.lazy").lazyload();
    $('[data-toggle="tooltip"]').tooltip();
});

function onCopy(e) {
    /// <summary>
    /// 複製事件，僅允許程式碼複製。
    /// </summary>
    /// <param name="e">event object</param>
    /// <returns type="boolean">boolean</returns>
    console.log('onCopy event fire.');

    if (!e)
        e = window.event;

    var $NodeName = e.target.nodeName;
    var $ParentName = e.target.parentNode.nodeName
    console.log('ParentName:' + $ParentName);
    console.log('nodeName: ' + $NodeName);

    // Firefox DOM 行為和其他 Browsers 不同
    var isFirefox = navigator.userAgent.indexOf("Firefox");

    if (isFirefox != -1) {
        console.log('onCopy event fire from Firefox.');

        if ('CODE' === $ParentName) {
            sweetAlert('程式碼複製', '程式碼已複製至剪貼簿。', 'success');
            console.log('程式碼已複製至剪貼簿。');
        } else {
            sweetAlert('請勿複製', '1. 請使用程式碼區塊左邊的\"Copy\"按鈕來複製。\r\n2. 文字之間程式碼(僅\"紅色區塊\")可複製。', 'error');
            console.log('僅能複製範例程式碼。');
            e.preventDefault();
            return false;
        }
    } else {
        console.log('onCopy event fire from other browsers.');

        if ('CODE' === $NodeName) {
            sweetAlert('程式碼複製', '程式碼已複製至剪貼簿。', 'success');
            console.log('程式碼已複製至剪貼簿。');
        } else {
            sweetAlert('請勿複製', '1. 請使用程式碼區塊左邊的\"Copy\"按鈕來複製。\r\n2. 文字之間程式碼(僅\"紅色區塊\")可複製。', 'error');
            console.log('僅能複製範例程式碼。');
            e.preventDefault();
            return false;
        }
    }

}

function onCut(e) {
    /// <summary>
    /// 剪下事件。
    /// </summary>
    /// <param name="e">event object</param>
    /// <returns type="boolean">false</returns>
    console.log('onCut event fire.');

    if (!e)
        e = window.event;

    e.preventDefault();
    return false;
}
