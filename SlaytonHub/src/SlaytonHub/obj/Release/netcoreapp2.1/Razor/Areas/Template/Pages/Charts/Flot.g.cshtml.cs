#pragma checksum "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Charts/Flot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85d20994162bdfefe28d5eee897d54914d842ae2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SlaytonHub.Areas.Template.Pages.Charts.Areas_Template_Pages_Charts_Flot), @"mvc.1.0.razor-page", @"/Areas/Template/Pages/Charts/Flot.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Template/Pages/Charts/Flot.cshtml", typeof(SlaytonHub.Areas.Template.Pages.Charts.Areas_Template_Pages_Charts_Flot), null)]
namespace SlaytonHub.Areas.Template.Pages.Charts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d20994162bdfefe28d5eee897d54914d842ae2", @"/Areas/Template/Pages/Charts/Flot.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f12120391a0edf442ef4f4de80d25de41727c708", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c25d9407126acdb25718cdff3d88e24295530e0", @"/Areas/Template/Pages/_ViewImports.cshtml")]
    public class Areas_Template_Pages_Charts_Flot : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Charts/Flot.cshtml"
  
    ViewData["Title"] = "Flot";
    Layout = "_LayoutAdminLTE";

#line default
#line hidden
            BeginContext(75, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(93, 8896, true);
                WriteLiteral(@"
    <!-- FLOT CHARTS -->
    <script src=""https://d1m0vzlwib3qni.cloudfront.net/lib/Flot/jquery.flot.js""></script>
    <!-- FLOT RESIZE PLUGIN - allows the chart to redraw when the window is resized -->
    <script src=""https://d1m0vzlwib3qni.cloudfront.net/lib/Flot/jquery.flot.resize.js""></script>
    <!-- FLOT PIE PLUGIN - also used to draw donut charts -->
    <script src=""https://d1m0vzlwib3qni.cloudfront.net/wwwroot/lib/Flot/jquery.flot.pie.js""></script>
    <!-- FLOT CATEGORIES PLUGIN - Used to draw bar charts -->
    <script src=""https://d1m0vzlwib3qni.cloudfront.net/wwwroot/lib/Flot/jquery.flot.categories.js""></script>

    <script>
        $(function () {
            /*
             * Flot Interactive Chart
             * -----------------------
             */
            // We use an inline data source in the example, usually data would
            // be fetched from a server
            var data = [], totalPoints = 100

            function getRandomData() {

                if (data.length > 0)
");
                WriteLiteral(@"                    data = data.slice(1)

                // Do a random walk
                while (data.length < totalPoints) {

                    var prev = data.length > 0 ? data[data.length - 1] : 50,
                        y = prev + Math.random() * 10 - 5

                    if (y < 0) {
                        y = 0
                    } else if (y > 100) {
                        y = 100
                    }

                    data.push(y)
                }

                // Zip the generated y values with the x values
                var res = []
                for (var i = 0; i < data.length; ++i) {
                    res.push([i, data[i]])
                }

                return res
            }

            var interactive_plot = $.plot('#interactive', [getRandomData()], {
                grid: {
                    borderColor: '#f3f3f3',
                    borderWidth: 1,
                    tickColor: '#f3f3f3'
                },
                series: {
                    sha");
                WriteLiteral(@"dowSize: 0, // Drawing is faster without shadows
                    color: '#3c8dbc'
                },
                lines: {
                    fill: true, //Converts the line chart to area chart
                    color: '#3c8dbc'
                },
                yaxis: {
                    min: 0,
                    max: 100,
                    show: true
                },
                xaxis: {
                    show: true
                }
            })

            var updateInterval = 500 //Fetch data ever x milliseconds
            var realtime = 'on' //If == to on then fetch data every x seconds. else stop fetching
            function update() {

                interactive_plot.setData([getRandomData()])

                // Since the axes don't change, we don't need to call plot.setupGrid()
                interactive_plot.draw()
                if (realtime === 'on')
                    setTimeout(update, updateInterval)
            }

            //INITIALIZE REALTIME DATA FETCHI");
                WriteLiteral(@"NG
            if (realtime === 'on') {
                update()
            }
            //REALTIME TOGGLE
            $('#realtime .btn').click(function () {
                if ($(this).data('toggle') === 'on') {
                    realtime = 'on'
                }
                else {
                    realtime = 'off'
                }
                update()
            })
            /*
             * END INTERACTIVE CHART
             */

            /*
             * LINE CHART
             * ----------
             */
            //LINE randomly generated data

            var sin = [], cos = []
            for (var i = 0; i < 14; i += 0.5) {
                sin.push([i, Math.sin(i)])
                cos.push([i, Math.cos(i)])
            }
            var line_data1 = {
                data: sin,
                color: '#3c8dbc'
            }
            var line_data2 = {
                data: cos,
                color: '#00c0ef'
            }
            $.plot('#line-chart', [line_data1, ");
                WriteLiteral(@"line_data2], {
                grid: {
                    hoverable: true,
                    borderColor: '#f3f3f3',
                    borderWidth: 1,
                    tickColor: '#f3f3f3'
                },
                series: {
                    shadowSize: 0,
                    lines: {
                        show: true
                    },
                    points: {
                        show: true
                    }
                },
                lines: {
                    fill: false,
                    color: ['#3c8dbc', '#f56954']
                },
                yaxis: {
                    show: true
                },
                xaxis: {
                    show: true
                }
            })
            //Initialize tooltip on hover
            $('<div class=""tooltip-inner"" id=""line-chart-tooltip""></div>').css({
                position: 'absolute',
                display: 'none',
                opacity: 0.8
            }).appendTo('body')
        ");
                WriteLiteral(@"    $('#line-chart').bind('plothover', function (event, pos, item) {

                if (item) {
                    var x = item.datapoint[0].toFixed(2),
                        y = item.datapoint[1].toFixed(2)

                    $('#line-chart-tooltip').html(item.series.label + ' of ' + x + ' = ' + y)
                        .css({ top: item.pageY + 5, left: item.pageX + 5 })
                        .fadeIn(200)
                } else {
                    $('#line-chart-tooltip').hide()
                }

            })
            /* END LINE CHART */

            /*
             * FULL WIDTH STATIC AREA CHART
             * -----------------
             */
            var areaData = [[2, 88.0], [3, 93.3], [4, 102.0], [5, 108.5], [6, 115.7], [7, 115.6],
            [8, 124.6], [9, 130.3], [10, 134.3], [11, 141.4], [12, 146.5], [13, 151.7], [14, 159.9],
            [15, 165.4], [16, 167.8], [17, 168.7], [18, 169.5], [19, 168.0]]
            $.plot('#area-chart', [areaData], {
                grid: {
  ");
                WriteLiteral(@"                  borderWidth: 0
                },
                series: {
                    shadowSize: 0, // Drawing is faster without shadows
                    color: '#00c0ef'
                },
                lines: {
                    fill: true //Converts the line chart to area chart
                },
                yaxis: {
                    show: false
                },
                xaxis: {
                    show: false
                }
            })

            /* END AREA CHART */

            /*
             * BAR CHART
             * ---------
             */

            var bar_data = {
                data: [['January', 10], ['February', 8], ['March', 4], ['April', 13], ['May', 17], ['June', 9]],
                color: '#3c8dbc'
            }
            $.plot('#bar-chart', [bar_data], {
                grid: {
                    borderWidth: 1,
                    borderColor: '#f3f3f3',
                    tickColor: '#f3f3f3'
                },
                seri");
                WriteLiteral(@"es: {
                    bars: {
                        show: true,
                        barWidth: 0.5,
                        align: 'center'
                    }
                },
                xaxis: {
                    mode: 'categories',
                    tickLength: 0
                }
            })
            /* END BAR CHART */

            /*
             * DONUT CHART
             * -----------
             */

            var donutData = [
                { label: 'Series2', data: 30, color: '#3c8dbc' },
                { label: 'Series3', data: 20, color: '#0073b7' },
                { label: 'Series4', data: 50, color: '#00c0ef' }
            ]
            $.plot('#donut-chart', donutData, {
                series: {
                    pie: {
                        show: true,
                        radius: 1,
                        innerRadius: 0.5,
                        label: {
                            show: true,
                            radius: 2 / 3,
            ");
                WriteLiteral(@"                formatter: labelFormatter,
                            threshold: 0.1
                        }

                    }
                },
                legend: {
                    show: false
                }
            })
            /*
             * END DONUT CHART
             */

        })

        /*
         * Custom Label formatter
         * ----------------------
         */
        function labelFormatter(label, series) {
            return '<div style=""font-size:13px; text-align:center; padding:2px; color: #fff; font-weight: 600;"">'
                + label
                + '<br>'
                + Math.round(series.percent) + '%</div>'
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(8991, 4386, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xs-12"">
        <!-- interactive chart -->
        <div class=""box box-primary"">
            <div class=""box-header with-border"">
                <i class=""fa fa-bar-chart-o""></i>

                <h3 class=""box-title"">Interactive Area Chart</h3>

                <div class=""box-tools pull-right"">
                    Real time
                    <div class=""btn-group"" id=""realtime"" data-toggle=""btn-toggle"">
                        <button type=""button"" class=""btn btn-default btn-xs active"" data-toggle=""on"">On</button>
                        <button type=""button"" class=""btn btn-default btn-xs"" data-toggle=""off"">Off</button>
                    </div>
                </div>
            </div>
            <div class=""box-body"">
                <div id=""interactive"" style=""height: 300px;""></div>
            </div>
            <!-- /.box-body-->
        </div>
        <!-- /.box -->

    </div>
    <!-- /.col -->
</div>
<!-- /.row -->

<div class=""row"">
    <div class=""col-");
            WriteLiteral(@"md-6"">
        <!-- Line chart -->
        <div class=""box box-primary"">
            <div class=""box-header with-border"">
                <i class=""fa fa-bar-chart-o""></i>

                <h3 class=""box-title"">Line Chart</h3>

                <div class=""box-tools pull-right"">
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                        <i class=""fa fa-minus""></i>
                    </button>
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class=""fa fa-times""></i></button>
                </div>
            </div>
            <div class=""box-body"">
                <div id=""line-chart"" style=""height: 300px;""></div>
            </div>
            <!-- /.box-body-->
        </div>
        <!-- /.box -->
        <!-- Area chart -->
        <div class=""box box-primary"">
            <div class=""box-header with-border"">
                <i class=""fa fa-bar-chart-o""></i>

                <h3 class=""box-title"">Full Width ");
            WriteLiteral(@"Area Chart</h3>

                <div class=""box-tools pull-right"">
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                        <i class=""fa fa-minus""></i>
                    </button>
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class=""fa fa-times""></i></button>
                </div>
            </div>
            <div class=""box-body"">
                <div id=""area-chart"" style=""height: 338px;"" class=""full-width-chart""></div>
            </div>
            <!-- /.box-body-->
        </div>
        <!-- /.box -->

    </div>
    <!-- /.col -->

    <div class=""col-md-6"">
        <!-- Bar chart -->
        <div class=""box box-primary"">
            <div class=""box-header with-border"">
                <i class=""fa fa-bar-chart-o""></i>

                <h3 class=""box-title"">Bar Chart</h3>

                <div class=""box-tools pull-right"">
                    <button type=""button"" class=""btn btn-box-tool"" data-");
            WriteLiteral(@"widget=""collapse"">
                        <i class=""fa fa-minus""></i>
                    </button>
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class=""fa fa-times""></i></button>
                </div>
            </div>
            <div class=""box-body"">
                <div id=""bar-chart"" style=""height: 300px;""></div>
            </div>
            <!-- /.box-body-->
        </div>
        <!-- /.box -->
        <!-- Donut chart -->
        <div class=""box box-primary"">
            <div class=""box-header with-border"">
                <i class=""fa fa-bar-chart-o""></i>

                <h3 class=""box-title"">Donut Chart</h3>

                <div class=""box-tools pull-right"">
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                        <i class=""fa fa-minus""></i>
                    </button>
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class=""fa fa-times""></i></but");
            WriteLiteral(@"ton>
                </div>
            </div>
            <div class=""box-body"">
                <div id=""donut-chart"" style=""height: 300px;""></div>
            </div>
            <!-- /.box-body-->
        </div>
        <!-- /.box -->
    </div>
    <!-- /.col -->
</div>
<!-- /.row -->
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas_Template_Pages_Charts_Flot> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Template_Pages_Charts_Flot> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Template_Pages_Charts_Flot>)PageContext?.ViewData;
        public Areas_Template_Pages_Charts_Flot Model => ViewData.Model;
    }
}
#pragma warning restore 1591
