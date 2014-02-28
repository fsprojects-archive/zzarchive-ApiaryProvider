Apiary Provider: データアクセス用ライブラリ
===================================

Apiary Provider ライブラリ (`ApiaryProvider.dll`) にはF#アプリケーションやスクリプトから
データにアクセスする際に必要となるすべての機能が揃えられています。
このライブラリには構造的な形式を持ったファイル（CSVやJSON、XML）を
操作するためのF#型プロバイダや、WorldBankやFreebaseのデータにアクセスするための
型プロバイダがあります。
また、JSONやCSVファイルを解析する機能や、
HTTPリクエストを送信するための機能もあります。

<div class="row">
  <div class="span1"></div>
  <div class="span6">
    <div class="well well-small" id="nuget">
      Apiary Provider Libraryは <a href="https://nuget.org/packages/ApiaryProvider">NuGetの
      ApiaryProviderパッケージ</a>として公開されています。
      ライブラリをインストールするには、
      <a href="http://docs.nuget.org/docs/start-here/using-the-package-manager-console">
      パッケージ マネージャー コンソール</a>上から以下のコマンドを実行します：
      <pre>PM> Install-Package ApiaryProvider</pre>
    </div>
  </div>
  <div class="span1"></div>
</div>

あるいは [ソースコードをZIPファイルとしてダウンロード][source] したり、
[コンパイル済みバイナリ][compiled] をZIPファイルとして
ダウンロードすることもできます。
 
貢献方法
------------

プロジェクトは [GitHub][gh] 上でホストされており、
[Issue(問題)を報告][issues] したり、プロジェクトをフォークして
pullリクエストを投げたりすることができます。
公開APIを独自に追加した場合、是非 [samples][samples] にもそれを反映して、
ドキュメント化されるようにしてください。

 * 不具合あるいはライブラリに追加する機能に関する議論がある場合には
   GitHub上で [不具合または新機能][issues] に関するNew Issueを投稿するか、
   [F# オープンソース][fsharp-oss] (英語)のメーリングリストに
   メールを投げてください。

 * ライブラリのアーキテクチャや構成、その他の話題
   (たとえばWindows PhoneやSilverlightなどのためのポータブルライブラリサポート)
   など、より詳しい話題については [Apiary Provider に貢献する](contributing.html)
   のページを参照してください。

### ライブラリの方針

このライブラリは構造的なドキュメントやその他のデータソースに対して、
単純かつ読み取り専用のアクセスをサポートすることに重点を置いています。
F#型プロバイダに関する包括的なコレクションとなることを意図しているわけではありません
（一般的にはF#型プロバイダには様々な用途があります）。
さらに、このライブラリでは（現時点では）ドキュメントを作成したり、
変更したりするようなAPIは公開されていません。

### ライブラリのライセンス

ライブラリは Apache 2.0ライセンスの元に公開されています。
詳細についてはGitHubレポジトリ内の [ライセンスファイル][license] を参照してください。
要約すると、このライブラリは自由に商用利用したり、
派生のライブラリを作成したり、変更したりすることができるということです。



  [source]: https://github.com/fsprojects/ApiaryProvider/zipball/master
  [compiled]: https://github.com/fsprojects/ApiaryProvider/zipball/release
  [samples]: https://github.com/fsprojects/ApiaryProvider/tree/master/samples
  [gh]: https://github.com/fsprojects/ApiaryProvider
  [issues]: https://github.com/fsprojects/ApiaryProvider/issues
  [license]: https://github.com/fsprojects/ApiaryProvider/blob/master/LICENSE.md
  [fsharp-oss]: http://groups.google.com/group/fsharp-opensource
