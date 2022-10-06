pipeline {
	agent none
	
	environment {
		VAL = 'ola'
		BRANCHNAME = BRANCH_NAME
	}
	
	stages {
		stages('pre') {
			steps {
				echo 'NO BRANCH MAIN'
			}
		}
		stages('pre2') {
			if (env.VAL == 'ola') {                                          
					echo 'igual'
				} else {                                   
					echo 'diferente'
				} 
		}
		stage('checkout') {
			agent any
			steps {
				echo 'checkout do BRANCH->$(env.BRANCHNAME)'
				checkout sm
			}		
		}
		stage('build') {
			steps {
				echo '$(BUILD_ID)->$(JOB_NAME):$(BUILD_NAME)'
			}
		}
	}
	
	post {
		success {
			echo 'Sucesso'
		}
	}
}


