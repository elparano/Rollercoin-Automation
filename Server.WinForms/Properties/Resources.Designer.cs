﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Server.WinForms.Properties {
    using System;
    
    
    /// <summary>
    ///   Klasa zasobu wymagająca zdefiniowania typu do wyszukiwania zlokalizowanych ciągów itd.
    /// </summary>
    // Ta klasa została automatycznie wygenerowana za pomocą klasy StronglyTypedResourceBuilder
    // przez narzędzie, takie jak ResGen lub Visual Studio.
    // Aby dodać lub usunąć składową, edytuj plik ResX, a następnie ponownie uruchom narzędzie ResGen
    // z opcją /str lub ponownie utwórz projekt VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        /// Zwraca buforowane wystąpienie ResourceManager używane przez tę klasę.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Server.WinForms.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Przesłania właściwość CurrentUICulture bieżącego wątku dla wszystkich
        ///   przypadków przeszukiwania zasobów za pomocą tej klasy zasobów wymagającej zdefiniowania typu.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu function f0x_3()
        ///{
        ///	var timer = document.querySelector(&apos;#root &gt; div &gt; div.content &gt; div &gt; div.react-wrapper &gt; div &gt; div &gt; div.choose-game-container.col-12.col-lg-8 &gt; div &gt; div.choose-game-body &gt; div &gt; div.select-game-block.col-12.col-lg-8 &gt; div &gt; div &gt; div.scrollContainer &gt; div &gt; div:nth-child(8) &gt; div &gt; div.img-container &gt; div &gt; svg &gt; path.CircularProgressbar-path&apos;)
        ///	if(timer != null)
        ///	{
        ///		var totalSeconds = parseInt(timer.style.strokeDasharray.split(&apos;, &apos;)[0].replace(&apos;px&apos;, &apos;&apos;))
        ///		var currentSeconds = [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        public static string checkcooldown_script {
            get {
                return ResourceManager.GetString("checkcooldown_script", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu function f0x_4()
        ///{
        ///    var status_bar = document.querySelector(&apos;#root &gt; div &gt; div.content &gt; div &gt; div.react-wrapper &gt; div &gt; div.choose-game-main-container.row &gt; div.play-game-result.col-12.col-lg-8 &gt; div.justify-content-center.align-items-end.container-result-info.no-gutters.row &gt; div.game-result-info.col-12 &gt; div.loading&apos;)
        ///	var bot_msg = document.querySelector(&apos;#root &gt; div &gt; div.content &gt; header &gt; div.Toastify &gt; div &gt; div &gt; div.Toastify__toast-body &gt; div &gt; span&apos;)
        ///	if(status_bar != null) status_bar = st [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        public static string gainpower_result_script {
            get {
                return ResourceManager.GetString("gainpower_result_script", resourceCulture);
            }
        }
    }
}