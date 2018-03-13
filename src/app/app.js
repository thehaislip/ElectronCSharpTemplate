

new Vue({
    el: '#app',
    data: {
        title: 'Test Title',
        items: [
            { title: 'Tools' },
            { title: 'Manage Sites' }
        ],
        tools: []
    },
    computed:{
        showTools: function (){
            return this.tools.length > 0;
        }
    },
    methods: {
        navigate(item) {
            if (item.title == 'Tools') {
                axios.get('http://localhost:5000/api/tools')
                    .then(response => {
                        this.tools = response.data;
                    })
                    .catch(function (error) {
                        console.log(error);
                    });
            }
            else {
                this.tools = []
            }
        },
        openTool(tool){
            let proc = require('child_process').spawn;
            proc(tool.Path);
        }
    }
})